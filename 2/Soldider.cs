using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public abstract class Soldier : IName
    {
        public Soldier(string n)
        {
            Name = n;
        }
        public string Name { get; set; }
        public abstract void KingUnderAttack(object sender, EventArgs e);
    }
}
