using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTutorial
{
    internal class Hund
    {
        // Felder
        private string _name;
        private byte _alter;    // Wertebereich von 0 bis 255


        // Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))    // Meldung ausgeben bei Leerstring oder null
                {
                    Console.WriteLine("Name darf nicht leer oder null sein!");
                }
                else
                {
                    _name = value;
                }
            }
        }


        public byte Alter  // Wertebereich von 0 bis 255
        {
            get
            {
                return _alter;
            }
            set
            {
                if (value > 50) // maximales Alter ist 50
                {
                    Console.WriteLine("Wert für Alter zu groß (max. 50)");
                }
                else
                {
                    _alter = value;
                }
            }
        }



        // Methoden
        // Methode, die Wuff auf der Konsole ausgibt
        public void Bellen()
        {
            Console.WriteLine($"Der Hund {_name} bellt!");
            Console.WriteLine("Wuff!!");
        }
    }
}