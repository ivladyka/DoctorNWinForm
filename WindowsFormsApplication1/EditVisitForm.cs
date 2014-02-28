using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class EditVisitForm : Form
    {
        private int m_VisitID = 0;
        private int m_PatientID = 0;
        private int m_EditedIndex = -1;

        public EditVisitForm()
        {
            InitializeComponent();
            LoadMedicalTest();
        }

        public EditVisitForm(int visitID, int patientID)
        {
            VisitID = visitID;
            PatientID = patientID;
            InitializeComponent();
            LoadMedicalTest();
        }

        private int VisitID
        {
            get
            {
                return m_VisitID;
            }
            set
            {
                m_VisitID = value;
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

        private void LoadMedicalTest()
        {
            btnMedicalTest.Visible = lblMedicalTest.Visible = dgvMedicalTests.Visible = (VisitID > 0);
            if (VisitID == 0)
             {
                 this.Width = 730;
             }
             else
             {
                 dgvMedicalTests.AutoGenerateColumns = false;
                 dgvMedicalTests.Columns.Clear();

                 DataGridViewTextBoxColumn dgvcDate = new DataGridViewTextBoxColumn();
                 dgvcDate.Name = "Дата";
                 dgvcDate.DataPropertyName = "Date";
                 dgvcDate.Width = dgvcDate.MinimumWidth = 80;
                 dgvcDate.DefaultCellStyle.Format = "dd/MM/yyyy";
                 dgvMedicalTests.Columns.Add(dgvcDate);

                 DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                 dgvc.Name = "Тип аналізу";
                 dgvc.DataPropertyName = "MedicalTestTypeName";
                 dgvc.Width = dgvc.MinimumWidth = 180;
                 dgvMedicalTests.Columns.Add(dgvc);

                 DataGridViewLinkColumn lnkColView = new DataGridViewLinkColumn();
                 lnkColView.Name = "";
                 lnkColView.DataPropertyName = "ViewColumn";
                 lnkColView.LinkColor = Color.Blue;
                 lnkColView.VisitedLinkColor = Color.Blue;
                 lnkColView.Width = 80;
                 lnkColView.MinimumWidth = 80;
                 dgvMedicalTests.Columns.Add(lnkColView);
                 dgvMedicalTests.DataSource = VikkiSoft.Data.MedicalTest.SelectList(VisitID);
                 DataGridViewButtonColumn btnColDelete = new DataGridViewButtonColumn();
                 btnColDelete.Name = "";
                 btnColDelete.Width = 110;
                 btnColDelete.MinimumWidth = 110;
                 btnColDelete.DataPropertyName = "DeleteColumn";
                 dgvMedicalTests.Columns.Add(btnColDelete);
             }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (VisitID > 0)
            {
                VikkiSoft.Data.Visit.UpdateVisit(VisitID, dtpDate.Value, tbAnamnesis.Text.TrimEnd(), tbPrescription.Text.TrimEnd());
            }
            else
            {
                VisitID = VikkiSoft.Data.Visit.InsertVisit(dtpDate.Value, PatientID, tbAnamnesis.Text.TrimEnd(), tbPrescription.Text.TrimEnd());
            }
        }

        private void EditVisitForm_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            if (VisitID > 0)
            {
                this.Text = "Редагувати Візит";
                DataRow dr = VikkiSoft.Data.Visit.SelectOne(VisitID);
                if (dr != null)
                {
                    dtpDate.Value = (DateTime)dr["Date"];
                    if (!dr.IsNull("Anamnesis"))
                    {
                        tbAnamnesis.Text = dr["Anamnesis"].ToString();
                    }
                    if (!dr.IsNull("Prescription"))
                    {
                        tbPrescription.Text = dr["Prescription"].ToString();
                    }
                }
            }
        }

        private void btnMedicalTest_Click(object sender, EventArgs e)
        {
            ShowEditVisitForm(0);
        }

        private void ShowEditVisitForm(int medicalTestID)
        {
            EditMedicalTestForm frmEditMedicalTest = new EditMedicalTestForm(VisitID, medicalTestID);
            if (frmEditMedicalTest.ShowDialog() == DialogResult.OK)
            {
                LoadMedicalTest();
                if (medicalTestID > 0)
                {
                    dgvMedicalTests.Rows[m_EditedIndex].Cells[0].Selected = true;
                }
            }
        }

        private void dgvMedicalTests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = (DataRow)((DataTable)this.dgvMedicalTests.DataSource).Rows[e.RowIndex];
            int medicalTestID = int.Parse(dr["MedicalTestID"].ToString());
            switch (e.ColumnIndex)
            {
                case 0:
                    m_EditedIndex = e.RowIndex;
                    ShowEditVisitForm(medicalTestID);
                    break;
                case 2:
                    System.Diagnostics.Process.Start(System.Configuration.ConfigurationManager.AppSettings["MedicalTestFolder"] + "//" + VisitID.ToString()
                        + "//" + dr["FileName"].ToString());
                    break;
                case 3:
                    if (MessageBox.Show("Ви дійсно бажаєте видалити цей аналіз?", "Doctor N", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string medicalTestFolder = System.Configuration.ConfigurationManager.AppSettings["MedicalTestFolder"] + "//" + VisitID.ToString();
                        string filePath = Path.Combine(medicalTestFolder, dr["FileName"].ToString());
                        if (File.Exists(filePath))
                        {
                            File.Delete(filePath);
                        }
                        VikkiSoft.Data.MedicalTest.DeleteMedical(medicalTestID);
                        LoadMedicalTest();
                    }
                    break;
            }
        }
    }
}
