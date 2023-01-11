using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class RoyalGuard : Soldier
    {
        public RoyalGuard(string n) : base(n)
        {
            this.Name = n;
        }

        public override void KingUnderAttack(object sender, EventArgs e)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
