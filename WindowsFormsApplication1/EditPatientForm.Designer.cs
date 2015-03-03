namespace WindowsFormsApplication1
{
    partial class EditPatientForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.lblBirhday = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblNotes = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.lblVisits = new System.Windows.Forms.Label();
            this.dgvVisits = new System.Windows.Forms.DataGridView();
            this.btnAddVisit = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblWorkPosition = new System.Windows.Forms.Label();
            this.tbWorkPosition = new System.Windows.Forms.TextBox();
            this.lblEducation = new System.Windows.Forms.Label();
            this.tbEducation = new System.Windows.Forms.TextBox();
            this.tbFinancialNotes = new System.Windows.Forms.TextBox();
            this.lblFinancialNotes = new System.Windows.Forms.Label();
            this.btnAddReminder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(955, 200);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(770, 200);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstName.Location = new System.Drawing.Point(70, 33);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(42, 18);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "Ім\'я:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFirstName.Location = new System.Drawing.Point(114, 31);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.tbFirstName.MaxLength = 50;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(286, 24);
            this.tbFirstName.TabIndex = 9;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastName.Location = new System.Drawing.Point(26, 7);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 18);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Прізвище:";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLastName.Location = new System.Drawing.Point(114, 5);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(6);
            this.tbLastName.MaxLength = 50;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(286, 24);
            this.tbLastName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Побатькові:";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMiddleName.Location = new System.Drawing.Point(114, 57);
            this.tbMiddleName.Margin = new System.Windows.Forms.Padding(6);
            this.tbMiddleName.MaxLength = 50;
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(286, 24);
            this.tbMiddleName.TabIndex = 10;
            // 
            // lblBirhday
            // 
            this.lblBirhday.AutoSize = true;
            this.lblBirhday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirhday.Location = new System.Drawing.Point(9, 86);
            this.lblBirhday.Name = "lblBirhday";
            this.lblBirhday.Size = new System.Drawing.Size(155, 18);
            this.lblBirhday.TabIndex = 14;
            this.lblBirhday.Text = "Дата Народження:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(166, 83);
            this.dtpBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(234, 24);
            this.dtpBirthday.TabIndex = 11;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNotes.Location = new System.Drawing.Point(410, 5);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(158, 18);
            this.lblNotes.TabIndex = 16;
            this.lblNotes.Text = "Примітки Загальні:";
            // 
            // tbNotes
            // 
            this.tbNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNotes.Location = new System.Drawing.Point(407, 30);
            this.tbNotes.Margin = new System.Windows.Forms.Padding(6);
            this.tbNotes.MaxLength = 0;
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbNotes.Size = new System.Drawing.Size(359, 156);
            this.tbNotes.TabIndex = 15;
            // 
            // lblVisits
            // 
            this.lblVisits.AutoSize = true;
            this.lblVisits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVisits.Location = new System.Drawing.Point(11, 207);
            this.lblVisits.Name = "lblVisits";
            this.lblVisits.Size = new System.Drawing.Size(63, 18);
            this.lblVisits.TabIndex = 18;
            this.lblVisits.Text = "Візити:";
            // 
            // dgvVisits
            // 
            this.dgvVisits.AllowUserToAddRows = false;
            this.dgvVisits.AllowUserToDeleteRows = false;
            this.dgvVisits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVisits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisits.Location = new System.Drawing.Point(0, 237);
            this.dgvVisits.Margin = new System.Windows.Forms.Padding(6);
            this.dgvVisits.MultiSelect = false;
            this.dgvVisits.Name = "dgvVisits";
            this.dgvVisits.ReadOnly = true;
            this.dgvVisits.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvVisits.RowTemplate.Height = 28;
            this.dgvVisits.Size = new System.Drawing.Size(1132, 374);
            this.dgvVisits.TabIndex = 19;
            this.dgvVisits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisits_CellClick);
            // 
            // btnAddVisit
            // 
            this.btnAddVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddVisit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddVisit.Location = new System.Drawing.Point(78, 199);
            this.btnAddVisit.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddVisit.Name = "btnAddVisit";
            this.btnAddVisit.Size = new System.Drawing.Size(205, 32);
            this.btnAddVisit.TabIndex = 20;
            this.btnAddVisit.Text = "Додати візит";
            this.btnAddVisit.UseVisualStyleBackColor = true;
            this.btnAddVisit.Click += new System.EventHandler(this.btnAddVisit_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Location = new System.Drawing.Point(28, 164);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(84, 18);
            this.lblPhone.TabIndex = 26;
            this.lblPhone.Text = "Телефон:";
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhone.Location = new System.Drawing.Point(114, 162);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(6);
            this.tbPhone.MaxLength = 50;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(286, 24);
            this.tbPhone.TabIndex = 14;
            // 
            // lblWorkPosition
            // 
            this.lblWorkPosition.AutoSize = true;
            this.lblWorkPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkPosition.Location = new System.Drawing.Point(40, 138);
            this.lblWorkPosition.Name = "lblWorkPosition";
            this.lblWorkPosition.Size = new System.Drawing.Size(72, 18);
            this.lblWorkPosition.TabIndex = 24;
            this.lblWorkPosition.Text = "Посада:";
            // 
            // tbWorkPosition
            // 
            this.tbWorkPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWorkPosition.Location = new System.Drawing.Point(114, 136);
            this.tbWorkPosition.Margin = new System.Windows.Forms.Padding(6);
            this.tbWorkPosition.MaxLength = 50;
            this.tbWorkPosition.Name = "tbWorkPosition";
            this.tbWorkPosition.Size = new System.Drawing.Size(286, 24);
            this.tbWorkPosition.TabIndex = 13;
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEducation.Location = new System.Drawing.Point(47, 112);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(65, 18);
            this.lblEducation.TabIndex = 22;
            this.lblEducation.Text = "Освіта:";
            // 
            // tbEducation
            // 
            this.tbEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEducation.Location = new System.Drawing.Point(114, 110);
            this.tbEducation.Margin = new System.Windows.Forms.Padding(6);
            this.tbEducation.MaxLength = 50;
            this.tbEducation.Name = "tbEducation";
            this.tbEducation.Size = new System.Drawing.Size(286, 24);
            this.tbEducation.TabIndex = 12;
            // 
            // tbFinancialNotes
            // 
            this.tbFinancialNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFinancialNotes.Location = new System.Drawing.Point(773, 30);
            this.tbFinancialNotes.Margin = new System.Windows.Forms.Padding(6);
            this.tbFinancialNotes.MaxLength = 0;
            this.tbFinancialNotes.Multiline = true;
            this.tbFinancialNotes.Name = "tbFinancialNotes";
            this.tbFinancialNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbFinancialNotes.Size = new System.Drawing.Size(359, 156);
            this.tbFinancialNotes.TabIndex = 16;
            // 
            // lblFinancialNotes
            // 
            this.lblFinancialNotes.AutoSize = true;
            this.lblFinancialNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFinancialNotes.Location = new System.Drawing.Point(776, 5);
            this.lblFinancialNotes.Name = "lblFinancialNotes";
            this.lblFinancialNotes.Size = new System.Drawing.Size(167, 18);
            this.lblFinancialNotes.TabIndex = 28;
            this.lblFinancialNotes.Text = "Примітки Фінансові:";
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddReminder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddReminder.Location = new System.Drawing.Point(301, 199);
            this.btnAddReminder.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(267, 32);
            this.btnAddReminder.TabIndex = 38;
            this.btnAddReminder.Text = "Додати нагадування";
            this.btnAddReminder.UseVisualStyleBackColor = true;
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // EditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 613);
            this.Controls.Add(this.btnAddReminder);
            this.Controls.Add(this.lblFinancialNotes);
            this.Controls.Add(this.tbFinancialNotes);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lblWorkPosition);
            this.Controls.Add(this.tbWorkPosition);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.tbEducation);
            this.Controls.Add(this.btnAddVisit);
            this.Controls.Add(this.dgvVisits);
            this.Controls.Add(this.lblVisits);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lblBirhday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати Пацієнта";
            this.Load += new System.EventHandler(this.EditPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.Label lblBirhday;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label lblVisits;
        private System.Windows.Forms.DataGridView dgvVisits;
        private System.Windows.Forms.Button btnAddVisit;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblWorkPosition;
        private System.Windows.Forms.TextBox tbWorkPosition;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.TextBox tbEducation;
        private System.Windows.Forms.TextBox tbFinancialNotes;
        private System.Windows.Forms.Label lblFinancialNotes;
        private System.Windows.Forms.Button btnAddReminder;
    }
}