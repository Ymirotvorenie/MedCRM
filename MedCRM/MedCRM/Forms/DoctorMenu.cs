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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedCRM.Forms
{
    public partial class DoctorMenu : Form
    {
        private void fillMKB()
        {

        }
        private void updateTodayListView()
        {
            doneVisitsListView.Items.Clear();
            foreach(Visit visit in MedicalCenter.Visits)
            {
                if(visit.IsComplete)
                {
                    if (visit.VisitDate.Date == monthCalendar1.TodayDate.Date)
                    {
                        ListViewItem row = new ListViewItem(new string[] { visit.VisitDate.ToString(), visit.Patient.getFIO_BD() });
                        doneVisitsListView.Items.Add(row);
                    }
                }
                
            }
        }

        private void updateListView(System.Windows.Forms.ListView list)
        {
            dayPatientListView.Items.Clear();
            dayPatientListView.Items.Add("08:00");
            dayPatientListView.Items.Add("08:15");
            dayPatientListView.Items.Add("08:30");
            dayPatientListView.Items.Add("08:45");
            dayPatientListView.Items.Add("09:00");
            dayPatientListView.Items.Add("09:15");
            dayPatientListView.Items.Add("09:30");
            dayPatientListView.Items.Add("09:45");
            dayPatientListView.Items.Add("10:00");
            dayPatientListView.Items.Add("10:15");
            dayPatientListView.Items.Add("10:30");
            dayPatientListView.Items.Add("10:45");
            dayPatientListView.Items.Add("11:00");
            dayPatientListView.Items.Add("11:15");
            dayPatientListView.Items.Add("11:30");
            dayPatientListView.Items.Add("11:45");
            dayPatientListView.Items.Add("12:00");
            dayPatientListView.Items.Add("12:15");
            dayPatientListView.Items.Add("12:30");
            dayPatientListView.Items.Add("12:45");
            dayPatientListView.Items.Add("13:00");
            dayPatientListView.Items.Add("13:15");
            dayPatientListView.Items.Add("13:30");
            dayPatientListView.Items.Add("13:45");
            foreach (Visit visit in MedicalCenter.Visits)
            {
                if(!visit.IsComplete)
                {
                    if (visit.Doctor.getFIO() == label2.Text.Split(',')[0] && visit.VisitDate.Date == monthCalendar1.SelectionStart.Date)
                    {
                        for (int i = 0; i < list.Items.Count; i++)
                        {
                            if (list.Items[i].Text == visit.VisitDate.ToString("HH:mm"))
                            {
                                list.Items[i].SubItems[0].Text = (visit.Patient.getFIO() + ", " + visit.Patient.DateOfBirth.ToString("dd.MM.yyyy"));
                                list.Items[i] = new ListViewItem(new string[]
                                {
                                visit.VisitDate.ToString("HH:mm"),
                                (visit.Patient.getFIO() + ", " + visit.Patient.DateOfBirth.ToString("dd.MM.yyyy"))
                                });
                            }
                        }
                    }
                }

            }
        }
        public DoctorMenu()
        {
            InitializeComponent();
            Doctor curDoc = (Doctor)MedicalCenter.currentUser;
            label2.Text = curDoc.getFIO() + ", " + curDoc.Post;
            dayPatientListView.View = View.Details;
            doneVisitsListView.View = View.Details;

            dayPatientListView.Columns.Add("Время", 50);
            dayPatientListView.Columns.Add("Пациент", 500);
            doneVisitsListView.Columns.Add("Дата", 70);
            doneVisitsListView.Columns.Add("Пациент", 500);
            updateListView(dayPatientListView);
            updateTodayListView();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            updateListView(dayPatientListView);
        }

        private void dayPatientListView_DoubleClick(object sender, EventArgs e)
        {
            if (dayPatientListView.SelectedItems[0].SubItems.Count > 1)
            {
                string temp = monthCalendar1.SelectionStart.ToString().Split(' ')[0] +
                    ' ' + dayPatientListView.SelectedItems[0].Text;
                DateTime currDate = DateTime.Parse(temp);
                DoctorCreateMedRep medRep
                    = new DoctorCreateMedRep(dayPatientListView.SelectedItems[0].SubItems[1].Text, currDate);
                medRep.ShowDialog();

                updateTodayListView();
                updateListView(dayPatientListView);
            }

        }

        private void doneVisitsListView_DoubleClick(object sender, EventArgs e)
        {
            //string temp1 = doneVisitsListView.SelectedItems[1].Text.Split(',')[0];
            string temp1 = doneVisitsListView.SelectedItems[0].SubItems[1].Text.Split(',')[0];
            foreach (MedicalReport medRep in MedicalCenter.PatientsBase[temp1].MedicalHistory)
            {
                if (medRep.Visit.VisitDate.Date == monthCalendar1.TodayDate.Date
                    && medRep.Visit.Doctor.getFIO() == MedicalCenter.currentUser.getFIO())
                {
                    foreach(MedicalReport rep in MedicalCenter.PatientsBase[temp1].MedicalHistory)
                    {
                        if(rep.Visit.VisitDate == DateTime.Parse(doneVisitsListView.SelectedItems[0].SubItems[0].Text))
                        {
                            string temp = rep.ToString();
                            MessageBox.Show(temp);
                            return;
                        }
                    }
                }
            }
        }
        private string printString;
        void PrintPageHadler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printString, new Font("Arial", 14), Brushes.Black, 50,50);
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            if (doneVisitsListView.SelectedItems.Count > 0)
            {
                string temp1 = doneVisitsListView.SelectedItems[0].SubItems[1].Text.Split(',')[0];
                foreach (MedicalReport medRep in MedicalCenter.PatientsBase[temp1].MedicalHistory)
                {

                    if (medRep.Visit.VisitDate.Date == monthCalendar1.TodayDate.Date
                        && medRep.Visit.Doctor.getFIO() == MedicalCenter.currentUser.getFIO())
                    {
                        printString = MedicalCenter.PatientsBase[temp1].MedicalHistory[0].ToString();
                        PrintDocument doc = new PrintDocument();
                        doc.PrintPage += PrintPageHadler;
                        PrintDialog print = new PrintDialog();
                        print.Document = doc;
                        if (print.ShowDialog() == DialogResult.OK)
                        {
                            print.Document.Print();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для печати");
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if(doneVisitsListView.SelectedItems.Count > 0)
            {
                string temp1 = doneVisitsListView.SelectedItems[0].SubItems[1].Text.Split(',')[0];
                foreach (MedicalReport medRep in MedicalCenter.PatientsBase[temp1].MedicalHistory)
                {
                    if (doneVisitsListView.SelectedItems.Count > 0)
                    {
                        if (medRep.Visit.VisitDate.Date == monthCalendar1.TodayDate.Date
                            && medRep.Visit.Doctor.getFIO() == MedicalCenter.currentUser.getFIO())
                        {
                            DoctorCreateMedRep changeRep = new DoctorCreateMedRep(medRep, true);
                            changeRep.ShowDialog();
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для изменения");
            }

        }
    }


}
