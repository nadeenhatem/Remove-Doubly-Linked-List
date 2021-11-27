using System;
using System.Collections.Generic;
//a class called program is defined
public class program
{
    // Main Method is called
    static public void Main()
    {
       
        LinkedList<String> list = new LinkedList<String>();
        //AddLast() method is used to add the elements 
        list.AddLast("Nadeen");
        list.AddLast("Hatem");
        list.AddLast("El_Abd");
       
        Console.WriteLine("My name is:");
       
        foreach (string i in list)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine("My name after using Remove() method are:");
        
        list.Remove("Nadeen");
        foreach (string i in list)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("My name after using RemoveFirst() method are:");
        
        list.RemoveFirst();
        foreach (string i in list)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("my name after using RemoveLast() method are:");
    
        list.RemoveLast();
        foreach (string i in list)
        {
            Console.WriteLine(i);
        }
       
    }
}