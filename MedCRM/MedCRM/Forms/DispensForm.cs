using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCRM.Forms
{
    public partial class DispensForm : Form
    {
        public DispensForm()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Дата", 50);
            listView1.Columns.Add("Врач", 250);
            listView1.Columns.Add("Диагноз", 450);
            MKBcomboBox.Items.Add("A80 Острый полиомиелит");
            MKBcomboBox.Items.Add("A80.0 Острый паралитический полиомиелит,  ассоциированный с вакциной");
            MKBcomboBox.Items.Add("A80.1 Острый паралитический  полиомиелит,  вызванный диким завезенным вирусом");
            MKBcomboBox.Items.Add("A80.2 Острый паралитический  полиомиелит,  вызванный диким природным вирусом");
            MKBcomboBox.Items.Add("A80.3 Острый паралитический полиомиелит другой и неуточненный");
            MKBcomboBox.Items.Add("A80.4 Острый непаралитический полиомиелит");
            MKBcomboBox.Items.Add("A80.9 Острый полиомиелит неуточненный");
            MKBcomboBox.Items.Add("A81 Медленные вирусные инфекции центральной нервной системы");
            MKBcomboBox.Items.Add("A81.0 Болезнь Крейтцфельдта-Якоба");
            MKBcomboBox.Items.Add("A81.1 Подострый склерозирующий панэнцефалит");
            MKBcomboBox.Items.Add("A81.2 Прогрессирующая многоочаговая лейкоэнцефалопатия");
            MKBcomboBox.Items.Add("A81.8 Другие медленные  вирусные инфекции   центральной нервной системы");
            MKBcomboBox.Items.Add("A81.9 Медленные вирусные инфекции центральной нервной системы неуточненные");
            MKBcomboBox.Items.Add("A82 Бешенство");
            MKBcomboBox.Items.Add("A82.0 Лесное бешенство");
            MKBcomboBox.Items.Add("A82.1 Городское бешенство");
            MKBcomboBox.Items.Add("A82.9 Бешенство неуточненное");
            patientsComboBox.Items.Clear();
            foreach (Patient patient in MedicalCenter.PatientsBase.Values)
            {
                patientsComboBox.Items.Add(patient.getFIO_BD());
            }
        }

        private void patientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            appointmentRichTextBox.Text = string.Empty;
            diagnosisRichTextBox.Text = string.Empty;
            dispGroupTextBox.Text = string.Empty;
            listView1.Items.Clear();
            string temp = patientsComboBox.Text.Split(',')[0];
            foreach (MedicalReport medRep in MedicalCenter.PatientsBase[temp].MedicalHistory)
            {
                listView1.Items.Add(new ListViewItem(new string[] { medRep.Visit.VisitDate.ToString("dd.MM.yyyy"), 
                    medRep.Visit.Doctor.getFIO(), medRep.Diagnosis }));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string temp = patientsComboBox.Text.Split(',')[0];
            foreach (MedicalReport medRep in MedicalCenter.PatientsBase[temp].MedicalHistory)
            {
                if (medRep.Visit.VisitDate.ToString().Split(' ')[0] == listView1.SelectedItems[0].SubItems[0].Text
                    && medRep.Visit.Doctor.getFIO() == listView1.SelectedItems[0].SubItems[1].Text
                    && medRep.Diagnosis == listView1.SelectedItems[0].SubItems[2].Text)
                {
                    MessageBox.Show(medRep.ToString());
                }
            }
        }
        private string printString;
        void PrintPageHadler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printString, new Font("Arial", 14), Brushes.Black, 50, 50);
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            printString = appointmentRichTextBox.Text;
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += PrintPageHadler;
            PrintDialog print = new PrintDialog();
            print.Document = doc;
            if (print.ShowDialog() == DialogResult.OK)
            {
                print.Document.Print();
            }
        }

        private void addInfoButton_Click(object sender, EventArgs e)
        {
            string temp = patientsComboBox.Text.Split(',')[0];
            MedicalCenter.PatientsBase[temp].DispensaryGroup = dispGroupTextBox.Text;
            MedicalCenter.PatientsBase[temp].MainDiagnosis = diagnosisRichTextBox.Text;
            if(MKBcomboBox.Text != string.Empty)
            {
                MedicalCenter.PatientsBase[temp].MainDiagnosisMKB = MKBcomboBox.Text;
            }
            else
            {
                MessageBox.Show("Выберите наименование МКБ-10");
            }
            MessageBox.Show("Данные добавлены в медицинскую карту пациента");
        }
    }
}
