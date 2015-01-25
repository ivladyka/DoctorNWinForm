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
                lblDoument.Visible = false;
                tbFileName.Visible = false;
                btnSelect.Visible = false;
                btnSave.Location = new Point(169, 76);
                btnCancel.Location = new Point(354, 76);
                this.Size = new Size(551, 161);
                DataRow dr = VikkiSoft.Data.MedicalTest.SelectOne(MedicalTestID);
                if (dr != null)
                {
                    dtpDate.Value = (DateTime)dr["Date"];
                    ddlMedicalTestType.SelectedValue = dr["MedicalTestTypeID"].ToString();
                }
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
                if (tbFileName.Text.TrimEnd() == "")
                {
                    MessageBox.Show("Виберіть документ!", "Doctor N", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.None;
                    return;
                }
                string medicalTestFolder = System.Configuration.ConfigurationManager.AppSettings["MedicalTestFolder"] + "//" + VisitID.ToString();
                if (!System.IO.Directory.Exists(medicalTestFolder + "//"))
                {
                    System.IO.Directory.CreateDirectory(medicalTestFolder + "//");
                }
                string ext = Path.GetExtension(tbFileName.Text.TrimEnd());
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(tbFileName.Text.TrimEnd());
                File.Copy(tbFileName.Text.TrimEnd(), medicalTestFolder + "//" + fileName);
                VisitID = VikkiSoft.Data.MedicalTest.InsertMedicalTest(dtpDate.Value, int.Parse(ddlMedicalTestType.SelectedValue.ToString()), fileName, VisitID);
            }

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
                tbFileName.Text = openFileDialog1.FileName;
        }
    }
}
