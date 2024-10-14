// See https://aka.ms/new-console-template for more information


//rakendus kysib kasutajal sisestada tema vanuse
//kui kasutaja vanus on vaiksem kui 13, siis konsoolis kuvatakse 
//"You are too young to use this application"
//muul juhul
//konsoolis kuvatakse "Welcome to instagram"

using System.ComponentModel.Design;

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.tryprase(userAgeNum, out userAgeNum);

Console.WriteLine($"Prase result {isAgeNumber}. user is {userAgeNum} years old.");

//int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack    
if(isAgeNumber == true)

if (userAge >= 13)
        else
         {
                Console.WriteLine("you are too young to use this application!");
         }
    else
    {
        Console.WriteLine("Unable to confirm your age");
    }
