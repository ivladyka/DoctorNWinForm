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
    public partial class EditMedicationFormForm : Form
    {
        private int m_MedicationFormID = 0;

        public EditMedicationFormForm()
        {
            InitializeComponent();
        }

        public EditMedicationFormForm(int medicationFormID)
        {
            MedicationFormID = medicationFormID;
            InitializeComponent();
        }

        private int MedicationFormID
        {
            get
            {
                return m_MedicationFormID;
            }
            set
            {
                m_MedicationFormID = value;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text.TrimEnd() == "")
            {
                MessageBox.Show("Введіть, будь-ласка, лікарську форму!", "Doctor N", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }
            if (MedicationFormID > 0)
            {
                VikkiSoft.Data.MedicationForm.UpdateMedicationForm(MedicationFormID, tbName.Text.TrimEnd());
            }
            else
            {
                VikkiSoft.Data.MedicationForm.InsertMedicationForm(tbName.Text.TrimEnd());
            }
        }

        private void EditMedicationFormForm_Load(object sender, EventArgs e)
        {
            if (MedicationFormID > 0)
            {
                this.Text = "Редагувати лікарську форму";
                DataRow dr = VikkiSoft.Data.MedicationForm.SelectOne(MedicationFormID);
                if (dr != null)
                {
                    tbName.Text = dr["Name"].ToString();
                }
            }
        }
    }
}
