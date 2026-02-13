
using Microsoft.VisualBasic;

namespace TransportApp
    {
        public class Driver
        {
            public int Id {  get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
            public string LicenseNumber { get; set; }
            public Driver(string firstName, string lastName, DateTime birthDate, string licenseNumber)
            {
                FirstName = firstName;
                LastName = lastName;
                BirthDate = birthDate;
                LicenseNumber = licenseNumber;
            }

        public int GetAge()
        {
            DateTime now = DateTime.Today;
            int age = now.Year - BirthDate.Year;

            if (BirthDate > now.AddYears(-age))
                age--;
            return age;
        }
        }
    }
