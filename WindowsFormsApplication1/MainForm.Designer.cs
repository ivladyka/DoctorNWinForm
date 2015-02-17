namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PatientsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MedicalTestTypeManuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MedicationFormMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MedicationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WarehouseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PatientsMenuItem,
            this.WarehouseMenuItem,
            this.налаштуванняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PatientsMenuItem
            // 
            this.PatientsMenuItem.Name = "PatientsMenuItem";
            this.PatientsMenuItem.Size = new System.Drawing.Size(69, 20);
            this.PatientsMenuItem.Text = "Пацієнти";
            this.PatientsMenuItem.Click += new System.EventHandler(this.PatientsMenuItem_Click);
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MedicalTestTypeManuItem,
            this.MedicationFormMenuItem,
            this.MedicationMenuItem});
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            // 
            // MedicalTestTypeManuItem
            // 
            this.MedicalTestTypeManuItem.Name = "MedicalTestTypeManuItem";
            this.MedicalTestTypeManuItem.Size = new System.Drawing.Size(168, 22);
            this.MedicalTestTypeManuItem.Text = "Типи Документів";
            this.MedicalTestTypeManuItem.Click += new System.EventHandler(this.MedicalTestTypeManuItem_Click);
            // 
            // MedicationFormMenuItem
            // 
            this.MedicationFormMenuItem.Name = "MedicationFormMenuItem";
            this.MedicationFormMenuItem.Size = new System.Drawing.Size(168, 22);
            this.MedicationFormMenuItem.Text = "Лікарські Форми";
            this.MedicationFormMenuItem.Click += new System.EventHandler(this.MedicationFormMenuItem_Click);
            // 
            // MedicationMenuItem
            // 
            this.MedicationMenuItem.Name = "MedicationMenuItem";
            this.MedicationMenuItem.Size = new System.Drawing.Size(168, 22);
            this.MedicationMenuItem.Text = "Ліки";
            this.MedicationMenuItem.Click += new System.EventHandler(this.MedicationMenuItem_Click);
            // 
            // WarehouseMenuItem
            // 
            this.WarehouseMenuItem.Name = "WarehouseMenuItem";
            this.WarehouseMenuItem.Size = new System.Drawing.Size(52, 20);
            this.WarehouseMenuItem.Text = "Склад";
            this.WarehouseMenuItem.Click += new System.EventHandler(this.WarehouseMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 429);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Doctor N";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PatientsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MedicalTestTypeManuItem;
        private System.Windows.Forms.ToolStripMenuItem MedicationFormMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MedicationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WarehouseMenuItem;
    }
}