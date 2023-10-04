using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCRM
{
    internal abstract class Employee : ABaseUser
    {
        public Employee(int _id, string _surname, string _firstName, string _patronymic, string _post)
            : base(_id, _surname, _firstName, _patronymic) 
        {
            Post = _post;
            //Login = _surname;
            //Password = _firstName;
        }
        public Employee(int _id, string _surname, string _firstName, string _patronymic, DateTime _dateOfBirth, string _sex, string _country,
            string _postalCode, string _region, string _city, string _street, string _houseNumber, string _flatNumber,
            string _phone, string _email) : base(_id, _surname, _firstName, _patronymic, _dateOfBirth, _sex, _country,
            _postalCode, _region, _city, _street, _houseNumber, _flatNumber, _phone, _email) { }
        public string Post { get; set; }
        
    }
}
