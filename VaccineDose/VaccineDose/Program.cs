using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineDose
{

    class VaccinationCamp
    {

        private static List<BeneficiaryDetails> Beneficary = new List<BeneficiaryDetails>();


        static void Main(string[] args)
        {
            VaccinationCamp vaccination = new VaccinationCamp();
            // 
            var firstperson = new BeneficiaryDetails("prabhu", 18, Gender.male, 7904617468, "vedaraniam");
            var secondperson = new BeneficiaryDetails("arun", 23, Gender.male, 7373172722, "chennai");
            var thirdperson = new BeneficiaryDetails("raj", 30, Gender.male, 9807654321, "erode");
            Beneficary.Add(firstperson);
            Beneficary.Add(secondperson);
            Beneficary.Add(thirdperson);
            string yesorno;

            do
            {
                Console.WriteLine("----------WELCOME TO VACCINATION CAMP----------");
                Console.WriteLine("1.BENEFICIARY REGISTRATION \n2.VACINNATION \n3.EXIT");
                Console.WriteLine("SELECT THE OPTION");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        vaccination.Registration();
                        break;
                    case 2:
                        vaccination.Vaccination();
                        break;
                    case 3:
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("ENTER THE VALID OPTION");
                        break;

                }
                Console.WriteLine("Do you want Continue (yes/no)?");
                yesorno = Console.ReadLine();
            } while (yesorno == "yes");

        }
        public void Registration()
        {
            Console.WriteLine("--------BENEFICIARY REGISTRATION-------");
            
            Console.WriteLine("ENTER YOUR NAME");
            
            string name = Console.ReadLine();
            Console.WriteLine("ENTER YOUR AGE");
           
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER YOUR GENDER - \n1.MALE \n2.FEMALE \n3.OTHER");
            
            Gender gend = (Gender)int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER YOUR PHONE NUMBER");
            
            long phoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("ENTER YOUR CITY");
           
            string city = Console.ReadLine();

            var newData = new BeneficiaryDetails(name, age, (Gender)gend, phoneNumber, city);
            Beneficary.Add(newData);
            Console.WriteLine($"your registration id is {newData.Id}");
            Console.WriteLine("----------------------------------------------------------");
        }
        public void Vaccination()
        {
            Console.WriteLine("ENTER THE REGISTRATION ID ");

            Console.WriteLine("");
            int id = int.Parse(Console.ReadLine());
            string select;
            foreach (BeneficiaryDetails data in Beneficary)
            {
                if (id == data.Id)
                {
                    do
                    {


                        Console.WriteLine("---------VACCINATION---------");
                        Console.WriteLine("");
                        Console.WriteLine("1.TAKE VACCINATION \n2.VACCINATION HISTORY \n3.NEXT DUE DATE");
                        Console.WriteLine("SELECT THE OPTION");
                        Console.WriteLine("");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("1.Covid-Shield \n2.Covaccin \n3.sputnic");
                                Console.WriteLine("Which Dose you want?");
                                Console.WriteLine("");
                                Vaccine vacType = (Vaccine)int.Parse(Console.ReadLine());

                                Vaccination user = new Vaccination(DateTime.Now,vacType );
                                if (data.VaccineDetails == null)
                                {

                                    data.VaccineDetails = new List<Vaccination>();
                                }
                                data.VaccineDetails.Add(user);

                                Console.WriteLine("Successfully vaccinated!...");
                                Console.WriteLine("-------------------------------------------------------------------------");
                                break;
                            case 2:
                                foreach (BeneficiaryDetails history in Beneficary)
                                {
                                    if (history.VaccineDetails != null)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine($"RegisterNo: {history.Id} \nName: {history.Name} \nVaccinated Dose: {history.VaccineDetails[0]}");
                                        Console.WriteLine("---------------------------------------------------------------------");
                                    }
                                }
                                break;

                            case 3:

                                foreach (BeneficiaryDetails Duedate in Beneficary)
                                {
                                    if (Duedate.VaccineDetails != null)
                                    {
                                        if (Duedate.VaccineDetails.Count == 1)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("You are vaccinated by " + Duedate.VaccineDetails[0].VType);
                                            Console.WriteLine("Your next Due Date: " + Duedate.VaccineDetails[0].Date.AddDays(30));
                                            Console.WriteLine("---------------------------------------------------------------------");

                                        }
                                        else if (Duedate.VaccineDetails.Count == 2)
                                        {
                                            Console.WriteLine("You have completed the vaccination course. Thanks for your participation in the vaccination drive.");
                                            Console.WriteLine("---------------------------------------------------------------------");
                                        }
                                    }
                                }

                                    break; 
                            case 4:
                                Environment.Exit(-1);
                                break;
                            default:
                                Console.WriteLine("ENTER THE VALID OPTION");
                                Console.WriteLine("");
                                break;

                        }
                        Console.WriteLine("Do you want Continue (yes/no)?");
                        Console.WriteLine("");
                        select = Console.ReadLine();
                    } while (select == "yes");

                }
            }

        }


    }
}