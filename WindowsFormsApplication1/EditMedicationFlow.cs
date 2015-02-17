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
    public partial class EditMedicationFlow : Form
    {
        private int m_MedicationFlowID = 0;
        private int m_MedicationID = 0;

        public EditMedicationFlow()
        {
            InitializeComponent();
        }

        public EditMedicationFlow(int medicationFlowID)
        {
            m_MedicationFlowID = medicationFlowID;
            InitializeComponent();
        }

        public EditMedicationFlow(int medicationFlowID, int medicationID)
        {
            m_MedicationFlowID = medicationFlowID;
            MedicationID = medicationID;
            InitializeComponent();
        }

        private int MedicationFlowID
        {
            get
            {
                return m_MedicationFlowID;
            }
            set
            {
                m_MedicationFlowID = value;
            }
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

        private void EditMedicationFlow_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            nudCount.Text = "1";

            ddlMedication.ValueMember = "MedicationID";
            ddlMedication.DisplayMember = "MedicationFullName";
            ddlMedication.DataSource = VikkiSoft.Data.Medication.SelectList("");

            ddlType.ValueMember = "MedicationFlowTypeID";
            ddlType.DisplayMember = "Name";
            ddlType.DataSource = VikkiSoft.Data.MedicationFlowType.SelectList();

            if (MedicationID > 0)
            {
                ddlMedication.SelectedValue = MedicationID.ToString();
            }

            if (MedicationFlowID > 0)
            {
                this.Text = "Редагувати прихід/розхід";
                DataRow dr = VikkiSoft.Data.MedicationFlow.SelectOne(MedicationFlowID);
                if (dr != null)
                {
                    dtpDate.Value = (DateTime)dr["Date"];
                    ddlMedication.SelectedValue = dr["MedicationID"].ToString();
                    ddlType.SelectedValue = dr["MedicationFlowTypeID"].ToString();
                    nudCount.Text = dr["Count"].ToString();
                    tbNote.Text = dr["Note"].ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nudCount.Text.TrimEnd() == "")
            {
                MessageBox.Show("Введіть, будь-ласка, кількість!", "Doctor N", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }
            if (MedicationFlowID > 0)
            {
                VikkiSoft.Data.MedicationFlow.UpdateMedicationFlow(MedicationFlowID, int.Parse(ddlType.SelectedValue.ToString()), int.Parse(ddlMedication.SelectedValue.ToString()),
                    int.Parse(nudCount.Text), dtpDate.Value, tbNote.Text.TrimEnd());
            }
            else
            {
                VikkiSoft.Data.MedicationFlow.InsertMedicationFlow(int.Parse(ddlType.SelectedValue.ToString()), int.Parse(ddlMedication.SelectedValue.ToString()),
                    int.Parse(nudCount.Text), dtpDate.Value, tbNote.Text.TrimEnd());
            }
        }
    }
}
