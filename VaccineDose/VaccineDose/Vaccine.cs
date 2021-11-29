using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineDose
{
    //enum for vaccine
    public enum Vaccine
    {
        covaxin, covisheild, Sputnic
    }

    class Vaccination
    {
        private static string covaxin;
        private static string covisheild;
        private static string Sputnic;


        public int Dosage { get; set; }
        public DateTime Date { get; set; }
        public Vaccine VType { get; set; }
        private static int Count = 1;

        public Vaccination(DateTime date, Vaccine type)
        {
            this.Date = date;
            this.VType = type;
        }

    }
}
