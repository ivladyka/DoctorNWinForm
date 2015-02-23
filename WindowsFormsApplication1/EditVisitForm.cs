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
        private int m_CountFilesMax = 0;

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

        private int CountFilesMax
        {
            get
            {
                return m_CountFilesMax;
            }
            set
            {
                m_CountFilesMax = value;
            }
        }

        private void LoadMedicalTest()
        {
            btnMedicalTest.Visible = lblMedicalTest.Visible = dgvMedicalTests.Visible = (VisitID > 0);
            if (VisitID == 0)
             {
                 this.Width = 540;
                 btnSave.Location = new Point(150, 452);
                 btnCancel.Location = new Point(335, 452);
             }
             else
             {
                 dgvMedicalTests.AutoGenerateColumns = false;
                 dgvMedicalTests.Columns.Clear();

                 DataTable dt = VikkiSoft.Data.MedicalTest.SelectList(VisitID);
                 CountFilesMax = GetFilesMaxCount(dt);
                 for (int i = 0; i < CountFilesMax; i++)
                 {
                     DataColumn col = new DataColumn();
                     col.DataType = System.Type.GetType("System.String");
                     col.AllowDBNull = true;
                     col.Caption = "";
                     col.ColumnName = "ViewColumn" + i.ToString();
                     col.DefaultValue = string.Empty;
                     dt.Columns.Add(col);

                     col = new DataColumn();
                     col.DataType = System.Type.GetType("System.String");
                     col.AllowDBNull = false;
                     col.Caption = "";
                     col.ColumnName = "FileName" + i.ToString();
                     col.DefaultValue = string.Empty;
                     dt.Columns.Add(col);
                 }

                 foreach (DataRow dr in dt.Rows)
                 {
                     if (!dr.IsNull("AllFiles"))
                     {
                         string[] arrFiles = dr["AllFiles"].ToString().Split(',');
                         for (int i = 0; i < arrFiles.Length; i++)
                         {
                             dr["ViewColumn" + i.ToString()] = (i+1).ToString();
                             dr["FileName" + i.ToString()] = arrFiles[i];
                         }
                     }
                 }

                 DataGridViewLinkColumn dgvcDate = new DataGridViewLinkColumn();
                 dgvcDate.Name = "Дата";
                 dgvcDate.DataPropertyName = "Date";
                 dgvcDate.Width = dgvcDate.MinimumWidth = 80;
                 dgvcDate.LinkColor = Color.Blue;
                 dgvcDate.VisitedLinkColor = Color.Blue;
                 dgvcDate.DefaultCellStyle.Format = "dd/MM/yyyy";
                 dgvMedicalTests.Columns.Add(dgvcDate);

                 DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                 dgvc.Name = "Тип документу";
                 dgvc.DataPropertyName = "MedicalTestTypeName";
                 dgvc.Width = dgvc.MinimumWidth = 180;
                 dgvMedicalTests.Columns.Add(dgvc);

                 for (int i = 0; i < CountFilesMax; i++)
                 {
                     DataGridViewLinkColumn lnkColView = new DataGridViewLinkColumn();
                     lnkColView.Name = "";
                     lnkColView.DataPropertyName = "ViewColumn" + i.ToString();
                     lnkColView.LinkColor = Color.Blue;
                     lnkColView.VisitedLinkColor = Color.Blue;
                     lnkColView.Width = 10;
                     lnkColView.MinimumWidth = 10;
                     lnkColView.ToolTipText = "Проглянути";
                     dgvMedicalTests.Columns.Add(lnkColView);
                 }

                 dgvMedicalTests.DataSource = dt;
                 DataGridViewButtonColumn btnColDelete = new DataGridViewButtonColumn();
                 btnColDelete.Name = "";
                 btnColDelete.Width = 110;
                 btnColDelete.MinimumWidth = 110;
                 btnColDelete.DataPropertyName = "DeleteColumn";
                 dgvMedicalTests.Columns.Add(btnColDelete);
                 foreach (DataGridViewColumn c in dgvMedicalTests.Columns)
                 {
                     c.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
                 }
             }
        }

        private int GetFilesMaxCount(DataTable dt)
        {
            int count = 0;
            foreach(DataRow dr in dt.Rows)
            {
                if (!dr.IsNull("AllFiles"))
                {
                    string[] arrFiles = dr["AllFiles"].ToString().Split(',');
                    if(arrFiles.Length > count)
                    {
                        count = arrFiles.Length;
                    }
                }
            }
            return count;
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
            frmEditMedicalTest.ShowDialog();
            LoadMedicalTest();
            if (medicalTestID > 0)
            {
                dgvMedicalTests.Rows[m_EditedIndex].Cells[0].Selected = true;
            }
        }

        private void dgvMedicalTests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow dr = (DataRow)((DataTable)this.dgvMedicalTests.DataSource).Rows[e.RowIndex];
                int medicalTestID = int.Parse(dr["MedicalTestID"].ToString());
                if (e.ColumnIndex == (CountFilesMax + 2))
                {
                    if (MessageBox.Show("Ви дійсно бажаєте видалити цей документ?", "Doctor N", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        string medicalTestFolder = System.Configuration.ConfigurationManager.AppSettings["MedicalTestFolder"] + "\\" + VisitID.ToString();
                        for (int i = 0; i < CountFilesMax; i++)
                        {
                            string filePath = Path.Combine(medicalTestFolder, dr["FileName" + i.ToString()].ToString());
                            if (File.Exists(filePath))
                            {
                                File.Delete(filePath);
                            }
                        }
                        VikkiSoft.Data.MedicalTest.DeleteMedical(medicalTestID);
                        LoadMedicalTest();
                    }
                }
                else if (e.ColumnIndex >= 2)
                {
                    System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["MedicalTestFolder"] + "\\" + VisitID.ToString()
                            + "\\" + dr["FileName" + (e.ColumnIndex - 2).ToString()].ToString());
                }
                else if (e.ColumnIndex == 0)
                {
                    m_EditedIndex = e.RowIndex;
                    ShowEditVisitForm(medicalTestID);
                }
            }
        }

        private void dgvMedicalTests_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            if(e.ColumnIndex >= 2 && e.ColumnIndex <(CountFilesMax + 2))
            {
                e.ToolTipText = "Проглянути";
            }
            if (e.ColumnIndex == 0)
            {
                e.ToolTipText = "Редагувати";
            }
        }
    }
}
