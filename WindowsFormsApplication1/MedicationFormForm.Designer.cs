namespace WindowsFormsApplication1
{
    partial class MedicationFormForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicationFormForm));
            this.btnAddMedicationForm = new System.Windows.Forms.Button();
            this.dgvMedicationForm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicationForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMedicationForm
            // 
            resources.ApplyResources(this.btnAddMedicationForm, "btnAddMedicationForm");
            this.btnAddMedicationForm.Name = "btnAddMedicationForm";
            this.btnAddMedicationForm.UseVisualStyleBackColor = true;
            this.btnAddMedicationForm.Click += new System.EventHandler(this.btnAddMedicationForm_Click);
            // 
            // dgvMedicationForm
            // 
            this.dgvMedicationForm.AllowUserToAddRows = false;
            this.dgvMedicationForm.AllowUserToDeleteRows = false;
            this.dgvMedicationForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMedicationForm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicationForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvMedicationForm, "dgvMedicationForm");
            this.dgvMedicationForm.MultiSelect = false;
            this.dgvMedicationForm.Name = "dgvMedicationForm";
            this.dgvMedicationForm.ReadOnly = true;
            this.dgvMedicationForm.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvMedicationForm.RowTemplate.Height = 28;
            this.dgvMedicationForm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicationForm_CellClick);
            // 
            // MedicationFormForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.dgvMedicationForm);
            this.Controls.Add(this.btnAddMedicationForm);
            this.Name = "MedicationFormForm";
            this.Load += new System.EventHandler(this.MedicationFormForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicationForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMedicationForm;
        private System.Windows.Forms.DataGridView dgvMedicationForm;
    }
}