using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCRM
{
    internal class ABaseUser : IUser
    {
        public int UserID { get; set; }
        private string surname;
        public string Surname 
        { 
            get { return surname; }
            set
            {
                if (value != string.Empty) { surname = value; }
                else { throw new ArgumentException("Поле \"Фамилия\" не заполнено"); }
            }
        }
        private string firstName;
        public string FirstName 
        { 
            get { return firstName; }
            set 
            { 
                if (value != string.Empty) { firstName = value; }
                else { throw new ArgumentException("Поле \"Имя\" не заполнено"); }
            }
        }
        private string patronymic;
        public string Patronymic 
        { 
            get { return patronymic; }
            set
            {
                if (value != string.Empty) { patronymic = value; }
                else { throw new ArgumentException("Поле \"Отчество\" не заполнено"); }
            }
        }
        private DateTime dateOfBirth;
        public DateTime DateOfBirth 
        { 
            get { return dateOfBirth; } 
            set
            {
                if (value < DateTime.Today) { dateOfBirth = value; }
                else { throw new ArgumentException("Проверьте корректность поля \"Дата рождения\""); }
            }
        }
        public string Sex { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        //private string login;
        public string Login { get; set; }
        //{ 
        //    get { return login; }
        //    set
        //    {
        //        if (value.Length >= 8) { login = value; }
        //        else { throw new ArgumentException("Логин должен содержать не менее 8 символов"); }
        //    }
        //}
        //private string password;
        public string Password { get; set; }
        //{
        //    get { return password; }
        //    set
        //    {
        //        if (value.Length >= 8) { password = value; }
        //        else { throw new ArgumentException("Логин должен содержать не менее 8 символов"); }
        //    }
        //}
        public ABaseUser(int _id, string _surname, string _firstName, string _patronymic)
        {
            Surname = _surname;
            FirstName = _firstName;
            Patronymic = _patronymic;
            UserID = _id;
        }
        public ABaseUser(int _id, string _surname, string _firstName, string _patronymic, DateTime _dateOfBirth, string _sex, string _country,
            string _postalCode, string _region, string _city, string _street, string _houseNumber, string _flatNumber,
            string _phone, string _email) : this(_id, _surname, _firstName, _patronymic)
        {
            DateOfBirth = _dateOfBirth;
            Sex = _sex;
            Country = _country;
            PostalCode = _postalCode;
            Region = _region;
            City = _city;
            Street = _street;
            HouseNumber = _houseNumber;
            FlatNumber = _flatNumber;
            Phone = _phone;
            Email = _email;
        }
        public string getFIO()
        {
            return $"{Surname} {FirstName} {Patronymic}";
        }
        
    }
}
