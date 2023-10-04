using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCRM
{
    internal class Patient : ABaseUser
    {
        public Patient(int _id, string _surname, string _firstName, string _patronymic, DateTime _dateOfBirth)
            : base(_id, _surname, _firstName, _patronymic) 
        {
            MedicalHistory = new List<MedicalReport>();
            DateOfBirth = _dateOfBirth;
        }
        public Patient(int _id, string _surname, string _firstName, string _patronymic, DateTime _dateOfBirth, string _sex, string _country,
            string _postalCode, string _region, string _city, string _street, string _houseNumber, string _flatNumber,
            string _phone, string _email) : base(_id, _surname, _firstName, _patronymic, _dateOfBirth, _sex, _country,
            _postalCode, _region, _city, _street, _houseNumber, _flatNumber, _phone, _email)
        {
            MedicalHistory = new List<MedicalReport>();
        }
        public string getFIO_BD()
        {
            return getFIO() + ", " + DateOfBirth.ToString("dd.MM.yyyy");
        }
        public List<MedicalReport> MedicalHistory { get; }
        public string MainDiagnosis { get; set; }
        public string MainDiagnosisMKB { get; set; }
        public string DispensaryGroup { get; set; }


    }
}
