using System;
using System.Collections.Generic;

class HigherLowerUser
{
    private _max = 100;
    private _min = 1;
    private _computerChoice;
    private _userGuess;

    public void SetMax(max)
    {
        _max = max;
    }

    public void GetMax()
    {
        return _max;
    }

    public void SetMin(min)
    {
        _min = min;
    }

    public void GetMin()
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
}

public class Program
{
    public static void Main()
    {

    }
}
