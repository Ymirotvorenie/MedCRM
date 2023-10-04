using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MedCRM.Forms
{
    public partial class DoctorCreateMedRep : Form
    {
        private void fillMKB()
        {
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
        }
        bool changeRep = false;
        DateTime curDate;
        public DoctorCreateMedRep(string text, DateTime date)
        {
            InitializeComponent();
            fillMKB();
            string[] strings = text.Split(',');
            labelFIO.Text = strings[0];
            labelBD.Text = strings[1].Trim();
            curDate = date;
        }
        internal DoctorCreateMedRep(MedicalReport medRep, bool changeRep)
        {
            InitializeComponent();
            fillMKB();
            string[] strings = medRep.Visit.Patient.getFIO_BD().Split(',');
            labelFIO.Text = strings[0];
            labelBD.Text = strings[1].Trim();
            curDate = medRep.Visit.VisitDate.Date;

            mainDiagRichTextBox.Text = medRep.Diagnosis.Split(';')[0];
            relatedDiagRichTextBox.Text = medRep.Diagnosis.Split(';')[1];
            complaintsRichTextBox.Text = medRep.Complaints;
            anamnesisRichTextBox.Text = medRep.Anamnesis;
            examDataRichTextBox.Text = medRep.ExaminationData;
            appointmentsRichTextBox.Text = medRep.Appointments;
            MKBcomboBox.Text = medRep.Mkb10;
            this.changeRep = changeRep;
        }

        private void createMedRepButton_Click(object sender, EventArgs e)
        {
            if(!changeRep)
            {
                string fullDiag = mainDiagRichTextBox.Text + ";" + relatedDiagRichTextBox.Text;

                foreach (Visit visit in MedicalCenter.Visits)
                {
                    if (visit.Patient.getFIO() == labelFIO.Text && visit.Doctor.getFIO() == MedicalCenter.currentUser.getFIO()
                        && visit.VisitDate == curDate)
                    {
                        MedicalReport medRep = new MedicalReport(visit,
                        //fullDiag + "\n", MKBcomboBox.Text + "\n\n", complaintsRichTextBox.Text + "\n\n", anamnesisRichTextBox.Text + "\n\n",
                        //examDataRichTextBox.Text + "\n\n", appointmentsRichTextBox.Text);
                        fullDiag, MKBcomboBox.Text, complaintsRichTextBox.Text, anamnesisRichTextBox.Text,
                        examDataRichTextBox.Text, appointmentsRichTextBox.Text);
                        visit.Patient.MedicalHistory.Add(medRep);
                        if (MKBcomboBox.SelectedItem != null)
                        {
                            visit.Patient.MainDiagnosisMKB = MKBcomboBox.SelectedItem.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Не заполнено МКБ-10");
                        }
                        //visit.Patient.MainDiagnosis = mainDiagRichTextBox.Text.Trim();
                        //visit.VisitDate = DateTime.Today;
                        visit.Patient.DispensaryGroup = dispGrTtextBox.Text.Trim();
                        //visit.Patient.MainDiagnosisMKB = MKBcomboBox.SelectedItem.ToString();
                        visit.IsComplete = true;
                    }
                }
            }
            else
            {
                foreach(MedicalReport medRep in MedicalCenter.PatientsBase[labelFIO.Text].MedicalHistory)
                {
                    if(medRep.Visit.Doctor.getFIO() == MedicalCenter.currentUser.getFIO()
                        && medRep.Visit.VisitDate.Date == curDate.Date)
                    {
                        medRep.Complaints = complaintsRichTextBox.Text.Trim();
                        medRep.Anamnesis = anamnesisRichTextBox.Text.Trim();
                        medRep.ExaminationData = examDataRichTextBox.Text.Trim();
                        medRep.Appointments = appointmentsRichTextBox.Text.Trim();
                        medRep.Diagnosis = mainDiagRichTextBox.Text.Trim() + "\n" 
                            + relatedDiagRichTextBox.Text.Trim();
                        medRep.Mkb10 = MKBcomboBox.Text.Trim();
                    }
                }
            }

            this.Close();
        }
    }
}
