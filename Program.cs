//N. Harrison Wilkins
//10-18-2022
//Github Project Part 3 - ASKING QUESTIONS
//The console will ask the user what their name is
//Then console will repeat back a sentence repeating the given information
//PEER REVIEW IN README


Console.WriteLine("Hello, World!");
Console.Clear();

//PROJECT BEGINS
//all variables are defined below
string userName;


Console.WriteLine("GREETINGS SENTIENT ONE!");
//This is the beginning of the do while loop, regarding restarting the game
do{
    Console.WriteLine("WHAT IS YOUR NAME?");

    userName = Console.ReadLine().ToUpper();
//DATA VALIDATION,   DONT ENTER AN EMPTY STRING
    while(userName == string.Empty){
        Console.WriteLine("BE SERIOUS THIS TIME!");
        userName = Console.ReadLine().ToUpper();

    }
    Console.WriteLine("I KNEW A HUMAN BY THAT NAME.. THEY WERE CRAZY! ANYWAYS NICE TO MEET YOU " + userName + " AND THANKS FOR LOOKING AT MY PROJECT.");
    Console.WriteLine("ENTER \"Y\" TO PLAY AGAIN, OR ENTER ANY KEY TO EXIT");
//End loop on user input not meeting condition "Y"
}while(Console.ReadLine().ToUpper() == "Y");
    

