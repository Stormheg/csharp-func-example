using System;
using System.Collections.Generic;
using System.Linq;
namespace FuncVoorbeeld
{
    public class Som
    {
        public int getal1;
        public int getal2;
        
        // 1. Deze regel wil zeggen dat de variabele 'Optellen' van type Func een functie kan bevatten die 2 integers als parameters meekrijgt
        // en een integer returnt (de INT in Func<int, int, INT>, het laatste type is altijd de return value!)
        // 2. We wijzen de Func `Optellen` meteen een waarde toe: namelijk een lamda functie die twee getallen optelt (getal a en getal b, de parameters)
        // Opmerking: dit is de uitgebreide lambda syntax met { }
        public Func<int, int, int> Optellen = (a, b) => {
            return a + b;
        };
        // verkorte lambda vanaf hier, zonder de extra haakjes (alles staat op dezelfde regel)
        public Func<int, int, int> Aftrekken = (a, b) => a - b;
        public Func<int, int, int> Vermenigvuldigen = (a, b) => a * b;
        
        // Met een cast naar integer, want Math.Pow (machtsverheffen) returnt een double
        public Func<int, int, int> Machtsverheffen = (a, b) => (int)Math.Pow(a, b);


        public Som(int getal1, int getal2)
        {
            this.getal1 = getal1;
            this.getal2 = getal2;
        }

        public void RekenUit(Func<int, int, int> uitrekenFunctie)
        {
            // Hier gaan we de uitrekenFunctie parameter gebruiken.
            int uitkomst = uitrekenFunctie(getal1, getal2);
            Console.WriteLine($"Berekening a: {getal1}, b: {getal2}; Uitkomst = {uitkomst}");
        }

    }
}