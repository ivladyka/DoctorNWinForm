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
    public partial class EditMedicationForm : Form
    {
        private int m_MedicationID = 0;

        public EditMedicationForm()
        {
            InitializeComponent();
        }

        public EditMedicationForm(int medicationID)
        {
            m_MedicationID = medicationID;
            InitializeComponent();
        }

        private int MedicationID
        {
            get
            {
                return m_MedicationID;
            }
            set
            {
                m_MedicationID = value;
            }
        }

        private void EditMedicationForm_Load(object sender, EventArgs e)
        {
            ddlMedicationForm.ValueMember = "MedicationFormID";
            ddlMedicationForm.DisplayMember = "Name";
            ddlMedicationForm.DataSource = VikkiSoft.Data.MedicationForm.SelectList();
            if (MedicationID > 0)
            {
                this.Text = "Редагувати ліки";
                DataRow dr = VikkiSoft.Data.Medication.SelectOne(MedicationID);
                if (dr != null)
                {
                    tbName.Text = dr["Name"].ToString();
                    ddlMedicationForm.SelectedValue = dr["MedicationFormID"].ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text.TrimEnd() == "")
            {
                MessageBox.Show("Введіть, будь-ласка, назву ліків!", "Doctor N", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }
            if (MedicationID > 0)
            {
                VikkiSoft.Data.Medication.UpdateMedication(MedicationID, tbName.Text.TrimEnd(), int.Parse(ddlMedicationForm.SelectedValue.ToString()));
            }
            else
            {
                VikkiSoft.Data.Medication.InsertMedication(tbName.Text.TrimEnd(), int.Parse(ddlMedicationForm.SelectedValue.ToString()));
            }
        }
    }
}
