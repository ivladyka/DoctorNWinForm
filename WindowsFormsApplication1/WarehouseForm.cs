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
    public partial class WarehouseForm : Form
    {
        private int m_EditedIndex = -1;

        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            dgvMedicationWarehouse.AutoGenerateColumns = false;

            DataGridViewLinkColumn lnkColEdit = new DataGridViewLinkColumn();
            lnkColEdit.Name = "Ліки";
            lnkColEdit.ToolTipText = "Name";
            lnkColEdit.DataPropertyName = "Name";
            lnkColEdit.LinkColor = Color.Blue;
            lnkColEdit.VisitedLinkColor = Color.Blue;
            lnkColEdit.Width = 600;
            lnkColEdit.MinimumWidth = 600;
            dgvMedicationWarehouse.Columns.Add(lnkColEdit);

            string[] arrDataPropertyName = { "MedicationFormName", "CountInStock" };
            string[] arrName = { "Лікарська Форма", "Кількість" };
            int[] arrWidth = { 200, 90 };

            for (int i = 0; i < 2; i++)
            {
                DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = arrName[i];
                dgvc.DataPropertyName = arrDataPropertyName[i];
                dgvc.Width = arrWidth[i];
                dgvc.MinimumWidth = arrWidth[i];
                dgvc.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvc.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvMedicationWarehouse.Columns.Add(dgvc);
            }

            LoadData();

            foreach (DataGridViewColumn c in dgvMedicationWarehouse.Columns)
            {
                c.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        private void LoadData()
        {
            DataTable dt = VikkiSoft.Data.Medication.SelectMedicationWarehouseList();
            dgvMedicationWarehouse.DataSource = dt;
        }

        private void btnAddMedicationFlow_Click(object sender, EventArgs e)
        {
            EditMedicationFlow frmEditMedicationFlow = new EditMedicationFlow(0);
            if (frmEditMedicationFlow.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void dgvMedicationWarehouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow dr = (DataRow)((DataTable)this.dgvMedicationWarehouse.DataSource).Rows[e.RowIndex];
                int medicationID = int.Parse(dr["MedicationID"].ToString());
                if (e.ColumnIndex == 0)
                {
                    m_EditedIndex = e.RowIndex;
                    EditMedicationWarehouseForm frmEditMedicationForm = new EditMedicationWarehouseForm(medicationID);
                    if (frmEditMedicationForm.ShowDialog() == DialogResult.Cancel)
                    {
                        LoadData();
                        if (medicationID > 0)
                        {
                            dgvMedicationWarehouse.Rows[m_EditedIndex].Cells[0].Selected = true;
                        }
                    }
                }
            }
        }
    }
}
