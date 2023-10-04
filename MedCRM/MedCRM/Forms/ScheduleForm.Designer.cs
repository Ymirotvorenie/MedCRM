namespace MedCRM.Forms
{
    partial class ScheduleForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            this.label2 = new System.Windows.Forms.Label();
            this.specialtyComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.doctorFIOLabel = new System.Windows.Forms.Label();
            this.addNewPatientButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.patientComboBox = new System.Windows.Forms.ComboBox();
            this.cleanPatComboBoxButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Специализация";
            // 
            // specialtyComboBox
            // 
            this.specialtyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialtyComboBox.FormattingEnabled = true;
            this.specialtyComboBox.Location = new System.Drawing.Point(27, 122);
            this.specialtyComboBox.Name = "specialtyComboBox";
            this.specialtyComboBox.Size = new System.Drawing.Size(450, 37);
            this.specialtyComboBox.TabIndex = 2;
            this.specialtyComboBox.SelectedIndexChanged += new System.EventHandler(this.specialtyComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Врач";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(26, 212);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(450, 37);
            this.doctorComboBox.TabIndex = 4;
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorComboBox_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(667, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(757, 695);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 35);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // doctorFIOLabel
            // 
            this.doctorFIOLabel.AutoSize = true;
            this.doctorFIOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorFIOLabel.Location = new System.Drawing.Point(663, 32);
            this.doctorFIOLabel.Name = "doctorFIOLabel";
            this.doctorFIOLabel.Size = new System.Drawing.Size(196, 29);
            this.doctorFIOLabel.TabIndex = 16;
            this.doctorFIOLabel.Text = "Фамилия врача";
            // 
            // addNewPatientButton
            // 
            this.addNewPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewPatientButton.Location = new System.Drawing.Point(525, 369);
            this.addNewPatientButton.Name = "addNewPatientButton";
            this.addNewPatientButton.Size = new System.Drawing.Size(37, 37);
            this.addNewPatientButton.TabIndex = 23;
            this.addNewPatientButton.Text = "+";
            this.addNewPatientButton.UseVisualStyleBackColor = true;
            this.addNewPatientButton.Click += new System.EventHandler(this.addNewPatientButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(22, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 29);
            this.label8.TabIndex = 25;
            this.label8.Text = "Пациент";
            // 
            // patientComboBox
            // 
            this.patientComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.patientComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.patientComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientComboBox.FormattingEnabled = true;
            this.patientComboBox.Location = new System.Drawing.Point(26, 369);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(450, 37);
            this.patientComboBox.TabIndex = 24;
            // 
            // cleanPatComboBoxButton
            // 
            this.cleanPatComboBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cleanPatComboBoxButton.Location = new System.Drawing.Point(482, 369);
            this.cleanPatComboBoxButton.Name = "cleanPatComboBoxButton";
            this.cleanPatComboBoxButton.Size = new System.Drawing.Size(37, 37);
            this.cleanPatComboBoxButton.TabIndex = 26;
            this.cleanPatComboBoxButton.Text = "х";
            this.cleanPatComboBoxButton.UseVisualStyleBackColor = true;
            this.cleanPatComboBoxButton.Click += new System.EventHandler(this.cleanPatComboBoxButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(482, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "иб";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 799);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cleanPatComboBoxButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.patientComboBox);
            this.Controls.Add(this.addNewPatientButton);
            this.Controls.Add(this.doctorFIOLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.specialtyComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1477, 855);
            this.MinimumSize = new System.Drawing.Size(1477, 855);
            this.Name = "ScheduleForm";
            this.Text = "Расписание";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox specialtyComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label doctorFIOLabel;
        private System.Windows.Forms.Button addNewPatientButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox patientComboBox;
        private System.Windows.Forms.Button cleanPatComboBoxButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}