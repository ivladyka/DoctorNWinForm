namespace WindowsFormsApplication1
{
    partial class MedicationWindowsForm
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
            this.dgvMedication = new System.Windows.Forms.DataGridView();
            this.btnAddMedication = new System.Windows.Forms.Button();
            this.ddlPage = new System.Windows.Forms.ComboBox();
            this.lblPageTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedication)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedication
            // 
            this.dgvMedication.AllowUserToAddRows = false;
            this.dgvMedication.AllowUserToDeleteRows = false;
            this.dgvMedication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMedication.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedication.Location = new System.Drawing.Point(10, 45);
            this.dgvMedication.Margin = new System.Windows.Forms.Padding(6);
            this.dgvMedication.MultiSelect = false;
            this.dgvMedication.Name = "dgvMedication";
            this.dgvMedication.ReadOnly = true;
            this.dgvMedication.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvMedication.RowTemplate.Height = 28;
            this.dgvMedication.Size = new System.Drawing.Size(995, 764);
            this.dgvMedication.TabIndex = 5;
            this.dgvMedication.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedication_CellClick);
            // 
            // btnAddMedication
            // 
            this.btnAddMedication.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddMedication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddMedication.Location = new System.Drawing.Point(10, 9);
            this.btnAddMedication.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddMedication.Name = "btnAddMedication";
            this.btnAddMedication.Size = new System.Drawing.Size(267, 32);
            this.btnAddMedication.TabIndex = 4;
            this.btnAddMedication.Text = "Додати ліки";
            this.btnAddMedication.UseVisualStyleBackColor = true;
            this.btnAddMedication.Click += new System.EventHandler(this.btnAddMedication_Click);
            // 
            // ddlPage
            // 
            this.ddlPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ddlPage.FormattingEnabled = true;
            this.ddlPage.Location = new System.Drawing.Point(943, 15);
            this.ddlPage.Name = "ddlPage";
            this.ddlPage.Size = new System.Drawing.Size(62, 26);
            this.ddlPage.TabIndex = 33;
            this.ddlPage.SelectedIndexChanged += new System.EventHandler(this.ddlPage_SelectedIndexChanged);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPageTitle.Location = new System.Drawing.Point(855, 18);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(83, 18);
            this.lblPageTitle.TabIndex = 34;
            this.lblPageTitle.Text = "Сторінка:";
            // 
            // MedicationWindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 873);
            this.ControlBox = false;
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.ddlPage);
            this.Controls.Add(this.dgvMedication);
            this.Controls.Add(this.btnAddMedication);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MedicationWindowsForm";
            this.Text = "Ліки";
            this.Load += new System.EventHandler(this.MedicationWindowsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedication;
        private System.Windows.Forms.Button btnAddMedication;
        private System.Windows.Forms.ComboBox ddlPage;
        private System.Windows.Forms.Label lblPageTitle;
    }
}