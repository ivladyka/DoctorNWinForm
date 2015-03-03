using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EditReminderForm : Form
    {
        private int m_ReminderID = 0;
        private int m_PatientID = 0;

        public EditReminderForm()
        {
            InitializeComponent();
        }

        public EditReminderForm(int reminderID, int patientID)
        {
            ReminderID = reminderID;
            PatientID = patientID;
            InitializeComponent();
        }

        private int ReminderID
        {
            get
            {
                return m_ReminderID;
            }
            set
            {
                m_ReminderID = value;
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

        private void EditReminderForm_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;

            lblPatientName.Text = "";
            if (ReminderID > 0)
            {
                this.Text = "Редагувати нагадування";
                DataRow dr = VikkiSoft.Data.Reminder.SelectOne(ReminderID);
                if (dr != null)
                {
                    dtpDate.Value = (DateTime)dr["Date"];
                    lblPatientName.Text = dr["PatientName"].ToString();
                    tbNote.Text = dr["Notes"].ToString();
                }
            }
            else
            {
                if(PatientID > 0)
                {
                    DataRow dr = VikkiSoft.Data.Patient.SelectOne(PatientID);
                    if (dr != null)
                    {
                        lblPatientName.Text = dr["LastName"].ToString() + " " + dr["FirstName"].ToString();
                    }
                }
            }
            if (string.IsNullOrEmpty(lblPatientName.Text))
            {
                lblPatient.Visible = lblPatientName.Visible = false;
                tbNote.Location = new System.Drawing.Point(118, 39);
                lblNote.Location = new System.Drawing.Point(3, 73);
                btnSave.Location = new System.Drawing.Point(163, 137);
                btnCancel.Location = new System.Drawing.Point(348, 137);
                this.Height = 218;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbNote.Text.TrimEnd() == "")
            {
                MessageBox.Show("Введіть, будь-ласка, нагадування!", "Doctor N", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }
            if (ReminderID > 0)
            {
                VikkiSoft.Data.Reminder.UpdateReminder(ReminderID, PatientID, dtpDate.Value, tbNote.Text.TrimEnd());
            }
            else
            {
                VikkiSoft.Data.Reminder.InsertReminder(PatientID, dtpDate.Value, tbNote.Text.TrimEnd());
            }
        }
    }
}
