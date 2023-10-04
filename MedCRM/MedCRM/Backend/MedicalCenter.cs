
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCRM
{
    internal static class MedicalCenter
    {
        public static Employee currentUser;// = new Doctor(1, "Скрибник", "Марина", "Евгеньевна", "Врач-терапевт", "Терапия", true, "skribnik", "marina");
        public static Dictionary<string, Patient> PatientsBase { get; set; } = new Dictionary<string, Patient>()
        {
            { "Петрова Адриана Валерьевна", new Patient(21,"Петрова", "Адриана", "Валерьевна", DateTime.Parse ("18.03.1976")) },
            { "Петров Валерий Павлович", new Patient(21,"Петров", "Валерий", "Павлович", new DateTime (1976, 03, 18)) },
            { "Зайцева Светлана Ивановна", new Patient(22,"Зайцева", "Светлана", "Ивановна", new DateTime (1996,01,01)) },
            { "Валерьянов Вениамин Игоревич", new Patient(23,"Валерьянов", "Вениамин", "Игоревич", new DateTime (1956, 08, 30)) }
        };

        public static object[] Specialty { get; set; } = new object[]
        {
            "Терапия", "Хирургия", "Неврология", "Офтальмология"
        };

        public static Dictionary<string, Doctor> DoctorsBase = new Dictionary<string, Doctor>()
        {
            { "Скрибник Марина Евгеньевна", new Doctor(1, "Скрибник", "Марина", "Евгеньевна", "Врач-терапевт", "Терапия", true, "skribnik", "marina") },
            { "Черникова Ольга Андреевна", new Doctor(2, "Черникова", "Ольга", "Андреевна", "Врач-терапевт", "Терапия", false, "chernikova", "olga") },
            { "Светличный Андрей Владимирович", new Doctor(3, "Светличный", "Андрей", "Владимирович", "Врач-хирург", "Хирургия", true, "svet", "andrey") },
            { "Блинова Ольга Николаевна", new Doctor(4, "Блинова", "Ольга", "Николаевна", "Врач-невролог", "Неврология", true, "blinova", "olga") },
            { "Осокина Наталья Владимировна", new Doctor(6, "Осокина", "Наталья", "Владимировна", "Врач-невролог", "Неврология", false, "osokina", "natasha") },
            { "Горковенко Надежда Дмитриевна", new Doctor(7, "Горковенко", "Надежда", "Дмитриевна", "Врач-офтальмолог", "Офтальмология", true, "gorkovenko", "nadya") },
            { "Сартакова Жанна Анатольевна", new Doctor(8, "Сартакова", "Жанна", "Анатольевна", "Врач-офтальмолог", "Офтальмология", false, "sartakova", "zhanna") }
        };

        public static List<Visit> Visits { get; set; } = new List<Visit>()
        {
            new Visit(DoctorsBase["Скрибник Марина Евгеньевна"], PatientsBase["Петрова Адриана Валерьевна"], DateTime.Parse("19.09.2023 10:15")),
            new Visit(DoctorsBase["Скрибник Марина Евгеньевна"], PatientsBase["Зайцева Светлана Ивановна"], DateTime.Parse("19.09.2023 13:45")),
            new Visit(DoctorsBase["Скрибник Марина Евгеньевна"], PatientsBase["Валерьянов Вениамин Игоревич"], DateTime.Parse("19.09.2023 09:45")),

            new Visit(DoctorsBase["Блинова Ольга Николаевна"], PatientsBase["Валерьянов Вениамин Игоревич"], DateTime.Parse("19.09.2023 09:45")),
            new Visit(DoctorsBase["Блинова Ольга Николаевна"], PatientsBase["Зайцева Светлана Ивановна"], DateTime.Parse("19.09.2023 09:00")),
            new Visit(DoctorsBase["Блинова Ольга Николаевна"], PatientsBase["Петрова Адриана Валерьевна"], DateTime.Parse("19.09.2023 09:30")),
            new Visit(DoctorsBase["Блинова Ольга Николаевна"], PatientsBase["Валерьянов Вениамин Игоревич"], DateTime.Parse("20.09.2023 09:45")),
        };
        public static bool Contains(List<Visit> visits, Visit visit)
        {
            foreach(Visit vis in visits)
            {
                if(visit.Doctor.getFIO() == vis.Doctor.getFIO() && visit.VisitDate == vis.VisitDate
                && visit.Patient.getFIO_BD() == vis.Patient.getFIO_BD())
                {
                    return true;
                }
            }
            return false;
        }


    }
}
