using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCRM
{
    internal class Visit
    {
        public Visit(Doctor _doctor, Patient _patient, DateTime _date)
        {
            Doctor = _doctor;
            Patient = _patient;
            VisitDate = _date;
            IsComplete = false;
        }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime VisitDate { get; set; }
        public bool IsComplete { get; set; }
        public static bool operator == (Visit visit1, Visit visit2)
        {
            if(visit1.Doctor.getFIO() == visit2.Doctor.getFIO() && visit1.VisitDate == visit2.VisitDate
                && visit1.Patient.getFIO_BD() == visit2.Patient.getFIO_BD())
            {
                return true;
            }
            return false;
        }
        public static bool operator != (Visit visit1, Visit visit2)
        {
            return true;
        }

    }
}
