using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCRM
{
    internal interface IUser
    {
        int UserID { get; set; }
        string Surname { get; set; }
        string FirstName { get; set; }
        string Patronymic { get; set; }
        DateTime DateOfBirth { get; set; }
        string Sex { get; set; }
        string Country { get; set; }
        string PostalCode { get; set; }
        string Region { get; set; }
        string City { get; set; }
        string Street { get; set; }
        string HouseNumber { get; set; }
        string FlatNumber { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        string getFIO();
        //string Login { get; set; }
        //string Password { get; set; }
    }
}
