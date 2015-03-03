namespace WindowsFormsApplication1
{
    partial class ReminderForm
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
            this.dgvReminder = new System.Windows.Forms.DataGridView();
            this.btnAddReminder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReminder
            // 
            this.dgvReminder.AllowUserToAddRows = false;
            this.dgvReminder.AllowUserToDeleteRows = false;
            this.dgvReminder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReminder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReminder.Location = new System.Drawing.Point(10, 45);
            this.dgvReminder.Margin = new System.Windows.Forms.Padding(6);
            this.dgvReminder.MultiSelect = false;
            this.dgvReminder.Name = "dgvReminder";
            this.dgvReminder.ReadOnly = true;
            this.dgvReminder.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvReminder.RowTemplate.Height = 28;
            this.dgvReminder.Size = new System.Drawing.Size(1183, 764);
            this.dgvReminder.TabIndex = 38;
            this.dgvReminder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReminder_CellClick);
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddReminder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddReminder.Location = new System.Drawing.Point(10, 9);
            this.btnAddReminder.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(267, 32);
            this.btnAddReminder.TabIndex = 37;
            this.btnAddReminder.Text = "Додати нагадування";
            this.btnAddReminder.UseVisualStyleBackColor = true;
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // ReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 873);
            this.ControlBox = false;
            this.Controls.Add(this.dgvReminder);
            this.Controls.Add(this.btnAddReminder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ReminderForm";
            this.Text = "Нагадування";
            this.Load += new System.EventHandler(this.ReminderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReminder;
        private System.Windows.Forms.Button btnAddReminder;
    }
}