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
    System.Console.WriteLine("1. Theodors gyatt (50 aura points)");
    System.Console.WriteLine("2. Simons matteformel (10 aura points)");
    System.Console.WriteLine("3. Bra skolmat (100 aura points)");

System.Console.WriteLine($"Du har {Playeraura} aura points!!!");

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
        if (Playeraura >= totalcost)
        {
            System.Console.WriteLine("Ok, GYATTT");
            Playeraura -= itemAmount * 50;
            System.Console.WriteLine($"Ok, {Namn} Du har {Playeraura} kvar");
        }
        else if (Playeraura <= totalcost)
        {
            System.Console.WriteLine("Du är för fattig");
            
        }
        
    }
}

if (itemChoice == 2)
{
    System.Console.WriteLine("Mycket bra val!");
    System.Console.WriteLine("Hur många vill du ha???");
    string amount = Console.ReadLine();
    int.TryParse(amount, out itemAmount);
    {
        
        int totalcost = itemAmount * 10;
        if (Playeraura >= totalcost )
        {
            System.Console.WriteLine("Ok, nörd.");
            Playeraura -= itemAmount * 10;
            System.Console.WriteLine($"Ok, {Namn} Du har {Playeraura} kvar");
        }
        else if (Playeraura <= totalcost)
        {
            System.Console.WriteLine("Du är för fattig");
            
        }
        
    }
}

if (itemChoice == 3)
{
    System.Console.WriteLine("Mycket bra val!");
    System.Console.WriteLine("Hur många vill du ha???");
    string amount = Console.ReadLine();
    int.TryParse(amount, out itemAmount);
    {
        
        int totalcost = itemAmount * 100;
        if (Playeraura >= totalcost )
        {
            System.Console.WriteLine("Ok, Detta låter gott :D");
            Playeraura -= itemAmount * 100;
            System.Console.WriteLine($"Ok, {Namn} Du har {Playeraura} kvar");
        }
        else if (Playeraura <= totalcost)
        {
            System.Console.WriteLine("Du är för fattig");
            
        }    
    }
}



Console.ReadLine();
}










