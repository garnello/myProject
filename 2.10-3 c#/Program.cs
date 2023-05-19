using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace laba
{
    public class Program
    {
        public static void Main()
        {
            List<Buyer> buyers = new List<Buyer>()
            {
                new Buyer("Igor", "Stipov", "Alexerich", 12, 75478475295883),
                new Buyer("Timofey", "Gurzo", "Alexendrovich", 23234, 75478475295883),
                new Buyer("Daniil", "Alexo", "Petrovich", 1234567, 75478475295883),
                new Buyer("Tim", "Genir", "Pedro", 23234, 75478475295883),
                new Buyer("Dany", "Yank", "Ryslanovich", 1234567, 75478475295883),
            };

            while (true)
            {
                Console.Write("Enter action: \n" +
                              "1. Show all buyer collection.\n" +
                              "2. Show all buyer in the sorted collection.\n" +
                              "3. Show number of credit card on diapason.\n" +
                              "4. Exit.\n" +
                              "Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        foreach (var buyer in buyers)
                            buyer.ShowAllBuyers();
                        break;
                    
                    case 2:
                        Buyer.SortedAllBuyers(buyers);
                        break;
                    
                    case 3:
                        foreach (var buyer in buyers)
                        {
                            buyer.CreditCardOnDiapason();
                            break;
                        }
                        break;
                    
                    case 4:
                        return;
                        break;
                }
            }
        }
    }
}