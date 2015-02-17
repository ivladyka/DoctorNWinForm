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
    public partial class MedicationWindowsForm : Form
    {
        private int m_EditedIndex = -1;
        private int m_CountRowsPerPage = 28;
        private int m_PageNumber = 1;

        public MedicationWindowsForm()
        {
            InitializeComponent();
        }

        private void btnAddMedication_Click(object sender, EventArgs e)
        {
            ShowEditMedicationForm(0);
        }

        private void MedicationWindowsForm_Load(object sender, EventArgs e)
        {
            dgvMedication.AutoGenerateColumns = false;

            DataGridViewLinkColumn lnkColEdit = new DataGridViewLinkColumn();
            lnkColEdit.Name = "Ліки";
            lnkColEdit.ToolTipText = "Name";
            lnkColEdit.DataPropertyName = "Name";
            lnkColEdit.LinkColor = Color.Blue;
            lnkColEdit.VisitedLinkColor = Color.Blue;
            lnkColEdit.Width = 600;
            lnkColEdit.MinimumWidth = 600;
            dgvMedication.Columns.Add(lnkColEdit);

            DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
            dgvc.Name = "Лікарська Форма";
            dgvc.DataPropertyName = "MedicationFormName";
            dgvc.Width = 200;
            dgvc.MinimumWidth = 200;
            dgvMedication.Columns.Add(dgvc);

            LoadData();

            DataGridViewButtonColumn btnColDelete = new DataGridViewButtonColumn();
            btnColDelete.Name = "";
            btnColDelete.Width = 120;
            btnColDelete.MinimumWidth = 120;
            btnColDelete.DataPropertyName = "DeleteColumn";
            dgvMedication.Columns.Add(btnColDelete);
            foreach (DataGridViewColumn c in dgvMedication.Columns)
            {
                c.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        private void LoadData()
        {
            int countMedication = VikkiSoft.Data.Medication.GetMedicationCount();
            int offset = (m_PageNumber - 1) * m_CountRowsPerPage;
            DataTable dt = VikkiSoft.Data.Medication.SelectListWithOffset(offset, m_CountRowsPerPage);
            dgvMedication.DataSource = dt;
            if(countMedication > m_CountRowsPerPage)
            {
                ddlPage.Visible = lblPageTitle.Visible = true;
                int countPage = countMedication/m_CountRowsPerPage;
                if(countMedication%m_CountRowsPerPage > 0)
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

        private void ShowEditMedicationForm(int medicationID)
        {
            EditMedicationForm frmEditMedicationForm = new EditMedicationForm(medicationID);
            if (frmEditMedicationForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                if (medicationID > 0)
                {
                    dgvMedication.Rows[m_EditedIndex].Cells[0].Selected = true;
                }
            }
        }

        private void dgvMedication_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow dr = (DataRow)((DataTable)this.dgvMedication.DataSource).Rows[e.RowIndex];
                int medicationID = int.Parse(dr["MedicationID"].ToString());
                switch (e.ColumnIndex)
                {
                    case 0:
                        m_EditedIndex = e.RowIndex;
                        ShowEditMedicationForm(medicationID);
                        break;
                    case 2:
                        if (MessageBox.Show("Ви дійсно бажаєте видалити ці ліки?", "Doctor N", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            try
                            {
                                VikkiSoft.Data.Medication.DeleteMedication(medicationID);
                                LoadData();
                            }
                            catch
                            {
                                MessageBox.Show("Ви не можете видалити ці ліки, тому що вони використовуються.", "Doctor N", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
