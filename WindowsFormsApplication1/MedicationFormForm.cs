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
    public partial class MedicationFormForm : Form
    {
        private int m_EditedIndex = -1;

        public MedicationFormForm()
        {
            InitializeComponent();
        }

        private void btnAddMedicationForm_Click(object sender, EventArgs e)
        {
            ShowEditMedicationFormForm(0);
        }

        private void MedicationFormForm_Load(object sender, EventArgs e)
        {
            dgvMedicationForm.AutoGenerateColumns = false;

            DataGridViewLinkColumn lnkColEdit = new DataGridViewLinkColumn();
            lnkColEdit.Name = "Лікарська Форма";
            lnkColEdit.ToolTipText = "Name";
            lnkColEdit.DataPropertyName = "Name";
            lnkColEdit.LinkColor = Color.Blue;
            lnkColEdit.VisitedLinkColor = Color.Blue;
            lnkColEdit.Width = 600;
            lnkColEdit.MinimumWidth = 600;
            dgvMedicationForm.Columns.Add(lnkColEdit);
            LoadData();

            DataGridViewButtonColumn btnColDelete = new DataGridViewButtonColumn();
            btnColDelete.Name = "";
            btnColDelete.Width = 120;
            btnColDelete.MinimumWidth = 120;
            btnColDelete.DataPropertyName = "DeleteColumn";
            dgvMedicationForm.Columns.Add(btnColDelete);
            foreach (DataGridViewColumn c in dgvMedicationForm.Columns)
            {
                c.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        private void LoadData()
        {
            DataTable dt = VikkiSoft.Data.MedicationForm.SelectList();
            dgvMedicationForm.DataSource = dt;
        }

        private void dgvMedicationForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow dr = (DataRow)((DataTable)this.dgvMedicationForm.DataSource).Rows[e.RowIndex];
                int medicationFormID = int.Parse(dr["MedicationFormID"].ToString());
                switch (e.ColumnIndex)
                {
                    case 0:
                        m_EditedIndex = e.RowIndex;
                        ShowEditMedicationFormForm(medicationFormID);
                        break;
                    case 1:
                        if (MessageBox.Show("Ви дійсно бажаєте видалити цю лікарську форму?", "Doctor N", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            try
                            {
                                VikkiSoft.Data.MedicationForm.DeleteMedicationForm(medicationFormID);
                                LoadData();
                            }
                            catch
                            {
                                MessageBox.Show("Ви не можете видалити цю лікарську форму, тому що вона використовується.", "Doctor N", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                }
            }
        }

        private void ShowEditMedicationFormForm(int medicationFormID)
        {
            EditMedicationFormForm frmEditMedicationForm = new EditMedicationFormForm(medicationFormID);
            if (frmEditMedicationForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                if (medicationFormID > 0)
                {
                    dgvMedicationForm.Rows[m_EditedIndex].Cells[0].Selected = true;
                }
            }
        }
    }
}
