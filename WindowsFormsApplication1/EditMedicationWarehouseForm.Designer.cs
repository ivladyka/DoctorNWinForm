namespace WindowsFormsApplication1
{
    partial class EditMedicationWarehouseForm
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
            this.lblMedication = new System.Windows.Forms.Label();
            this.lblMedicationValue = new System.Windows.Forms.Label();
            this.lblCountValue = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnAddMedicationFlow = new System.Windows.Forms.Button();
            this.dgvMedicationFlow = new System.Windows.Forms.DataGridView();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.ddlPage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicationFlow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedication
            // 
            this.lblMedication.AutoSize = true;
            this.lblMedication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedication.Location = new System.Drawing.Point(46, 15);
            this.lblMedication.Name = "lblMedication";
            this.lblMedication.Size = new System.Drawing.Size(47, 18);
            this.lblMedication.TabIndex = 46;
            this.lblMedication.Text = "Ліки:";
            // 
            // lblMedicationValue
            // 
            this.lblMedicationValue.AutoSize = true;
            this.lblMedicationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedicationValue.Location = new System.Drawing.Point(94, 15);
            this.lblMedicationValue.Name = "lblMedicationValue";
            this.lblMedicationValue.Size = new System.Drawing.Size(0, 18);
            this.lblMedicationValue.TabIndex = 47;
            // 
            // lblCountValue
            // 
            this.lblCountValue.AutoSize = true;
            this.lblCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountValue.Location = new System.Drawing.Point(94, 34);
            this.lblCountValue.Name = "lblCountValue";
            this.lblCountValue.Size = new System.Drawing.Size(0, 18);
            this.lblCountValue.TabIndex = 49;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.Location = new System.Drawing.Point(6, 34);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(86, 18);
            this.lblCount.TabIndex = 48;
            this.lblCount.Text = "Кількість:";
            // 
            // btnAddMedicationFlow
            // 
            this.btnAddMedicationFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddMedicationFlow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddMedicationFlow.Location = new System.Drawing.Point(9, 58);
            this.btnAddMedicationFlow.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddMedicationFlow.Name = "btnAddMedicationFlow";
            this.btnAddMedicationFlow.Size = new System.Drawing.Size(267, 32);
            this.btnAddMedicationFlow.TabIndex = 50;
            this.btnAddMedicationFlow.Text = "Додати прихід/розхід";
            this.btnAddMedicationFlow.UseVisualStyleBackColor = true;
            this.btnAddMedicationFlow.Click += new System.EventHandler(this.btnAddMedicationFlow_Click);
            // 
            // dgvMedicationFlow
            // 
            this.dgvMedicationFlow.AllowUserToAddRows = false;
            this.dgvMedicationFlow.AllowUserToDeleteRows = false;
            this.dgvMedicationFlow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMedicationFlow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicationFlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicationFlow.Location = new System.Drawing.Point(9, 95);
            this.dgvMedicationFlow.Margin = new System.Windows.Forms.Padding(6);
            this.dgvMedicationFlow.MultiSelect = false;
            this.dgvMedicationFlow.Name = "dgvMedicationFlow";
            this.dgvMedicationFlow.ReadOnly = true;
            this.dgvMedicationFlow.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvMedicationFlow.RowTemplate.Height = 28;
            this.dgvMedicationFlow.Size = new System.Drawing.Size(667, 548);
            this.dgvMedicationFlow.TabIndex = 51;
            this.dgvMedicationFlow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicationFlow_CellClick);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPageTitle.Location = new System.Drawing.Point(526, 67);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(83, 18);
            this.lblPageTitle.TabIndex = 53;
            this.lblPageTitle.Text = "Сторінка:";
            // 
            // ddlPage
            // 
            this.ddlPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ddlPage.FormattingEnabled = true;
            this.ddlPage.Location = new System.Drawing.Point(614, 64);
            this.ddlPage.Name = "ddlPage";
            this.ddlPage.Size = new System.Drawing.Size(62, 26);
            this.ddlPage.TabIndex = 52;
            this.ddlPage.SelectedIndexChanged += new System.EventHandler(this.ddlPage_SelectedIndexChanged);
            // 
            // EditMedicationWarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 646);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.ddlPage);
            this.Controls.Add(this.dgvMedicationFlow);
            this.Controls.Add(this.btnAddMedicationFlow);
            this.Controls.Add(this.lblCountValue);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblMedicationValue);
            this.Controls.Add(this.lblMedication);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditMedicationWarehouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прихід/Розхід ліків";
            this.Load += new System.EventHandler(this.EditMedicationWarehouseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicationFlow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedication;
        private System.Windows.Forms.Label lblMedicationValue;
        private System.Windows.Forms.Label lblCountValue;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnAddMedicationFlow;
        private System.Windows.Forms.DataGridView dgvMedicationFlow;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.ComboBox ddlPage;
    }
}