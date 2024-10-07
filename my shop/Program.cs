using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

System.Console.WriteLine("Vad heter du??");

string Namn;

Namn = Console.ReadLine();

if (Namn == "")
{
    System.Console.WriteLine("... Du har ett namn\n");
}

while (Namn == "")
{
    System.Console.WriteLine("Yu stupid, skriv ett namn");
    Console.ReadLine();
    
}
while (Namn.Length >= 7 )

{
    System.Console.WriteLine("För långt namn, orkar inte");
    Namn = Console.ReadLine();
}


int Playeraura = 100;

while (Playeraura > 0)
{

    System.Console.WriteLine("Vad vill du skaffa???");
    System.Console.WriteLine("1. Theodors gyatt (50kr)");
    System.Console.WriteLine("2. Simons matteformel (10kr)");
    System.Console.WriteLine("3. Bra skolmat (100kr)");

System.Console.WriteLine($"Du har {Playeraura} aura points kvar");

// string WhatToGet = "";
// while (WhatToGet != "1" && WhatToGet != "2" && WhatToGet != "3")
//     {   
//         System.Console.WriteLine("Dumb ass, du har inte så många rättigheter!");
//         WhatToGetGet = Console
//     }   

string choice = Console.ReadLine();
string amount = Console.ReadLine();

int itemChoice;
int itemAmount;

if(int.TryParse(choice, out itemChoice))
{
    System.Console.WriteLine("Mycket bra val!");
    System.Console.WriteLine("Hur många vill du ha???");
    if(int.TryParse(amount, out itemAmount))
    {
        System.Console.WriteLine("Strålande!!!");
    }
    else
    {
        System.Console.WriteLine("Bruh, du är för fattig");
    }
}
    else
    {
        System.Console.WriteLine("Bruh, du tror att jag säljer något som inte existerar... D;");
    }

// if (validChoice && itemChoice == 1) pricePerItem = 50;
// else if (validChoice && itemChoice == 2) PricePerItem = 10;
// else if (validChoice && itemChoice == 3) PricePerItem = 100;
 
// WhatToGet = Console.ReadLine();
// int PriceForThing = 100;

// if (WhatToGet == "1")
// {
//     PriceForThing = 50;
// }
// else if (WhatToGet == "2")
// {
//     PriceForThing = 10;
// }
// else if (WhatToGet == "3")
// {
//     PriceForThing = 100;
// }












Console.ReadLine();
}

