using my_home;
using System;

public class Program
{
    static void Main(string[] args)
    {
        MyHome ben = new MyHome("Joseph", 22, "Software Engineer", 183, 59, false);

        ben.bilgileriGoster();

        Console.ReadLine();
    }
}