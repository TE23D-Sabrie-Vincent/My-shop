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
}

while (Namn.Length >= 7 )
{
    System.Console.WriteLine("För långt namn, orkar inte");
    Namn = Console.ReadLine();
}

int Playercash = 100;

while (Playercash > 0)
{
    System.Console.WriteLine("Vad vill du skaffa???");
}