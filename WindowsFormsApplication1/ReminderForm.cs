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
    public partial class ReminderForm : Form
    {
        private int m_EditedIndex = -1;

        public ReminderForm()
        {
            InitializeComponent();
        }

        private void ReminderForm_Load(object sender, EventArgs e)
        {
            dgvReminder.AutoGenerateColumns = false;
            dgvReminder.Columns.Clear();

            DataGridViewLinkColumn lnkColEdit = new DataGridViewLinkColumn();
            lnkColEdit.Name = "Дата";
            lnkColEdit.DataPropertyName = "Date";
            lnkColEdit.LinkColor = Color.Blue;
            lnkColEdit.VisitedLinkColor = Color.Blue;
            lnkColEdit.Width = lnkColEdit.MinimumWidth = 90;
            lnkColEdit.DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvReminder.Columns.Add(lnkColEdit);

            string[] arrDataPropertyName = { "PatientName", "Notes" };
            string[] arrName = { "Пацієнт", "Нагадування" };
            int[] arrWidth = { 250, 650 };

            for (int i = 0; i < 2; i++)
            {
                DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                dgvc.Name = arrName[i];
                dgvc.DataPropertyName = arrDataPropertyName[i];
                dgvc.Width = arrWidth[i];
                dgvc.MinimumWidth = arrWidth[i];
                dgvc.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvReminder.Columns.Add(dgvc);
            }

            LoadData();

            DataGridViewButtonColumn btnColDelete = new DataGridViewButtonColumn();
            btnColDelete.Name = "";
            btnColDelete.Width = 120;
            btnColDelete.MinimumWidth = 120;
            btnColDelete.DataPropertyName = "DeleteColumn";
            dgvReminder.Columns.Add(btnColDelete);

            foreach (DataGridViewColumn c in dgvReminder.Columns)
            {
                c.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        private void LoadData()
        {
            DataTable dt = VikkiSoft.Data.Reminder.SelectReminderList();
            dgvReminder.DataSource = dt;
        }

        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            ShowEditReminderForm(0, 0);
        }

        private void ShowEditReminderForm(int reminderID, int patientID)
        {
            EditReminderForm frmEditReminder = new EditReminderForm(reminderID, patientID);
            if (frmEditReminder.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                if (reminderID > 0)
                {
                    dgvReminder.Rows[m_EditedIndex].Cells[0].Selected = true;
                }
            }
        }

        private void dgvReminder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow dr = (DataRow)((DataTable)this.dgvReminder.DataSource).Rows[e.RowIndex];
                int reminderID = int.Parse(dr["ReminderID"].ToString());
                int patientID = 0;
                if (!string.IsNullOrEmpty(dr["PatientID"].ToString()))
                {
                    patientID = int.Parse(dr["PatientID"].ToString());
                }
                switch (e.ColumnIndex)
                {
                    case 0:
                        m_EditedIndex = e.RowIndex;
                        ShowEditReminderForm(reminderID, patientID);
                        break;
                    case 3:
                        if (MessageBox.Show("Ви дійсно бажаєте видалити це нагадування?", "Doctor N", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            VikkiSoft.Data.Reminder.DeleteReminder(reminderID);
                            LoadData();
                        }
                        break;
                }
            }
        }
    }
}
