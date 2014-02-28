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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MedicalTestTypeManuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            MedicalTestTypeForm frmMedicalTestType = new MedicalTestTypeForm();
            frmMedicalTestType.MdiParent = this;
            frmMedicalTestType.WindowState = FormWindowState.Maximized;
            frmMedicalTestType.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenPatientSearchForm();
        }

        private void OpenPatientSearchForm()
        {
            SearchPatientForm frmSearchPatient = new SearchPatientForm();
            frmSearchPatient.MdiParent = this;
            frmSearchPatient.WindowState = FormWindowState.Maximized;
            frmSearchPatient.Show();
        }

        private void PatientsMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            OpenPatientSearchForm();
        }
    }
}
