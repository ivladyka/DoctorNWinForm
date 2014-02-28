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
    public partial class AddMedicalTestTypeForm : Form
    {
        private int m_MedicalTestTypeID = 0;

        public AddMedicalTestTypeForm()
        {
            InitializeComponent();
        }

        public AddMedicalTestTypeForm(int medicalTestTypeID)
        {
            MedicalTestTypeID = medicalTestTypeID;
            InitializeComponent();
        }

        private int MedicalTestTypeID
        {
            get
            {
                return m_MedicalTestTypeID;
            }
            set
            {
                m_MedicalTestTypeID = value;
            }
        }

        private void AddMedicalTestTypeForm_Load(object sender, EventArgs e)
        {
            if (MedicalTestTypeID > 0)
            {
                this.Text = "Редагувати тип аналізу";
                DataRow dr = VikkiSoft.Data.MedicalTestType.SelectOne(MedicalTestTypeID);
                if (dr != null)
                {
                    tbName.Text = dr["Name"].ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text.TrimEnd() == "")
            {
                MessageBox.Show("Введіть, будь-ласка, тип аналізу!", "Doctor N", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }
            if (MedicalTestTypeID > 0)
            {
                VikkiSoft.Data.MedicalTestType.UpdateMedicalTestType(MedicalTestTypeID, tbName.Text.TrimEnd());
            }
            else
            {
                VikkiSoft.Data.MedicalTestType.InsertMedicalTestType(tbName.Text.TrimEnd());
            }
        }
    }
}
