using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCRM
{
    internal class Doctor : Employee
    {
        public string Specialty { get; set; }
        public bool isFirstSHift { get; set; }
        public Doctor(int _id, string _surname, string _firstName, string _patronymic, string _post, string _specialty, 
            bool _shift, string _login, string _password)
            : base(_id, _surname, _firstName, _patronymic, _post) 
        {
            Specialty = _specialty;
            isFirstSHift = _shift;
            Login = _login;
            Password = _password;
            //DoctorsVisits = new List<Visit>();
        }
        public Doctor(int _id, string _surname, string _firstName, string _patronymic, DateTime _dateOfBirth, string _sex, string _country,
            string _postalCode, string _region, string _city, string _street, string _houseNumber, string _flatNumber,
            string _phone, string _email, string _specialty) : base(_id, _surname, _firstName, _patronymic, _dateOfBirth, _sex, _country,
            _postalCode, _region, _city, _street, _houseNumber, _flatNumber, _phone, _email)
        {
            Specialty = _specialty;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Оставить одну функцию
        //public void CreateMedicalReportAddPatient(Visit _visit, string diagnosis, string complaints, string anamnesis, string examinationData, string appointments)
        //{
        //    MedicalReport newRep = new MedicalReport(_visit, diagnosis,complaints, anamnesis, examinationData, appointments);
        //    _visit.Patient.MedicalHistory.Add(newRep);
        //}
        //public MedicalReport CreateMedicalReport(Visit _visit, string diagnosis, string complaints, string anamnesis, string examinationData, string appointments)
        //{
        //    MedicalReport newRep = new MedicalReport(_visit, diagnosis, complaints, anamnesis, examinationData, appointments);
        //    return newRep;
        //}
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void AddDiagnosis(Visit _visit, string _diagnosis, string _diagnosisMKB)
        {
            _visit.Patient.MainDiagnosis = _diagnosis;
            _visit.Patient.MainDiagnosisMKB = _diagnosisMKB;
        }
        public void ChangeDispencaryGroup(Visit _visit, string _dispGroup)
        {
            _visit.Patient.DispensaryGroup = _dispGroup;
        }





        ////Добавить возможность создавать направления на обследования
        //public void MakeReferralToExamination() { } 
    }
}
