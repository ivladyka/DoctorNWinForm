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
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class MedicalTestTypeForm : Form
    {
        private string path = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\";
        private int m_EditedIndex = -1;

        public MedicalTestTypeForm()
        {
            InitializeComponent();
        }

        private void MedicalTestTypeForm_Load(object sender, EventArgs e)
        {
            dgvMedicalTestType.AutoGenerateColumns = false;

            DataGridViewLinkColumn lnkColEdit = new DataGridViewLinkColumn();
            lnkColEdit.Name = "Тип документу";
            lnkColEdit.ToolTipText = "Name";
            lnkColEdit.DataPropertyName = "Name";
            lnkColEdit.LinkColor = Color.Blue;
            lnkColEdit.VisitedLinkColor = Color.Blue;
            lnkColEdit.Width = 600;
            lnkColEdit.MinimumWidth = 600;
            dgvMedicalTestType.Columns.Add(lnkColEdit);
            LoadData();

            DataGridViewButtonColumn btnColDelete = new DataGridViewButtonColumn();
            btnColDelete.Name = "";
            btnColDelete.Width = 120;
            btnColDelete.MinimumWidth = 120;
            btnColDelete.DataPropertyName = "DeleteColumn";
            dgvMedicalTestType.Columns.Add(btnColDelete);
            foreach (DataGridViewColumn c in dgvMedicalTestType.Columns)
            {
                c.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        private void LoadData()
        {
            DataTable dt = VikkiSoft.Data.MedicalTestType.SelectList();
            dgvMedicalTestType.DataSource = dt;
        }

        private void btnAddMedicalTestType_Click(object sender, EventArgs e)
        {
            ShowAddMedicalTestTypeForm(0);
        }

        private void dgvMedicalTestType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow dr = (DataRow)((DataTable)this.dgvMedicalTestType.DataSource).Rows[e.RowIndex];
                int medicalTestTypeID = int.Parse(dr["MedicalTestTypeID"].ToString());
                switch (e.ColumnIndex)
                {
                    case 0:
                        m_EditedIndex = e.RowIndex;
                        ShowAddMedicalTestTypeForm(medicalTestTypeID);
                        break;
                    case 1:
                        if (MessageBox.Show("Ви дійсно бажаєте видалити цей тип документу?", "Doctor N", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            try
                            {
                                VikkiSoft.Data.MedicalTestType.DeleteMedicalTestType(medicalTestTypeID);
                                LoadData();
                            }
                            catch
                            {
                                MessageBox.Show("Ви не можете видалити цей тип аналізу, тому що він використовується.", "Doctor N", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                }
            }
        }

        private void ShowAddMedicalTestTypeForm(int medicalTestTypeID)
        {
            AddMedicalTestTypeForm frmAddMedicalTestType = new AddMedicalTestTypeForm(medicalTestTypeID);
            if(frmAddMedicalTestType.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                if (medicalTestTypeID > 0)
                {
                    dgvMedicalTestType.Rows[m_EditedIndex].Cells[0].Selected = true;
                }
            }
        }
    }
}
