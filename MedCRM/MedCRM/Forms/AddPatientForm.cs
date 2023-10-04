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
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
            sexComboBox.Items.AddRange(new object[] { "Мужской", "Женский" });
        }

        private void addNewPatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                Patient newPatient = new Patient
                (
                    MedicalCenter.PatientsBase.Count() + 1, surnameTextBox.Text, firstnameTextBox.Text, patronymicTextBox.Text,
                    birthDateTimePicker.Value, sexComboBox.SelectedText, countryTextBox.Text, postcodeTextBox.Text, regionTextBox.Text,
                    cityTextBox.Text, streetTextBox.Text, houseTextBox.Text, flatTextBox.Text, phoneTextBox.Text, emailTextBox.Text
                );
                MedicalCenter.PatientsBase.Add(newPatient.getFIO(), newPatient);
                this.Close();
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
