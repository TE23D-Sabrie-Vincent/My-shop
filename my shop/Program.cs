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
System.Console.WriteLine($"Hejsan svejsan {Namn} till min fina skibidi shop");


int Playeraura = 100;

while (Playeraura > 0)
{
    System.Console.WriteLine($"Du har {Playeraura} kvar");
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

string Choice = Console.ReadLine();

int itemChoice;
int itemAmount;

int.TryParse(Choice, out itemChoice);

if(itemChoice > 3)
{

    System.Console.WriteLine("Nej det får du inte köpa, vet du varför? För att den FINNS INTE");
}


if (itemChoice == 1)
{
    System.Console.WriteLine("Mycket bra val!");
    System.Console.WriteLine("Hur många vill du ha???");
    string amount = Console.ReadLine();
    int.TryParse(amount, out itemAmount);
    {
        
        int totalcost = itemAmount * 50;
        if (totalcost >= 0 )
        {
            System.Console.WriteLine("Ok, koolt");
            Playeraura -= itemAmount * 50;
            System.Console.WriteLine($"Ok, {Namn} Du har {Playeraura} kvar");
        }
        if (totalcost <= 0)
        {
            System.Console.WriteLine("Du är för fattig");
            
        }
        
    }
    
    //     System.Console.WriteLine("Strålande!!!\n");
    //     System.Console.WriteLine("Hur många vill du ha??");
    //     amount = Console.ReadLine();
    //     int.TryParse(itemAmount, out amount);
    //     int totalcost = itemAmount*50;

    // }

}

// if (totalcost <= Playeraura)
// {

// } 
   
    
    //     if (totalcost <= 0) 
    // {
        
    //     System.Console.WriteLine("Bruh, du är för fattig");
    // }

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

