using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Uzdevumi
{
    class Kalkulators
    {
        public void Funkcijas()
        {

            int izvele = 1;
            while (izvele != 0)
            {

                Console.WriteLine("1: Saskaita 2: Atnem 3: Reizina 4: Dala 5: Kapina (0: Iziet)");
                izvele = Convert.ToInt16(Console.ReadLine());

                
                    Console.WriteLine("Ievadiet 1. skaitli!");
                      double pirmais = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("Ievadiet 2. skaitli!");
                     double otrais = Convert.ToInt16(Console.ReadLine());
                
                
                

                switch (izvele)
                {
                    case 0:

                        break;

                    case 1:
                        Console.WriteLine(Saskaita(pirmais, otrais));

                        break;
                    case 2:
                        Console.WriteLine(Atnem(pirmais, otrais));

                        break;

                    case 3:
                        Console.WriteLine(Reizina(pirmais, otrais));

                        break;
                    case 4:
                        Console.WriteLine(Dala(pirmais, otrais));
                        break;
                    case 5:
                        Console.WriteLine(Kapina(pirmais, otrais));

                        break;

                    default:
                        Console.WriteLine("Nepareiza ievade!");
                        break;
                }
            }
        }

        private double Saskaita(double a, double b)
        {
            double rezultats = a + b;
            return rezultats;
        }

        private double Atnem(double a, double b)
        {
            double rezultats = a - b;
            return rezultats;
        }

        private double Reizina(double a, double b)
        {
            double rezultats = a * b;
            return rezultats;
        }

        private double Dala(double a, double b)
        {
            double rezultats = a / b;
            return rezultats;
        }

        private double Kapina(double a, double b) // a ir skaitlis, b ir kapinatajs
        {
            double result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
                
            }
            return result;
        }

        


       
      

    }
}
