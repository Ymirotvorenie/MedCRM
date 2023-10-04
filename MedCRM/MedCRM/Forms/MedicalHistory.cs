using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCRM.Forms
{
    public partial class MedicalHistory : Form
    {
        public MedicalHistory(string patientName)
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Дата", 50);
            listView1.Columns.Add("Врач", 250);
            listView1.Columns.Add("Диагноз", 450);
            label1.Text = patientName;
            string temp = patientName.Split(',')[0];
            foreach(MedicalReport medRep in MedicalCenter.PatientsBase[temp].MedicalHistory)
            {
                listView1.Items.Add(new ListViewItem(new string[] {medRep.Visit.VisitDate.ToString("dd.MM.yyyy"),medRep.Visit.Doctor.getFIO(),medRep.Diagnosis }));
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string temp = label1.Text.Split(',')[0];
            foreach(MedicalReport medRep in MedicalCenter.PatientsBase[temp].MedicalHistory)
            {
                if(medRep.Visit.VisitDate.ToString().Split(' ')[0] == listView1.SelectedItems[0].SubItems[0].Text
                    && medRep.Visit.Doctor.getFIO() == listView1.SelectedItems[0].SubItems[1].Text
                    && medRep.Diagnosis == listView1.SelectedItems[0].SubItems[2].Text)
                {
                    MessageBox.Show(medRep.ToString());
                }
            }
        }
    }
}
