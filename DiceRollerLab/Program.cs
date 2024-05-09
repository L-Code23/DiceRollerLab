// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;
using System.Numerics;
using System.Threading.Channels;

/*For 6-sided dice, the application recognizes the following dice combinations and displays a message for each. 
 * It should not output this for any other size of dice.*/

 bool runProgram = true;
bool validNumber = true;
Console.WriteLine("Welcome to Fox Woods Casino!");

while (runProgram)
{
    
       
        Random rnd = new Random();
        Console.WriteLine("Enter the number of sides for a pair of dice.");
        int dice = int.Parse(Console.ReadLine());


        






        int dice1 = rollDice(dice);
        int dice2 = rollDice(dice);
        int addTotal = diceTotal(dice, dice);
        string combinations = Combinations(dice, dice);

        if (dice != 6)
        {
            Console.WriteLine($"You rolled a {dice1} and a {dice2} Total {diceTotal(dice1, dice2)}");

        }
        else if (dice == 6)
        {
            Console.WriteLine($"You rolled a {dice1} and a {dice2} Total {diceTotal(dice1, dice2)}");
            Console.WriteLine(Combinations(dice1, dice2));
        }
    }
   
    //Console.WriteLine($"{dice2}");
    //Console.WriteLine($"Total: {diceTotal(dice,dice)}");

    Console.WriteLine("Do you want to roll again?");
    string input = Console.ReadLine();
    if (input == "y")
    {
        runProgram = true;
    }
    else
    {
        runProgram = false;
    }






//methods




Console.WriteLine();
static int rollDice(int dice)
{
    Random rnd = new Random();
    {
        
        return rnd.Next(1, dice);

    }
}

static int diceTotal(int rollDice1, int rollDice2)
{
    int total = 0;
    total = rollDice1 + rollDice2;
    return total;
}
static string Combinations ( int dice1, int dice2)
{
    if(dice1 == 1 && dice2==1 )
            {
        return "Snake Eyes";
    }
   else if (dice1== 1 && dice2 ==2 || dice1 == 2 && dice2== 2)
    {
        return "Ace Duce";
    }
    else if(dice1 == 6 && dice2 == 6)
    {
        return "Box Cars";
    }
    else if (dice1 + dice2 == 7 || dice1 + dice2 == 11)
     {
        return "Win!";
    }
    else if (dice1+dice2 == 2 || dice1 + dice2 ==3 || dice1 + dice2 == 12)
    {
        return "Craps";
    }
    else
    {
        return "ya broke!";
    }
}

//Valid totals method
static string validTotals (int dice1, int dice2)
{
    if(dice1 + dice2 == 7 || dice1 + dice2 == 11)
    {
        return "Win!";
    }
    else if (dice1 + dice2 == 2 || dice1 + dice2 == 3 || dice1 + dice2 == 12)
    {
        return "Win!";
    }
    else
    {
        return "No soup for you!";
    }
}