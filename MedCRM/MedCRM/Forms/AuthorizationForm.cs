using MedCRM.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCRM
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void buttonAuthEnter_Click(object sender, EventArgs e)
        {
            foreach(Doctor doctor in MedicalCenter.DoctorsBase.Values)
            {
                if(doctor.Login == textBoxAuthLogin.Text && doctor.Password == textBoxAuthPass.Text) 
                {
                    MedicalCenter.currentUser = doctor;
                    MainMenuForm form = new MainMenuForm();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                    
                }
            }

            MessageBox.Show("Неверный логин или пароль");
        }
    }
}
