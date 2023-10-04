using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCRM.Forms
{
    public partial class ScheduleForm : Form
    {
        Button deleteVisitButton1 = new Button();
        public void FillTimeToListViewFirstShift(ListView listView)
        {
            listView.Items.Add("08:00");
            listView.Items.Add("08:15");
            listView.Items.Add("08:30");
            listView.Items.Add("08:45");
            listView.Items.Add("09:00");
            listView.Items.Add("09:15");
            listView.Items.Add("09:30");
            listView.Items.Add("09:45");
            listView.Items.Add("10:00");
            listView.Items.Add("10:15");
            listView.Items.Add("10:30");
            listView.Items.Add("10:45");
            listView.Items.Add("11:00");
            listView.Items.Add("11:15");
            listView.Items.Add("11:30");
            listView.Items.Add("11:45");
            listView.Items.Add("12:00");
            listView.Items.Add("12:15");
            listView.Items.Add("12:30");
            listView.Items.Add("12:45");
            listView.Items.Add("13:00");
            listView.Items.Add("13:15");
            listView.Items.Add("13:30");
            listView.Items.Add("13:45");
        }
        public void FillTimeToListViewSecondShift(ListView listView)
        {
            listView.Items.Add("14:00");
            listView.Items.Add("14:15");
            listView.Items.Add("14:30");
            listView.Items.Add("14:45");
            listView.Items.Add("15:00");
            listView.Items.Add("15:15");
            listView.Items.Add("15:30");
            listView.Items.Add("15:45");
            listView.Items.Add("16:00");
            listView.Items.Add("16:15");
            listView.Items.Add("16:30");
            listView.Items.Add("16:45");
            listView.Items.Add("17:00");
            listView.Items.Add("17:15");
            listView.Items.Add("17:30");
            listView.Items.Add("17:45");
            listView.Items.Add("18:00");
            listView.Items.Add("18:15");
            listView.Items.Add("18:30");
            listView.Items.Add("18:45");
            listView.Items.Add("19:00");
            listView.Items.Add("19:15");
            listView.Items.Add("19:30");
            listView.Items.Add("19:45");
        }
        public void AddColumnToListViewSchedule(ListView listView)
        {
            listView.View = View.Details;
            listView.Columns.Add("Время", 50);
            listView.Columns.Add("Пациент", 440);
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();

            if (MedicalCenter.DoctorsBase[doctorComboBox.Text].isFirstSHift)
            {
                FillTimeToListViewFirstShift(listView1);
            }
            else
            {
                FillTimeToListViewSecondShift(listView1);
            }

            foreach (Visit visit in MedicalCenter.Visits)
            {

                    if (visit.Doctor.getFIO() == doctorComboBox.Text && visit.VisitDate.Date == dateTimePicker1.Value.Date)
                    {
                        for (int i = 0; i < listView1.Items.Count; i++)
                        {
                            if (listView1.Items[i].Text == visit.VisitDate.ToString("HH:mm"))
                            {
                                listView1.Items[i].SubItems[0].Text = (visit.Patient.getFIO() + ", " + visit.Patient.DateOfBirth.ToString("dd.MM.yyyy"));
                                listView1.Items[i] = new ListViewItem(new string[]
                                {
                                visit.VisitDate.ToString("HH:mm"),
                                (visit.Patient.getFIO() + ", " + visit.Patient.DateOfBirth.ToString("dd.MM.yyyy"))
                                });
                            }
                        }
                    }
                

            }
        }
        //НЕ УДАЛЯТЬ!!!!!!!!!!!!!!!!!!!!!!!!!!
        //!!!!!!!!!!!!!!!!Попробовать переделать функции обновления комбобоксов для всех классов под одну функцию
        //private void UpdateComboBox(ComboBox comboBox, CollectionBase collection)
        //{
        //    foreach(var item in collection)
        //    {
        //        comboBox.Items.Add(item.ToString());
        //    }
        //}
        //НЕ УДАЛЯТЬ!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void UpdatePatientComboBox()
        {
            patientComboBox.Items.Clear();
            foreach (Patient patient in MedicalCenter.PatientsBase.Values)
            {
                patientComboBox.Items.Add(patient.getFIO_BD());
            }
        }
        public ScheduleForm()
        {
            InitializeComponent();
            specialtyComboBox.Items.AddRange(MedicalCenter.Specialty);

            toolTip1.SetToolTip(addNewPatientButton, "Регистрация нового пациента");
            toolTip1.SetToolTip(cleanPatComboBoxButton, "Очистить поле");
            
            patientComboBox.Sorted = true;
            UpdatePatientComboBox();
            AddColumnToListViewSchedule(listView1);
            MessageBox.Show("Чтобы добавить запись на прием выберите доктора, пациента и дважды нажмите на свободное время");
        }

        private void specialtyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            doctorFIOLabel.Text = "Фамилия врача";
            doctorComboBox.Items.Clear();
            doctorComboBox.Text = string.Empty;
            foreach (Doctor doctor in MedicalCenter.DoctorsBase.Values)
            {
                if (specialtyComboBox.Text != string.Empty
                    && specialtyComboBox.Text == doctor.Specialty)
                {
                    doctorComboBox.Items.Add(doctor.getFIO());
                }
            }
            this.Controls.Remove(deleteVisitButton1);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(this.Controls.Contains(deleteVisitButton1)))
            {
                deleteVisitButton1.Height = 27;
                deleteVisitButton1.Width = 27;
                deleteVisitButton1.Location = new Point(400, 50);
                deleteVisitButton1.Image = Properties.Resources.crosslinear_106242;
                deleteVisitButton1.BringToFront();
                deleteVisitButton1.Click += deleteVisitButton_Click;
                this.Controls.Add(deleteVisitButton1);
            }
        }
        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            doctorFIOLabel.Text = doctorComboBox.Text + ", " + MedicalCenter.DoctorsBase[doctorComboBox.Text].Post;
            this.Controls.Remove(deleteVisitButton1);
            UpdateListView();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value.Date >= DateTime.Today.Date)
            {
                if (doctorComboBox.Text != string.Empty && patientComboBox.Text != string.Empty)
                {
                    string tempDoct = doctorComboBox.Text;
                    string tempPatient = patientComboBox.Text.Split(',')[0];
                    Visit visit = new Visit(MedicalCenter.DoctorsBase[tempDoct], MedicalCenter.PatientsBase[tempPatient], dateTimePicker1.Value);
                    string tempDate = visit.VisitDate.Date.ToString("dd.MM.yyyy") + " " + listView1.SelectedItems[0].Text + ":00";
                    visit.VisitDate = DateTime.Parse(tempDate);
                    if(!MedicalCenter.Contains(MedicalCenter.Visits, visit))
                    {
                        MedicalCenter.Visits.Add(visit);
                        UpdateListView();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
            else
            {
                MessageBox.Show("Проверьте корректность выбранной даты записи");
            }
            
        }

        private void cleanPatComboBoxButton_Click(object sender, EventArgs e)
        {
            patientComboBox.Text = string.Empty;
        }

        private void addNewPatientButton_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatient = new AddPatientForm();
            addPatient.ShowDialog();
            UpdatePatientComboBox();
        }

        private void deleteVisitButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count > 0)
            {
                for (int i = 0; i < MedicalCenter.Visits.Count; i++)
                {
                    if (MedicalCenter.Visits[i].VisitDate.Date == dateTimePicker1.Value.Date)
                    {
                        string temp = MedicalCenter.Visits[i].VisitDate.ToString("HH:mm");
                        if (temp == listView1.SelectedItems[0].Text)
                        {
                            MedicalCenter.Visits.Remove(MedicalCenter.Visits[i]);

                            break;
                        }
                    }

                }
                UpdateListView();
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateListView();
            this.Controls.Remove(deleteVisitButton1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicalHistory medHis = new MedicalHistory(patientComboBox.Text);
            medHis.ShowDialog();
        }
    }
}
