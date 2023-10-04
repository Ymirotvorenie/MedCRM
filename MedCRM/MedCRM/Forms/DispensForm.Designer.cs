namespace MedCRM.Forms
{
    partial class DispensForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DispensForm));
            this.label1 = new System.Windows.Forms.Label();
            this.patientsComboBox = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.dispGroupTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.diagnosisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.appointmentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.addInfoButton = new System.Windows.Forms.Button();
            this.MKBcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО пациента";
            // 
            // patientsComboBox
            // 
            this.patientsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientsComboBox.FormattingEnabled = true;
            this.patientsComboBox.Location = new System.Drawing.Point(243, 51);
            this.patientsComboBox.Name = "patientsComboBox";
            this.patientsComboBox.Size = new System.Drawing.Size(567, 37);
            this.patientsComboBox.TabIndex = 1;
            this.patientsComboBox.SelectedIndexChanged += new System.EventHandler(this.patientsComboBox_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(54, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(756, 433);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(844, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Диспансерная группа";
            // 
            // dispGroupTextBox
            // 
            this.dispGroupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dispGroupTextBox.Location = new System.Drawing.Point(848, 83);
            this.dispGroupTextBox.Name = "dispGroupTextBox";
            this.dispGroupTextBox.Size = new System.Drawing.Size(100, 35);
            this.dispGroupTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(844, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Диагноз";
            // 
            // diagnosisRichTextBox
            // 
            this.diagnosisRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagnosisRichTextBox.Location = new System.Drawing.Point(848, 249);
            this.diagnosisRichTextBox.Name = "diagnosisRichTextBox";
            this.diagnosisRichTextBox.Size = new System.Drawing.Size(391, 310);
            this.diagnosisRichTextBox.TabIndex = 6;
            this.diagnosisRichTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(74, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Рекомендации";
            // 
            // appointmentRichTextBox
            // 
            this.appointmentRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appointmentRichTextBox.Location = new System.Drawing.Point(54, 620);
            this.appointmentRichTextBox.Name = "appointmentRichTextBox";
            this.appointmentRichTextBox.Size = new System.Drawing.Size(1185, 298);
            this.appointmentRichTextBox.TabIndex = 8;
            this.appointmentRichTextBox.Text = "";
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printButton.Location = new System.Drawing.Point(79, 934);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(184, 78);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "Распечатать рекомендации";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // addInfoButton
            // 
            this.addInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addInfoButton.Location = new System.Drawing.Point(786, 934);
            this.addInfoButton.Name = "addInfoButton";
            this.addInfoButton.Size = new System.Drawing.Size(453, 78);
            this.addInfoButton.TabIndex = 10;
            this.addInfoButton.Text = "Добавить в карту пациента данные о диспансерной группе и диагноз";
            this.addInfoButton.UseVisualStyleBackColor = true;
            this.addInfoButton.Click += new System.EventHandler(this.addInfoButton_Click);
            // 
            // MKBcomboBox
            // 
            this.MKBcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MKBcomboBox.FormattingEnabled = true;
            this.MKBcomboBox.Location = new System.Drawing.Point(849, 158);
            this.MKBcomboBox.Name = "MKBcomboBox";
            this.MKBcomboBox.Size = new System.Drawing.Size(390, 37);
            this.MKBcomboBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(844, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "МКБ-10";
            // 
            // DispensForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 1053);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MKBcomboBox);
            this.Controls.Add(this.addInfoButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.appointmentRichTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.diagnosisRichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dispGroupTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.patientsComboBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1318, 1109);
            this.MinimumSize = new System.Drawing.Size(1318, 1109);
            this.Name = "DispensForm";
            this.Text = "Диспансерное наблюдение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox patientsComboBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dispGroupTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox diagnosisRichTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox appointmentRichTextBox;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button addInfoButton;
        private System.Windows.Forms.ComboBox MKBcomboBox;
        private System.Windows.Forms.Label label5;
    }
}