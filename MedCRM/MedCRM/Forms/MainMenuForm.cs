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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleForm shedForm = new ScheduleForm();
            shedForm.ShowDialog();
        }

        private void lechPriemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorMenu menu = new DoctorMenu();
            menu.ShowDialog();
        }

        private void dispensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DispensForm form = new DispensForm();
            form.ShowDialog();
        }

        private void dispGroupOtchetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm(false);
            form.ShowDialog();
        }

        private void mkbOtchetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm(true);
            form.ShowDialog();
        }
    }
}
