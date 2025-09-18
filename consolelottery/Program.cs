using System;

class Program
{
    static void Main()
    {
        // vi skapar en array 
        int[] lotter = new int[5];
        // vi ger användaren 5 försök för att skriva ett lottnummer
        int loopcount = 0;
        Console.WriteLine("Skriv 5 nummer mellan 1 till 50!");
        while (loopcount < 5)
        {
            if ((int.TryParse(Console.ReadLine(), out int number)) && (number < 51 && number > 0) && ArrayCheck(number, lotter))
            {
                lotter[loopcount] = number;
                loopcount++;
            }
            else
            {
                Console.WriteLine("FEL! Försök igen!");
            }
        }

        Console.WriteLine();
        // programmet väljer 3 random nummer och skriver de i en array
        int[] vinnarlotter = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Random nyRandomInstans = new Random();

            bool loopCheck = false;
            do
            {
                int newNumber = nyRandomInstans.Next(1, 50);
                if (ArrayCheck(newNumber, vinnarlotter))
                {
                    vinnarlotter[i] = newNumber;
                    loopCheck = true;
                    break;
                }
            }
            while (loopCheck == false);

            vinnarlotter[i] = nyRandomInstans.Next(1, 50);
            Console.WriteLine(vinnarlotter[i]);
        }
        Console.WriteLine();


        //vi jämför vinnarlotter med lotter och kollar om användaren har vunnit eller inte
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {

                if (vinnarlotter[i] == lotter[j])
                {
                    Console.WriteLine(" Yay! Du vann ");

                }
                else
                {
                    Console.WriteLine("Du vann inte!");
                }

            }
        }
        //hur många vinster?? 

        /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(lotter[i]);
            }
            */

    }
    static bool ArrayCheck(int newNumber, int[] arrayToCheck)
    {
        for (int i = 0; i < arrayToCheck.Length; i++)
        {
            if (newNumber == arrayToCheck[i])
            {
                return false;
            }
        }
        return true;
    }
}
