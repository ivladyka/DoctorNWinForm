namespace WindowsFormsApplication1
{
    partial class EditMedicalTestForm
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirhday = new System.Windows.Forms.Label();
            this.lblMedicalTestType = new System.Windows.Forms.Label();
            this.ddlMedicalTestType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDoument = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(138, 15);
            this.dtpDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(109, 24);
            this.dtpDate.TabIndex = 19;
            // 
            // lblBirhday
            // 
            this.lblBirhday.AutoSize = true;
            this.lblBirhday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirhday.Location = new System.Drawing.Point(83, 17);
            this.lblBirhday.Name = "lblBirhday";
            this.lblBirhday.Size = new System.Drawing.Size(52, 18);
            this.lblBirhday.TabIndex = 18;
            this.lblBirhday.Text = "Дата:";
            // 
            // lblMedicalTestType
            // 
            this.lblMedicalTestType.AutoSize = true;
            this.lblMedicalTestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedicalTestType.Location = new System.Drawing.Point(6, 47);
            this.lblMedicalTestType.Name = "lblMedicalTestType";
            this.lblMedicalTestType.Size = new System.Drawing.Size(129, 18);
            this.lblMedicalTestType.TabIndex = 20;
            this.lblMedicalTestType.Text = "Тип документу:";
            // 
            // ddlMedicalTestType
            // 
            this.ddlMedicalTestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMedicalTestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ddlMedicalTestType.FormattingEnabled = true;
            this.ddlMedicalTestType.Location = new System.Drawing.Point(138, 43);
            this.ddlMedicalTestType.Name = "ddlMedicalTestType";
            this.ddlMedicalTestType.Size = new System.Drawing.Size(380, 26);
            this.ddlMedicalTestType.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(354, 104);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 32);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(169, 104);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 32);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDoument
            // 
            this.lblDoument.AutoSize = true;
            this.lblDoument.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDoument.Location = new System.Drawing.Point(44, 77);
            this.lblDoument.Name = "lblDoument";
            this.lblDoument.Size = new System.Drawing.Size(91, 18);
            this.lblDoument.TabIndex = 26;
            this.lblDoument.Text = "Документ:";
            // 
            // tbFileName
            // 
            this.tbFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFileName.Location = new System.Drawing.Point(138, 75);
            this.tbFileName.Margin = new System.Windows.Forms.Padding(6);
            this.tbFileName.MaxLength = 50;
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(273, 24);
            this.tbFileName.TabIndex = 27;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelect.Location = new System.Drawing.Point(413, 73);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(105, 28);
            this.btnSelect.TabIndex = 28;
            this.btnSelect.Text = "Вибрати";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditMedicalTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 152);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.lblDoument);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ddlMedicalTestType);
            this.Controls.Add(this.lblMedicalTestType);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblBirhday);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditMedicalTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати Документ";
            this.Load += new System.EventHandler(this.EditMedicalTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblBirhday;
        private System.Windows.Forms.Label lblMedicalTestType;
        private System.Windows.Forms.ComboBox ddlMedicalTestType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDoument;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}