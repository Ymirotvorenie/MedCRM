using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCRM
{
    internal class MedicalReport
    {
        public Visit Visit { get; }
        public string Complaints { get; set; }
        public string Anamnesis { get; set; }
        public string ExaminationData { get; set; }
        public string Appointments { get; set; }
        public string Diagnosis { get; set; }
        public string Mkb10 { get; set; }
        public MedicalReport(Visit _visit, string diagnosis, string mkb, string complaints, string anamnesis, string examinationData, string appointments) 
        {
            Visit = _visit;
            Diagnosis = diagnosis;
            Mkb10 = mkb;
            Complaints = complaints;
            Anamnesis = anamnesis;
            ExaminationData = examinationData;
            Appointments = appointments;
        }

        public override string ToString()
        {
            string tempMedRep = string.Empty;

            tempMedRep = "\n\nЖалобы:\n" + Complaints + "\nАнамнез:\n" + Anamnesis 
                + "\nДанные объективного осмотра:\n" + ExaminationData + "\nМКБ-10: "+ Mkb10
                + "\nДиагноз:\n" + Diagnosis + "\nРекомендации:\n" + Appointments + "\n\n";
            string patientData = Visit.Patient.getFIO_BD();
            string doctorFIO = Visit.Doctor.getFIO();
            return patientData + tempMedRep + doctorFIO + "\n" + Visit.VisitDate.ToString("dd.MM.yyyy");
        }
    }
}

