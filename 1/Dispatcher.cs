using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    // Делегат на методи для івенту 
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);
    public class Dispatcher
    {
        string? name;

       
        public event NameChangeEventHandler? NameChange;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
                OnNameChange(new NameChangeEventArgs(value));

            }
        }

        // Виклик
        public void OnNameChange(NameChangeEventArgs args)
        {
            this.NameChange(this, args);
        }
    }
}
