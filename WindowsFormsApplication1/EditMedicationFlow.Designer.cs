namespace WindowsFormsApplication1
{
    partial class EditMedicationFlow
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
            this.tbNote = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ddlType = new System.Windows.Forms.ComboBox();
            this.lblMedicalTestType = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.ddlMedication = new System.Windows.Forms.ComboBox();
            this.lblMedication = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirhday = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNote
            // 
            this.tbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNote.Location = new System.Drawing.Point(108, 124);
            this.tbNote.Margin = new System.Windows.Forms.Padding(6);
            this.tbNote.MaxLength = 50;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(380, 24);
            this.tbNote.TabIndex = 41;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(324, 158);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 32);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(139, 158);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 32);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ddlType
            // 
            this.ddlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ddlType.FormattingEnabled = true;
            this.ddlType.Location = new System.Drawing.Point(108, 66);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(380, 26);
            this.ddlType.TabIndex = 38;
            // 
            // lblMedicalTestType
            // 
            this.lblMedicalTestType.AutoSize = true;
            this.lblMedicalTestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedicalTestType.Location = new System.Drawing.Point(64, 70);
            this.lblMedicalTestType.Name = "lblMedicalTestType";
            this.lblMedicalTestType.Size = new System.Drawing.Size(41, 18);
            this.lblMedicalTestType.TabIndex = 37;
            this.lblMedicalTestType.Text = "Тип:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNote.Location = new System.Drawing.Point(20, 126);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(85, 18);
            this.lblNote.TabIndex = 36;
            this.lblNote.Text = "Примітка:";
            // 
            // ddlMedication
            // 
            this.ddlMedication.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ddlMedication.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlMedication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ddlMedication.FormattingEnabled = true;
            this.ddlMedication.Location = new System.Drawing.Point(108, 36);
            this.ddlMedication.Name = "ddlMedication";
            this.ddlMedication.Size = new System.Drawing.Size(380, 26);
            this.ddlMedication.TabIndex = 43;
            // 
            // lblMedication
            // 
            this.lblMedication.AutoSize = true;
            this.lblMedication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedication.Location = new System.Drawing.Point(57, 40);
            this.lblMedication.Name = "lblMedication";
            this.lblMedication.Size = new System.Drawing.Size(47, 18);
            this.lblMedication.TabIndex = 42;
            this.lblMedication.Text = "Ліки:";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(108, 8);
            this.dtpDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(109, 24);
            this.dtpDate.TabIndex = 45;
            // 
            // lblBirhday
            // 
            this.lblBirhday.AutoSize = true;
            this.lblBirhday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirhday.Location = new System.Drawing.Point(53, 10);
            this.lblBirhday.Name = "lblBirhday";
            this.lblBirhday.Size = new System.Drawing.Size(52, 18);
            this.lblBirhday.TabIndex = 44;
            this.lblBirhday.Text = "Дата:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.Location = new System.Drawing.Point(20, 98);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(86, 18);
            this.lblCount.TabIndex = 46;
            this.lblCount.Text = "Кількість:";
            // 
            // nudCount
            // 
            this.nudCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudCount.Location = new System.Drawing.Point(108, 96);
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(92, 24);
            this.nudCount.TabIndex = 48;
            // 
            // EditMedicationFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 203);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblBirhday);
            this.Controls.Add(this.ddlMedication);
            this.Controls.Add(this.lblMedication);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ddlType);
            this.Controls.Add(this.lblMedicalTestType);
            this.Controls.Add(this.lblNote);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditMedicationFlow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати прихід/розхід";
            this.Load += new System.EventHandler(this.EditMedicationFlow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox ddlType;
        private System.Windows.Forms.Label lblMedicalTestType;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ComboBox ddlMedication;
        private System.Windows.Forms.Label lblMedication;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblBirhday;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.NumericUpDown nudCount;
    }
}