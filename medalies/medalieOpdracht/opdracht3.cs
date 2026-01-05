using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medalieOpdracht
{
    internal class opdracht3
    {
        public void Start()
        {
            Console.Write("Wat voor weer is het vandaag? (Zonnig / Regen / Bewolkt): ");
            string inputWeer = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputWeer))
            {
                Console.WriteLine("Onbekende invoer voor het weer.");
                return;
            }

            string weer = inputWeer.Trim().ToLowerInvariant();

            if (weer != "zonnig" && weer != "regen" && weer != "bewolkt")
            {
                Console.WriteLine("Onbekende keuze voor 'weer'. Gebruik: Zonnig, Regen of Bewolkt.");
                return;
            }

            Console.Write("Wat is de temperatuur in graden Celsius? ");
            string tempInput = Console.ReadLine();
            if (!double.TryParse(tempInput, out double temperatuur))
            {
                Console.WriteLine("Ongeldige temperatuur. Gebruik alleen getallen (bijv. 18.5).");
                return;
            }

                if (weer == "zonnig")
                {
                    if (temperatuur >= 20)
                        Console.WriteLine("Je hebt geen jas nodig vandaag — geniet van de zon!");
                    else
                        Console.WriteLine("Het is fris maar zonnig — een jas is verstandig, maar zonnebrand kan alsnog!");
                }
                else if (weer == "regen")
                {
                    if (temperatuur >= 15)
                        Console.WriteLine("Het regent, maar het is warm genoeg. Neem een paraplu mee!");
                    else
                        Console.WriteLine("Regen én koud… draag warme kleding en vergeet je paraplu niet!");
                }
                else 
                {
                    if (temperatuur >= 17)
                        Console.WriteLine("Bewolkt maar aangenaam — neem voor de zekerheid een trui mee!");
                    else
                        Console.WriteLine("Bewolkt en fris — trek iets warms aan.");
                }
            }
        }
    }
