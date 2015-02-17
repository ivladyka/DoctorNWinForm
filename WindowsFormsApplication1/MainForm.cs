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

        private void MedicationFormMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            MedicationFormForm frmMedicationForm = new MedicationFormForm();
            frmMedicationForm.MdiParent = this;
            frmMedicationForm.WindowState = FormWindowState.Maximized;
            frmMedicationForm.Show();
        }

        private void MedicationMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            MedicationWindowsForm frmMedicationWindowsForm = new MedicationWindowsForm();
            frmMedicationWindowsForm.MdiParent = this;
            frmMedicationWindowsForm.WindowState = FormWindowState.Maximized;
            frmMedicationWindowsForm.Show();
        }

        private void WarehouseMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
            WarehouseForm frmWarehouseForm = new WarehouseForm();
            frmWarehouseForm.MdiParent = this;
            frmWarehouseForm.WindowState = FormWindowState.Maximized;
            frmWarehouseForm.Show();
        }
    }
}
