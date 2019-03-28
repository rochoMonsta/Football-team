using System;
namespace Homework1
{
    public class Player
    {
        public Player() { }

        private string name;
        private int number;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Number
        {
            get { return number; }
            set {  if (value > 0) { number = value; } }
        }

    }
}
