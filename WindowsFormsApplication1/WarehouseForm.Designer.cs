namespace WindowsFormsApplication1
{
    partial class WarehouseForm
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
            this.dgvMedicationWarehouse = new System.Windows.Forms.DataGridView();
            this.btnAddMedicationFlow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicationWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedicationWarehouse
            // 
            this.dgvMedicationWarehouse.AllowUserToAddRows = false;
            this.dgvMedicationWarehouse.AllowUserToDeleteRows = false;
            this.dgvMedicationWarehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMedicationWarehouse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMedicationWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicationWarehouse.Location = new System.Drawing.Point(10, 45);
            this.dgvMedicationWarehouse.Margin = new System.Windows.Forms.Padding(6);
            this.dgvMedicationWarehouse.MultiSelect = false;
            this.dgvMedicationWarehouse.Name = "dgvMedicationWarehouse";
            this.dgvMedicationWarehouse.ReadOnly = true;
            this.dgvMedicationWarehouse.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvMedicationWarehouse.RowTemplate.Height = 28;
            this.dgvMedicationWarehouse.Size = new System.Drawing.Size(995, 764);
            this.dgvMedicationWarehouse.TabIndex = 36;
            this.dgvMedicationWarehouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicationWarehouse_CellClick);
            // 
            // btnAddMedicationFlow
            // 
            this.btnAddMedicationFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddMedicationFlow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddMedicationFlow.Location = new System.Drawing.Point(10, 9);
            this.btnAddMedicationFlow.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddMedicationFlow.Name = "btnAddMedicationFlow";
            this.btnAddMedicationFlow.Size = new System.Drawing.Size(267, 32);
            this.btnAddMedicationFlow.TabIndex = 35;
            this.btnAddMedicationFlow.Text = "Додати прихід/розхід";
            this.btnAddMedicationFlow.UseVisualStyleBackColor = true;
            this.btnAddMedicationFlow.Click += new System.EventHandler(this.btnAddMedicationFlow_Click);
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 873);
            this.ControlBox = false;
            this.Controls.Add(this.dgvMedicationWarehouse);
            this.Controls.Add(this.btnAddMedicationFlow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WarehouseForm";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.WarehouseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicationWarehouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicationWarehouse;
        private System.Windows.Forms.Button btnAddMedicationFlow;
    }
}