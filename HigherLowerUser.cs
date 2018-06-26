using System;
using System.Collections.Generic;

class HigherLowerUser
{
    private int _max = 100;
    private int _min = 1;
    private int _computerChoice;
    private int _userGuess;
    private bool _guessedCorrect = false;

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

    public void GetComputerChoice()
    {
        return _computerChoice;
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

    public void SetGuessedCorrect(bool guess)
    {
        _guessedCorrect = guess;
    }

    public bool GetGuessedCorrect()
    {
        return _guessedCorrect;
    }

    public void PromptUser()
    {
        Console.WriteLine("GUESS THE COMPUTER'S NUMBER");
        Console.WriteLine("To guess my number, enter a number between " + this.GetMin() + " and " + this.GetMax() + "!");
        string input = Console.ReadLine();
        this.SetUserGuess(input);
    }

    public void CheckInput()
    {
        if (this.GetUserGuess() == this.GetComputerChoice())
        {
            Console.WriteLine(this.GetUserGuess() + " is my number! You guessed right!");
            this.SetGuessedCorrect(true);
        }
        else if (this.GetUserGuess() > this.GetComputerChoice())
        {
            Console.WriteLine("Your guess is too high... go lower!");
        }
        else if (this.GetUserGuess() < this.GetComputerChoice())
        {
            Console.WriteLine("Your guess is too low... go higher!");
        }
        else
        {
            Console.WriteLine("I have no idea what you mean...");
        }
    }
}

public class Program
{
    public static void Main()
    {
        HigherLowerUser newGame = new HigherLowerUser();
        
        while(!newGame.GetGuessedCorrect())
        {
            newGame.PromptUser();
            newGame.CheckInput();
        }
    }
}
