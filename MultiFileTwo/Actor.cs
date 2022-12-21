using System;
using System.Collections.Generic;
using System.Text;

namespace MultiFileTwo
{
    internal class Actor
    {
        private string _name;
        private string _movie;

        public Actor(string Name, string Movie)
        {
            _name = Name;
            _movie = Movie;
        }

        public string Name { 
            get { return _name; } 
            set { _name = value; }
        }

        public string Movie {
            get { return _movie; }
            set { _movie = value; }
        }

        public void Display()
        {
            Console.WriteLine("{0} appeared in the movie '{1}.'",this._name,this._movie);
        }
    }
}
