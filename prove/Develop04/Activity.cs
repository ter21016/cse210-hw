using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Activity
{
    static void Main(string[] args)
    {
        Console.WriteLine("We!");
    }

    private string _name;
    private string _description;
    private int _duration;

    public Activity (string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

    }
    public void  DisplayStartingMessage()
    {
        Console.WriteLine ($"Welcome to {_name} activity: \n");
         
         
    }
   
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well Done!");
    }
     

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i <)
    }
     public void showCountDown(int seconds)
     {

     }

}