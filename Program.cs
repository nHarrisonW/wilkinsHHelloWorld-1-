//N. Harrison Wilkins
//10-18-2022
//Github Project Part 3 - ASKING QUESTIONS
//The console will ask the user what their name is and what time they woke up
//Then console will repeat back a sentence repeating the given information


Console.WriteLine("Hello, World!");
Console.Clear();

//PROJECT BEGINS
//all variables are defined below
string time, userName;


Console.WriteLine("GREETINGS SENTIENT ONE!");
//This is the beginning of the do while loop, regarding restarting the game (playAgain)
do{
    Console.WriteLine("WHAT IS YOUR NAME?");

    userName = Console.ReadLine().ToUpper();

    Console.WriteLine("I KNEW A HUMAN BY THAT NAME.. THEY WERE CRAZY! SO WHAT TIME DID YOU WAKE UP?");

    time = Console.ReadLine();

    Console.WriteLine("GEEZ, "+ userName + ", " + time + " SURE IS EARLY!");

    Console.WriteLine("PRESS \"Y\" TO CONTINUE, OR ANY OTHER KEY TO EXIT");

    }
    //End loop on user input not meeting condition "Y"
    while(Console.ReadLine().ToUpper() == "Y");

