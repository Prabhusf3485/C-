using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineDose
{
    //enum for gender
    public enum Gender
    {
        male, female, others
    }
    class BeneficiaryDetails
    {
        //autoincrementing the id 
        private static int count = 1000;
        public int Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public Gender GendeR { get; set; }
        public long PhoneNumber { get; set; }
        public string City { get; set; }

        //list for vaccine details
        public List<Vaccination> VaccineDetails

        {
            get; set;
        }


        public BeneficiaryDetails(string beneficaryName, int age, Gender gender, long phoneNumber, string city)
        {
            this.Name = beneficaryName;
            this.Age = age;
            this.GendeR = gender;
            this.PhoneNumber = phoneNumber;
            this.City = city;
            this.Id = count;
            count++;

        }

    }
}