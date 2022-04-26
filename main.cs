// Created by: Marshall Demars
// Created on: Apr 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program creates and prices a pizza
        const double TAX = 1.13;
        double pizzaSize;
        double sizeCost = 0;
        double toppingsCost = 0;
        double pizzaToppings;
        double totalPrice;

        Console.WriteLine("This program let's you customize a pizza and will calculate the cost");
        Console.WriteLine("");
        Console.WriteLine("Here at my pizzaria, you can have 2 sizes and upto 4 toppings");
        Console.WriteLine("");
        Console.WriteLine("Here are the sizes:");
        Console.WriteLine("Large is $6 and extra large is $10");
        Console.WriteLine("Input 6 for large and 10 for extra large:");
        pizzaSize = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");
        if (pizzaSize == 6)
        {
            sizeCost = 6;
        }

        if (pizzaSize == 10)
        {
            sizeCost = 10;
        }

        Console.WriteLine("");
        Console.WriteLine("Now choose how many toppings you want");
        Console.WriteLine("");
        Console.WriteLine("Here are the options:");
        Console.WriteLine("One toppings is $1, two is $1.75, three is $2.50 and four is $3.35");
        Console.WriteLine("Input 1 for one topping, 2 for two toppings, 3 for three toppings and 4 for four toppings:");
        pizzaToppings = Convert.ToDouble(Console.ReadLine());

        if (pizzaToppings == 1)
        {
            toppingsCost = 1.00;
        }

        if (pizzaToppings == 2)
        {
            toppingsCost = 1.75;
        }

        if (pizzaToppings == 3)
        {
            toppingsCost = 2.50;
        }

        if (pizzaToppings == 4)
        {
            toppingsCost = 3.35;
        }


        totalPrice = (toppingsCost + sizeCost) * TAX;
        Console.WriteLine("");
        Console.WriteLine("The total cost of your pizza today is $" + totalPrice.ToString("0.00") + ". Enjoy!");
        Console.WriteLine("\nDone.");
    }
}