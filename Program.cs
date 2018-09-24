using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7B
{
    class Program
    {
        static void Main(string[] args)
        {

            //build the 92nd CA BN
            HR Derek = new HR();
            Supply Trampas = new Supply();
            Medic Nikola = new Medic();
            CANCO Boomer = new CANCO();

            Console.WriteLine("welcome to the 92nd Civil Affairs Battalion (SO)(A) ");
            Console.WriteLine("Let me introdue you to some of the Soldiers at my unit. ");
            Console.WriteLine();

            //Call the soldiers
            Derek.Talk();
            Trampas.Talk();
            Nikola.Talk();
            Boomer.Talk();
         
        }

    }
}

