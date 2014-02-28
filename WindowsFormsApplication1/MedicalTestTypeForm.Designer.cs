namespace WindowsFormsApplication1
{
    partial class MedicalTestTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalTestTypeForm));
            this.dgvMedicalTestType = new System.Windows.Forms.DataGridView();
            this.btnAddMedicalTestType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalTestType)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicalTestType
            // 
            this.dgvMedicalTestType.AllowUserToAddRows = false;
            this.dgvMedicalTestType.AllowUserToDeleteRows = false;
            this.dgvMedicalTestType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMedicalTestType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicalTestType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvMedicalTestType, "dgvMedicalTestType");
            this.dgvMedicalTestType.MultiSelect = false;
            this.dgvMedicalTestType.Name = "dgvMedicalTestType";
            this.dgvMedicalTestType.ReadOnly = true;
            this.dgvMedicalTestType.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvMedicalTestType.RowTemplate.Height = 28;
            this.dgvMedicalTestType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicalTestType_CellClick);
            // 
            // btnAddMedicalTestType
            // 
            resources.ApplyResources(this.btnAddMedicalTestType, "btnAddMedicalTestType");
            this.btnAddMedicalTestType.Name = "btnAddMedicalTestType";
            this.btnAddMedicalTestType.UseVisualStyleBackColor = true;
            this.btnAddMedicalTestType.Click += new System.EventHandler(this.btnAddMedicalTestType_Click);
            // 
            // MedicalTestTypeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.btnAddMedicalTestType);
            this.Controls.Add(this.dgvMedicalTestType);
            this.Name = "MedicalTestTypeForm";
            this.Load += new System.EventHandler(this.MedicalTestTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalTestType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicalTestType;
        private System.Windows.Forms.Button btnAddMedicalTestType;
    }
}