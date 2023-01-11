using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class King : IName
    {
        public King()
        {

        }
        public King(string n)
        {
            this.Name = n;
        }

        public string Name { get; set; }
        public event EventHandler UnderAttack;
        public void OnUnderAttack()
        {
            Console.WriteLine($"King {this.Name} is under attack!");
            UnderAttack?.Invoke(this, new EventArgs());
        }
    }
}
