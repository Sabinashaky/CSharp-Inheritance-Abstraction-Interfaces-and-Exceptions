//1.Program to Show Inheritance in C#
using System;

class Animal
{
    public void Sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();

        d.Sound();
        d.Bark();
    }
}