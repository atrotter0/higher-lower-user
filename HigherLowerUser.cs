using System;
using System.Collections.Generic;

class HigherLowerUser
{
    private _max = 100;
    private _min = 1;
    private _computerChoice;
    private _userGuess;

    public void SetMax(int max)
    {
        _max = max;
    }

    public int GetMax()
    {
        return _max;
    }

    public void SetMin(int min)
    {
        _min = min;
    }

    public int GetMin()
    {
        return _min;
    }

    public void CreateComputerChoice()
    {
        Random randomNumber = new Random();
        randomNumber.next(1, 101);
        this.SetComputerChoice(randomNumber);
    }

    public void SetComputerChoice(int number)
    {
        _computerChoice = number;
    }

    public void SetUserGuess(string stringInput)
    {
        int intInput = int.Parse(stringInput);
        _userGuess = intInput;
    }

    public int GetUserGuess()
    {
        return _userGuess;
    }

    public void PromptUser()
    {
        Console.WriteLine("GUESS THE COMPUTER'S NUMBER");
        Console.WriteLine("Choose a number between " + this.GetMin() + " and " + this.GetMax() + "!");
        string input = Console.ReadLine();
    }
}

public class Program
{
    public static void Main()
    {
        HigherLowerUser newGame = new HigherLowerUser();
        newGame.PromptUser();
    }
}
