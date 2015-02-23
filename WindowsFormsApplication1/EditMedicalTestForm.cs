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
    public partial class EditMedicalTestForm : Form
    {
        private int m_VisitID = 0;
        private int m_MedicalTestID = 0;
        private string m_AddedFiles = "";

        public EditMedicalTestForm()
        {
            InitializeComponent();
        }

        public EditMedicalTestForm(int visitID, int medicalTestID)
        {
            VisitID = visitID;
            MedicalTestID = medicalTestID;
            InitializeComponent();
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

        private int MedicalTestID
        {
            get
            {
                return m_MedicalTestID;
            }
            set
            {
                m_MedicalTestID = value;
            }
        }

        private void EditMedicalTestForm_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            ddlMedicalTestType.ValueMember = "MedicalTestTypeID";
            ddlMedicalTestType.DisplayMember = "Name";
            ddlMedicalTestType.DataSource = VikkiSoft.Data.MedicalTestType.SelectList();

            if (MedicalTestID > 0)
            {
                this.Text = "Редагувати Документ";
                DataRow dr = VikkiSoft.Data.MedicalTest.SelectOne(MedicalTestID);
                if (dr != null)
                {
                    dtpDate.Value = (DateTime)dr["Date"];
                    ddlMedicalTestType.SelectedValue = dr["MedicalTestTypeID"].ToString();
                }
            }
            LoadDocuments();
        }

        private void LoadDocuments()
        {
            dgvDocumentFiles.AutoGenerateColumns = false;
            dgvDocumentFiles.Columns.Clear();

            DataTable dt = VikkiSoft.Data.Document.SelectListByMedicalTestID(MedicalTestID);
            DataColumn col = new DataColumn();
            col.DataType = System.Type.GetType("System.String");
            col.AllowDBNull = true;
            col.Caption = "";
            col.ColumnName = "FileNameFull";
            col.DefaultValue = string.Empty;
            dt.Columns.Add(col);

            DataGridViewLinkColumn lnkColView = new DataGridViewLinkColumn();
            lnkColView.Name = "Назва Файлу";
            lnkColView.DataPropertyName = "FileNameFull";
            lnkColView.LinkColor = Color.Blue;
            lnkColView.VisitedLinkColor = Color.Blue;
            if (MedicalTestID > 0)
            {
                lnkColView.Width = lnkColView.MinimumWidth = 300;
            }
            else
            {
                lnkColView.Width = lnkColView.MinimumWidth = 400;
            }
            dgvDocumentFiles.Columns.Add(lnkColView);

            DataGridViewButtonColumn btnColDelete = new DataGridViewButtonColumn();
            btnColDelete.Name = "";
            btnColDelete.Width = 110;
            btnColDelete.MinimumWidth = 110;
            btnColDelete.DataPropertyName = "DeleteColumn";
            dgvDocumentFiles.Columns.Add(btnColDelete);
            if (MedicalTestID > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["FileNameFull"] = (i + 1).ToString();
                }
                dgvDocumentFiles.Width = 474;
                ddlMedicalTestType.Width = 345;
                btnSelect.Location = new Point(320, 74);
                btnSave.Location = new Point(135, 226);
                btnCancel.Location = new Point(320, 226);
                this.Width = 505;
            }
            else
            {
                string[] arrFiles = m_AddedFiles.Split(',');
                for (int i = 0; i < arrFiles.Length; i++)
                {
                    if (!string.IsNullOrEmpty(arrFiles[i]))
                    {
                        DataRow dr;
                        dr = dt.NewRow();
                        dr["DeleteColumn"] = "Видалити";
                        dr["FileNameFull"] = arrFiles[i];
                        dt.Rows.Add(dr);
                    }
                }
            }

            dgvDocumentFiles.DataSource = dt;

            foreach (DataGridViewColumn c in dgvDocumentFiles.Columns)
            {
                c.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MedicalTestID > 0)
            {
                VikkiSoft.Data.MedicalTest.UpdateMedicalTest(MedicalTestID, dtpDate.Value, int.Parse(ddlMedicalTestType.SelectedValue.ToString()));
            }
            else
            {
                if (dgvDocumentFiles.RowCount == 0)
                {
                    MessageBox.Show("Виберіть документ!", "Doctor N", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.None;
                    return;
                }
                if (!System.IO.Directory.Exists(MedicalTestFolder + "//"))
                {
                    System.IO.Directory.CreateDirectory(MedicalTestFolder + "//");
                }

                MedicalTestID = VikkiSoft.Data.MedicalTest.InsertMedicalTest(dtpDate.Value, int.Parse(ddlMedicalTestType.SelectedValue.ToString()), VisitID);
                string[] arrFiles = m_AddedFiles.Split(',');
                for (int i = 0; i < arrFiles.Length; i++)
                {
                    InsertDocument(arrFiles[i].TrimEnd());
                }
            }

        }

        private string MedicalTestFolder
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["MedicalTestFolder"] + "//" + VisitID.ToString();
            }
        }

        private void InsertDocument(string originalFileName)
        {
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(originalFileName);
            File.Copy(originalFileName, MedicalTestFolder + "//" + fileName);
            VikkiSoft.Data.Document.InsertDocument(MedicalTestID, fileName);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open File";
            openFileDialog1.Filter = "All Files|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName == "")
                return;
            else
            {
                if (MedicalTestID == 0)
                {
                    if (string.IsNullOrEmpty(m_AddedFiles))
                    {
                        m_AddedFiles = openFileDialog1.FileName;
                    }
                    else
                    {
                        m_AddedFiles += "," + openFileDialog1.FileName;
                    }
                }
                else
                {
                    InsertDocument(openFileDialog1.FileName);
                }
                LoadDocuments();
            }
        }

        private void dgvDocumentFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow dr = (DataRow)((DataTable)this.dgvDocumentFiles.DataSource).Rows[e.RowIndex];
                if (e.ColumnIndex == 0)
                {
                    if (MedicalTestID > 0)
                    {
                        System.Diagnostics.Process.Start(@System.Configuration.ConfigurationManager.AppSettings["MedicalTestFolder"] + "\\" + VisitID.ToString()
                            + "\\" + dr["FileName"].ToString());
                    }
                    else
                    {
                        System.Diagnostics.Process.Start(@dr["FileNameFull"].ToString());
                    }
                } 
                else
                {
                    if (MessageBox.Show("Ви дійсно бажаєте видалити цей документ?", "Doctor N", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (MedicalTestID > 0)
                        {
                            string medicalTestFolder = System.Configuration.ConfigurationManager.AppSettings["MedicalTestFolder"] + "\\" + VisitID.ToString();
                            string filePath = Path.Combine(medicalTestFolder, dr["FileName"].ToString());
                            if (File.Exists(filePath))
                            {
                                File.Delete(filePath);
                            }
                            VikkiSoft.Data.Document.DeleteDocument(int.Parse(dr["DocumentID"].ToString()));
                        }
                        else
                        {
                            string fileName = dr["FileNameFull"].ToString();
                            string[] arrFiles = m_AddedFiles.Split(',');
                            m_AddedFiles = "";
                            for (int i = 0; i < arrFiles.Length; i++)
                            {
                                if (arrFiles[i] != fileName && !string.IsNullOrEmpty(fileName))
                                {
                                    if (string.IsNullOrEmpty(m_AddedFiles))
                                    {
                                        m_AddedFiles = arrFiles[i];
                                    }
                                    else
                                    {
                                        m_AddedFiles += "," + arrFiles[i];
                                    }
                                }
                            }
                            
                        }
                        LoadDocuments();
                    }
                }
            }
        }
    }
}
