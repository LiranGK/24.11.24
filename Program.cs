﻿using kys;
internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Student s1 = new Student(1, "Ariel" , 'e' , "A3");
        s1.SetGrade(88);
        string write=s1.ToString();
        Console.WriteLine(write);

        Student s2 = new Student(2, "Eyal" , 'f' , "A3");
        s2.SetGrade(94);
        write = s2.ToString();
        Console.WriteLine(write);

        if (s1.BestGrade(s2))
        {
            Console.WriteLine(s1.name + " has a higher grade");
        }
        else
        {
            Console.WriteLine(s2.name + " has a higher grade");
        }
    }
}