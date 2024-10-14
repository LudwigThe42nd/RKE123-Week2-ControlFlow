// See https://aka.ms/new-console-template for more information

//rakendus kysib kasutajalt valida tema sugu (m/f)
//rakendus kysib kasutajalt sisestada tema perekonnanime
//lahtudes kasutaja valikust, rakendus tervitab kasutajat jargmiselt:
//"Welcomr, mr. [kasutaja perekonnanimi] / "Welcome, Ns.[kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmed string formaadis

Console.WriteLine("Please enter your last name:") ;
string userLastName = Console.ReadLine();   


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName} !");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms {userLastName}");
}
else
{
    Console.WriteLine($"Welcome {userLastName}!");
}

