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
    public partial class ReportForm : Form
    {
        public ReportForm(bool arg)
        {
            InitializeComponent();
            listView1.View = View.Details;
            if(arg)
            {
                listView1.Columns.Add("МКБ-10", 50);
                listView1.Columns.Add("Пациент", 550);
                label1.Text = "Отчет МКБ-10";
                printString = "МКБ  ФИО пациента\n";
                foreach (Patient patient in MedicalCenter.PatientsBase.Values)
                {
                    if (patient.MainDiagnosisMKB != null)
                    {
                        string temp = patient.MainDiagnosisMKB.Split(' ')[0];
                        string temp1 = patient.getFIO_BD();
                        ListViewItem item = new ListViewItem(new string[] { temp, temp1 });
                        listView1.Items.Add(item);
                    }
                }
            }
            else
            {
                listView1.Columns.Add("Д.Группа", 70);
                listView1.Columns.Add("Пациент", 550);
                label1.Text = "Отчет Диспансерная группа";
                printString = "ДГ ФИО пациента\n";
                foreach (Patient patient in MedicalCenter.PatientsBase.Values)
                {
                    if(patient.DispensaryGroup != null)
                    {
                        string temp = patient.DispensaryGroup;
                        string temp1 = patient.getFIO_BD();
                        ListViewItem item = new ListViewItem(new string[] { temp, temp1 });
                        listView1.Items.Add(item);
                    }
                }
            }

        }
        private string printString;
        void PrintPageHadler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(printString, new Font("Arial", 14), Brushes.Black, 50, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach(ListViewItem item in listView1.Items)
            {
                printString += item.SubItems[0].Text;
                printString += " ";
                printString += item.SubItems[1].Text;
                printString += "\n";
            }
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
