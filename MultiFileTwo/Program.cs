using System;
using System.Collections.Generic;

namespace MultiFileTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Actor> actors = new List<Actor> {
                new Actor("Gene Hackman", "The Poseidon Adventure"),
                new Actor("Ally Sheedy", "War Games")
            }; 
            //Add your Object for your new Classes here

            Console.WriteLine("Hello Class!\n");

            actors.Add(new Actor("Richard Dreyfuss", "Close Encounters of the Third Kind" ));
            for (int i = 0; i < actors.Count; i++) {
                actors[i].Display();
            }
            Console.WriteLine("---------------------------");

            //Add your additional object to your list here as well as the printing of your objects
        }
    }
}
