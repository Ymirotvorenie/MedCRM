namespace MedCRM.Forms
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.направленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispGroupOtchetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mkbOtchetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lechPriemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.doctorWorkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1635, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расписаниеToolStripMenuItem,
            this.направленияToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(99, 36);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new System.Drawing.Size(266, 40);
            this.расписаниеToolStripMenuItem.Text = "Расписание";
            this.расписаниеToolStripMenuItem.Click += new System.EventHandler(this.расписаниеToolStripMenuItem_Click);
            // 
            // направленияToolStripMenuItem
            // 
            this.направленияToolStripMenuItem.Name = "направленияToolStripMenuItem";
            this.направленияToolStripMenuItem.Size = new System.Drawing.Size(266, 40);
            this.направленияToolStripMenuItem.Text = "Направления";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dispGroupOtchetToolStripMenuItem,
            this.mkbOtchetToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(266, 40);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // dispGroupOtchetToolStripMenuItem
            // 
            this.dispGroupOtchetToolStripMenuItem.Name = "dispGroupOtchetToolStripMenuItem";
            this.dispGroupOtchetToolStripMenuItem.Size = new System.Drawing.Size(358, 40);
            this.dispGroupOtchetToolStripMenuItem.Text = "Диспансерная группа";
            this.dispGroupOtchetToolStripMenuItem.Click += new System.EventHandler(this.dispGroupOtchetToolStripMenuItem_Click);
            // 
            // mkbOtchetToolStripMenuItem
            // 
            this.mkbOtchetToolStripMenuItem.Name = "mkbOtchetToolStripMenuItem";
            this.mkbOtchetToolStripMenuItem.Size = new System.Drawing.Size(358, 40);
            this.mkbOtchetToolStripMenuItem.Text = "МКБ";
            this.mkbOtchetToolStripMenuItem.Click += new System.EventHandler(this.mkbOtchetToolStripMenuItem_Click);
            // 
            // doctorWorkToolStripMenuItem
            // 
            this.doctorWorkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lechPriemToolStripMenuItem,
            this.dispensToolStripMenuItem});
            this.doctorWorkToolStripMenuItem.Name = "doctorWorkToolStripMenuItem";
            this.doctorWorkToolStripMenuItem.Size = new System.Drawing.Size(84, 36);
            this.doctorWorkToolStripMenuItem.Text = "Врач";
            // 
            // lechPriemToolStripMenuItem
            // 
            this.lechPriemToolStripMenuItem.Name = "lechPriemToolStripMenuItem";
            this.lechPriemToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.lechPriemToolStripMenuItem.Text = "Лечебный прием";
            this.lechPriemToolStripMenuItem.Click += new System.EventHandler(this.lechPriemToolStripMenuItem_Click);
            // 
            // dispensToolStripMenuItem
            // 
            this.dispensToolStripMenuItem.Name = "dispensToolStripMenuItem";
            this.dispensToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.dispensToolStripMenuItem.Text = "Диспансеризация";
            this.dispensToolStripMenuItem.Click += new System.EventHandler(this.dispensToolStripMenuItem_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 1034);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenuForm";
            this.Text = "Главное меню";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem направленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispGroupOtchetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mkbOtchetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lechPriemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispensToolStripMenuItem;
    }
}