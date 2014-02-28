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
    public partial class SearchPatientForm : Form
    {
        private int m_EditedIndex = -1;

        public SearchPatientForm()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            ShowEditPatientFormForm(0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbLastName.Text.TrimEnd() == "")
            {
                MessageBox.Show("Введіть, будь-ласка, Прізвище!", "Doctor N", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }
            dgvPatients.AutoGenerateColumns = false;
            dgvPatients.Columns.Clear();

            DataGridViewLinkColumn lnkColEdit = new DataGridViewLinkColumn();
            lnkColEdit.Name = "Прізвище";
            lnkColEdit.DataPropertyName = "LastName";
            lnkColEdit.LinkColor = Color.Blue;
            lnkColEdit.VisitedLinkColor = Color.Blue;
            lnkColEdit.Width = 180;
            lnkColEdit.MinimumWidth = 180;
            dgvPatients.Columns.Add(lnkColEdit);

            string[] arrDataPropertyName = { "FirstName", "MiddleName", "Birthday", "Notes" };
            string[] arrName = { "Ім'я", "Побатькові", "Дата Народження", "Примітки" };
            int[] arrWidth = { 180, 180, 130, 500 };

            for (int i = 0; i < 4; i++)
            {
                DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = arrName[i];
                dgvc.DataPropertyName = arrDataPropertyName[i];
                dgvc.Width = arrWidth[i];
                dgvc.MinimumWidth = arrWidth[i];
                if (i == 2)
                {
                    dgvc.DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                dgvPatients.Columns.Add(dgvc);
            }
            LoadData();
            DataGridViewButtonColumn btnColDelete = new DataGridViewButtonColumn();
            btnColDelete.Name = "";
            btnColDelete.Width = 120;
            btnColDelete.MinimumWidth = 120;
            btnColDelete.DataPropertyName = "DeleteColumn";
            dgvPatients.Columns.Add(btnColDelete);
        }

        private void LoadData()
        {
            DataTable dt = VikkiSoft.Data.Patient.SelectList(tbFirstName.Text.TrimEnd(), tbLastName.Text.TrimEnd());
            dgvPatients.DataSource = dt;
        }

        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = (DataRow)((DataTable)this.dgvPatients.DataSource).Rows[e.RowIndex];
            int patientID = int.Parse(dr["PatientID"].ToString());
            switch (e.ColumnIndex)
            {
                case 0:
                    m_EditedIndex = e.RowIndex;
                    ShowEditPatientFormForm(patientID);
                    break;
                case 5:
                    if (MessageBox.Show("Ви дійсно бажаєте видалити цього пацієнта?", "Doctor N", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        VikkiSoft.Data.Patient.DeletePatient(patientID);
                        LoadData();
                    }
                    break;
            }
        }

        private void ShowEditPatientFormForm(int patientID)
        {
            EditPatientForm frmEditPatient = new EditPatientForm(patientID);
            if (frmEditPatient.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                if (patientID > 0)
                {
                    dgvPatients.Rows[m_EditedIndex].Cells[0].Selected = true;
                }
            }
        }
    }
}
