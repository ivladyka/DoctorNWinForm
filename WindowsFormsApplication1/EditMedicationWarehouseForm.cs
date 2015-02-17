using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EditMedicationWarehouseForm : Form
    {
        private int m_EditedIndex = -1;
        private int m_MedicationID = 0;
        private int m_CountRowsPerPage = 20;
        private int m_PageNumber = 1;

        public EditMedicationWarehouseForm()
        {
            InitializeComponent();
        }

        public EditMedicationWarehouseForm(int medicationID)
        {
            MedicationID = medicationID;
            InitializeComponent();
        }

        private int MedicationID
        {
            get
            {
                return m_MedicationID;
            }
            set
            {
                m_MedicationID = value;
            }
        }

        private void EditMedicationWarehouseForm_Load(object sender, EventArgs e)
        {
            LoadMedicationData();

            dgvMedicationFlow.AutoGenerateColumns = false;

            DataGridViewLinkColumn lnkColEdit = new DataGridViewLinkColumn();
            lnkColEdit.Name = "Дата";
            lnkColEdit.DataPropertyName = "Date";
            lnkColEdit.LinkColor = Color.Blue;
            lnkColEdit.VisitedLinkColor = Color.Blue;
            lnkColEdit.Width = lnkColEdit.MinimumWidth = 80;
            lnkColEdit.DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvMedicationFlow.Columns.Add(lnkColEdit);

            string[] arrDataPropertyName = { "MedicationFlowTypeName", "Count", "Note" };
            string[] arrName = { "Тип", "Кількість", "Примітки" };
            int[] arrWidth = { 80, 80, 200 };

            for (int i = 0; i < 3; i++)
            {
                DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = arrName[i];
                dgvc.DataPropertyName = arrDataPropertyName[i];
                dgvc.Width = arrWidth[i];
                dgvc.MinimumWidth = arrWidth[i];
                if (i < 2)
                {
                    dgvc.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                dgvc.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvMedicationFlow.Columns.Add(dgvc);
            }

            LoadData();

            DataGridViewButtonColumn btnColDelete = new DataGridViewButtonColumn();
            btnColDelete.Name = "";
            btnColDelete.Width = 120;
            btnColDelete.MinimumWidth = 120;
            btnColDelete.DataPropertyName = "DeleteColumn";
            dgvMedicationFlow.Columns.Add(btnColDelete);
            foreach (DataGridViewColumn c in dgvMedicationFlow.Columns)
            {
                c.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        private void LoadMedicationData()
        {
            if (MedicationID > 0)
            {
                DataRow dr = VikkiSoft.Data.Medication.SelectOne(MedicationID);
                if (dr != null)
                {
                    lblMedicationValue.Text = dr["MedicationFullName"].ToString();
                    lblCountValue.Text = dr["CountInStock"].ToString();
                }
            }
        }

        private void LoadData()
        {
            int countMedicationFlow = VikkiSoft.Data.MedicationFlow.GetMedicationFlowCount(MedicationID);
            int offset = (m_PageNumber - 1) * m_CountRowsPerPage;
            DataTable dt = VikkiSoft.Data.MedicationFlow.SelectListByMedicationIDWithOffset(MedicationID, offset, m_CountRowsPerPage);
            dgvMedicationFlow.DataSource = dt;
            if (countMedicationFlow > m_CountRowsPerPage)
            {
                ddlPage.Visible = lblPageTitle.Visible = true;
                int countPage = countMedicationFlow / m_CountRowsPerPage;
                if (countMedicationFlow % m_CountRowsPerPage > 0)
                {
                    countPage++;
                }
                ddlPage.Items.Clear();
                for (int i = 1; i <= countPage; i++)
                {
                    ddlPage.Items.Add(i.ToString());
                }
                ddlPage.SelectedIndex = (m_PageNumber - 1);
            }
            else
            {
                ddlPage.Visible = lblPageTitle.Visible = false;
            }
        }

        private void btnAddMedicationFlow_Click(object sender, EventArgs e)
        {
            ShowEditMedicationFlow(0, MedicationID);
        }

        private void ShowEditMedicationFlow(int medicationFlowID, int medicationID)
        {
            EditMedicationFlow frmEditMedicationFlow = new EditMedicationFlow(medicationFlowID, medicationID);
            if (frmEditMedicationFlow.ShowDialog() == DialogResult.OK)
            {
                LoadMedicationData();
                LoadData();
                if (medicationFlowID > 0)
                {
                    dgvMedicationFlow.Rows[m_EditedIndex].Cells[0].Selected = true;
                }
            }
        }

        private void dgvMedicationFlow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow dr = (DataRow)((DataTable)this.dgvMedicationFlow.DataSource).Rows[e.RowIndex];
                int medicationFlowID = int.Parse(dr["MedicationFlowID"].ToString());
                switch (e.ColumnIndex)
                {
                    case 0:
                        m_EditedIndex = e.RowIndex;
                        ShowEditMedicationFlow(medicationFlowID, 0);
                        break;
                    case 4:
                        if (MessageBox.Show("Ви дійсно бажаєте видалити цей прихід/розхід?", "Doctor N", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            try
                            {
                                VikkiSoft.Data.MedicationFlow.DeleteMedicationFlow(medicationFlowID);
                                LoadMedicationData();
                                LoadData();
                            }
                            catch
                            {
                                MessageBox.Show("Ви не можете видалити цей прихід/розхід, тому що він використовується.", "Doctor N", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                }
            }
        }

        private void ddlPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_PageNumber != ddlPage.SelectedIndex + 1)
            {
                m_PageNumber = ddlPage.SelectedIndex + 1;
                LoadData();
            }
        }
    }
}
