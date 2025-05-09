﻿using System.Dynamic;


int robotNumber = 1;
while (true)
{
    dynamic robot = new ExpandoObject();
    robot.ID = robotNumber;
    string input = "";
    Console.WriteLine($"You are producing robot #{robotNumber}");
    Console.Write("Do you want to name this robot? ");
    if (Console.ReadLine() == "yes")
    {
        Console.Write("What is its name? ");
        robot.Name = Console.ReadLine();
    }

    Console.Write("Does this robot have a specific size? ");
    if (Console.ReadLine() == "yes")
    {
        Console.Write("What is its height? ");
        robot.Height = int.Parse(Console.ReadLine());
        Console.Write("What is its width? ");
        robot.Width = int.Parse(Console.ReadLine());
    }
    Console.Write("Does this robot need to be a specific color? ");
    if (Console.ReadLine() == "yes")
    {
        Console.Write("What is its color? ");
        robot.Color = Console.ReadLine();

    }

    foreach (KeyValuePair<string, object> property in (IDictionary<string, object>)robot)
        Console.WriteLine($"{property.Key}: {property.Value}");
    robotNumber++;




}