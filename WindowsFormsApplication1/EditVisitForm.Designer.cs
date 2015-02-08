namespace WindowsFormsApplication1
{
    partial class EditVisitForm
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
            this.tbAnamnesis = new System.Windows.Forms.TextBox();
            this.lblAnamnesis = new System.Windows.Forms.Label();
            this.tbPrescription = new System.Windows.Forms.TextBox();
            this.lblPrescription = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMedicalTest = new System.Windows.Forms.Button();
            this.lblMedicalTest = new System.Windows.Forms.Label();
            this.dgvMedicalTests = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalTests)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(71, 6);
            this.dtpDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(113, 24);
            this.dtpDate.TabIndex = 17;
            // 
            // lblBirhday
            // 
            this.lblBirhday.AutoSize = true;
            this.lblBirhday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirhday.Location = new System.Drawing.Point(12, 8);
            this.lblBirhday.Name = "lblBirhday";
            this.lblBirhday.Size = new System.Drawing.Size(52, 18);
            this.lblBirhday.TabIndex = 16;
            this.lblBirhday.Text = "Дата:";
            // 
            // tbAnamnesis
            // 
            this.tbAnamnesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAnamnesis.Location = new System.Drawing.Point(14, 265);
            this.tbAnamnesis.Margin = new System.Windows.Forms.Padding(6);
            this.tbAnamnesis.MaxLength = 0;
            this.tbAnamnesis.Multiline = true;
            this.tbAnamnesis.Name = "tbAnamnesis";
            this.tbAnamnesis.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAnamnesis.Size = new System.Drawing.Size(498, 177);
            this.tbAnamnesis.TabIndex = 19;
            // 
            // lblAnamnesis
            // 
            this.lblAnamnesis.AutoSize = true;
            this.lblAnamnesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnamnesis.Location = new System.Drawing.Point(12, 238);
            this.lblAnamnesis.Name = "lblAnamnesis";
            this.lblAnamnesis.Size = new System.Drawing.Size(80, 18);
            this.lblAnamnesis.TabIndex = 18;
            this.lblAnamnesis.Text = "Анамнез:";
            // 
            // tbPrescription
            // 
            this.tbPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPrescription.Location = new System.Drawing.Point(15, 57);
            this.tbPrescription.Margin = new System.Windows.Forms.Padding(6);
            this.tbPrescription.MaxLength = 0;
            this.tbPrescription.Multiline = true;
            this.tbPrescription.Name = "tbPrescription";
            this.tbPrescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPrescription.Size = new System.Drawing.Size(498, 175);
            this.tbPrescription.TabIndex = 21;
            // 
            // lblPrescription
            // 
            this.lblPrescription.AutoSize = true;
            this.lblPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrescription.Location = new System.Drawing.Point(13, 33);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new System.Drawing.Size(115, 18);
            this.lblPrescription.TabIndex = 20;
            this.lblPrescription.Text = "Призначення:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(545, 452);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 32);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(360, 452);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 32);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMedicalTest
            // 
            this.btnMedicalTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnMedicalTest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMedicalTest.Location = new System.Drawing.Point(864, 9);
            this.btnMedicalTest.Margin = new System.Windows.Forms.Padding(6);
            this.btnMedicalTest.Name = "btnMedicalTest";
            this.btnMedicalTest.Size = new System.Drawing.Size(205, 32);
            this.btnMedicalTest.TabIndex = 25;
            this.btnMedicalTest.Text = "Додати документ";
            this.btnMedicalTest.UseVisualStyleBackColor = true;
            this.btnMedicalTest.Click += new System.EventHandler(this.btnMedicalTest_Click);
            // 
            // lblMedicalTest
            // 
            this.lblMedicalTest.AutoSize = true;
            this.lblMedicalTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMedicalTest.Location = new System.Drawing.Point(527, 34);
            this.lblMedicalTest.Name = "lblMedicalTest";
            this.lblMedicalTest.Size = new System.Drawing.Size(100, 18);
            this.lblMedicalTest.TabIndex = 24;
            this.lblMedicalTest.Text = "Документи:";
            // 
            // dgvMedicalTests
            // 
            this.dgvMedicalTests.AllowUserToAddRows = false;
            this.dgvMedicalTests.AllowUserToDeleteRows = false;
            this.dgvMedicalTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMedicalTests.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicalTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicalTests.Location = new System.Drawing.Point(523, 56);
            this.dgvMedicalTests.Margin = new System.Windows.Forms.Padding(6);
            this.dgvMedicalTests.MultiSelect = false;
            this.dgvMedicalTests.Name = "dgvMedicalTests";
            this.dgvMedicalTests.ReadOnly = true;
            this.dgvMedicalTests.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvMedicalTests.RowTemplate.Height = 28;
            this.dgvMedicalTests.Size = new System.Drawing.Size(558, 389);
            this.dgvMedicalTests.TabIndex = 26;
            this.dgvMedicalTests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicalTests_CellClick);
            this.dgvMedicalTests.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dgvMedicalTests_CellToolTipTextNeeded);
            // 
            // EditVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 490);
            this.Controls.Add(this.dgvMedicalTests);
            this.Controls.Add(this.btnMedicalTest);
            this.Controls.Add(this.lblMedicalTest);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPrescription);
            this.Controls.Add(this.lblPrescription);
            this.Controls.Add(this.tbAnamnesis);
            this.Controls.Add(this.lblAnamnesis);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblBirhday);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditVisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати Візит";
            this.Load += new System.EventHandler(this.EditVisitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalTests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblBirhday;
        private System.Windows.Forms.TextBox tbAnamnesis;
        private System.Windows.Forms.Label lblAnamnesis;
        private System.Windows.Forms.TextBox tbPrescription;
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMedicalTest;
        private System.Windows.Forms.Label lblMedicalTest;
        private System.Windows.Forms.DataGridView dgvMedicalTests;
    }
}