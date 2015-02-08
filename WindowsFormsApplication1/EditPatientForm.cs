using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class EditPatientForm : Form
    {
        private int m_PatientID = 0;
        private int m_EditedIndex = -1;

        public EditPatientForm()
        {
            InitializeComponent();
            LoadVisit();
        }

        public EditPatientForm(int patientID)
        {
            PatientID = patientID;
            InitializeComponent();
            LoadVisit();
        }

        private void LoadVisit()
        {
            btnAddVisit.Visible = lblVisits.Visible = dgvVisits.Visible = (PatientID > 0);
            if (PatientID == 0)
            {
                this.Height = 280;
            }
            else
            {
                this.Height = 652;
                dgvVisits.AutoGenerateColumns = false;
                dgvVisits.Columns.Clear();

                DataGridViewLinkColumn lnkColEdit = new DataGridViewLinkColumn();
                lnkColEdit.Name = "Дата";
                lnkColEdit.DataPropertyName = "Date";
                lnkColEdit.LinkColor = Color.Blue;
                lnkColEdit.VisitedLinkColor = Color.Blue;
                lnkColEdit.Width = 80;
                lnkColEdit.MinimumWidth = 80;
                lnkColEdit.DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvVisits.Columns.Add(lnkColEdit);

                string[] arrDataPropertyName = { "Anamnesis", "Prescription" };
                string[] arrName = { "Анамнез", "Призначення" };
                int[] arrWidth = { 430, 430 };

                for (int i = 0; i < 2; i++)
                {
                    DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                    dgvc.Name = arrName[i];
                    dgvc.DataPropertyName = arrDataPropertyName[i];
                    dgvc.Width = arrWidth[i];
                    dgvc.MinimumWidth = arrWidth[i];
                    dgvc.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dgvVisits.Columns.Add(dgvc);
                }
                dgvVisits.DataSource = VikkiSoft.Data.Visit.SelectList(PatientID);
                DataGridViewButtonColumn btnColDelete = new DataGridViewButtonColumn();
                btnColDelete.Name = "";
                btnColDelete.Width = 120;
                btnColDelete.MinimumWidth = 120;
                btnColDelete.DataPropertyName = "DeleteColumn";
                dgvVisits.Columns.Add(btnColDelete);
                foreach (DataGridViewColumn c in dgvVisits.Columns)
                {
                    c.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
                }
            }
        }

        private int PatientID
        {
            get
            {
                return m_PatientID;
            }
            set
            {
                m_PatientID = value;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbLastName.Text.TrimEnd() == "")
            {
                MessageBox.Show("Введіть, будь-ласка, Прізвище!", "Doctor N", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }
            if (tbFirstName.Text.TrimEnd() == "")
            {
                MessageBox.Show("Введіть, будь-ласка, Ім'я!", "Doctor N", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }
            if (PatientID > 0)
            {
                VikkiSoft.Data.Patient.UpdatePatient(PatientID, tbFirstName.Text.TrimEnd(), tbLastName.Text.TrimEnd(),
                    tbMiddleName.Text.TrimEnd(), dtpBirthday.Value, tbNotes.Text, tbEducation.Text, tbWorkPosition.Text, tbPhone.Text, tbFinancialNotes.Text);
            }
            else
            {
                PatientID = VikkiSoft.Data.Patient.InsertPatient(tbFirstName.Text.TrimEnd(), tbLastName.Text.TrimEnd(),
                    tbMiddleName.Text.TrimEnd(), dtpBirthday.Value, tbNotes.Text, tbEducation.Text, tbWorkPosition.Text, tbPhone.Text, tbFinancialNotes.Text);
                LoadVisit();
            }
        }

        private void EditPatientForm_Load(object sender, EventArgs e)
        {
            dtpBirthday.Value = dtpBirthday.MinDate;
            if (PatientID > 0)
            {
                this.Text = "Редагувати Пацієнта";
                DataRow dr = VikkiSoft.Data.Patient.SelectOne(PatientID);
                if (dr != null)
                {
                    tbFirstName.Text = dr["FirstName"].ToString();
                    tbLastName.Text = dr["LastName"].ToString();
                    if (!dr.IsNull("MiddleName"))
                    {
                        tbMiddleName.Text = dr["MiddleName"].ToString();
                    }
                    if (!dr.IsNull("Birthday"))
                    {
                        dtpBirthday.Value = (DateTime)dr["Birthday"];
                    }
                    if (!dr.IsNull("Notes"))
                    {
                        tbNotes.Text = dr["Notes"].ToString();
                    }
                    if (!dr.IsNull("Education"))
                    {
                        tbEducation.Text = dr["Education"].ToString();
                    }
                    if (!dr.IsNull("WorkPosition"))
                    {
                        tbWorkPosition.Text = dr["WorkPosition"].ToString();
                    }
                    if (!dr.IsNull("Phone"))
                    {
                        tbPhone.Text = dr["Phone"].ToString();
                    }
                    if (!dr.IsNull("FinancialNotes"))
                    {
                        tbFinancialNotes.Text = dr["FinancialNotes"].ToString();
                    }
                }
            }
        }

        private void btnAddVisit_Click(object sender, EventArgs e)
        {
            ShowEditVisitForm(0);
        }

        private void ShowEditVisitForm(int visitID)
        {
            EditVisitForm frmEditVisit = new EditVisitForm(visitID, PatientID);
            if (frmEditVisit.ShowDialog() == DialogResult.OK)
            {
                LoadVisit();
                if (visitID > 0)
                {
                    dgvVisits.Rows[m_EditedIndex].Cells[0].Selected = true;
                }
            }
        }

        private void dgvVisits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow dr = (DataRow)((DataTable)this.dgvVisits.DataSource).Rows[e.RowIndex];
                int visitID = int.Parse(dr["VisitID"].ToString());
                switch (e.ColumnIndex)
                {
                    case 0:
                        m_EditedIndex = e.RowIndex;
                        ShowEditVisitForm(visitID);
                        break;
                    case 3:
                        if (MessageBox.Show("Ви дійсно бажаєте видалити цей візит?", "Doctor N", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            string medicalTestFolder = System.Configuration.ConfigurationManager.AppSettings["MedicalTestFolder"] + "//" + visitID.ToString();
                            if (Directory.Exists(medicalTestFolder))
                            {
                                Directory.Delete(medicalTestFolder, true);
                            }
                            VikkiSoft.Data.Visit.DeleteVisit(visitID);
                            LoadVisit();
                        }
                        break;
                }
            }
        }
    }
}
