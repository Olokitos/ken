﻿using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public int Weight { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        Console.WriteLine("Enter the persons name: 'done' to finish.");

        while (true)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            if (name.ToLower() == "done")
                break;

            Console.Write("Weight: ");
            int weight = int.Parse(Console.ReadLine());

            people.Add(new Person { Name = name, Weight = weight });
        }

        Console.WriteLine("\nPeople and their weights:");
        int totalWeight = 0;
        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name}, Weight: {person.Weight}");
            totalWeight += person.Weight;
        }

        Console.WriteLine($"\nTotal weight of all people: {totalWeight}");

        Console.ReadLine();
    }
}