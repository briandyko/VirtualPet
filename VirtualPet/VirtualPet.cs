using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //fields

        private string name;
        private int hunger;
        private int thirst;
        private int boredom;
        private int tiredness;
        private bool isSick;

        //Properties

        public string Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public int Hunger
        {
            get { return this.Hunger; }
            set { this.Hunger = value; }
        }

        public int Thirst
        {
            get { return this.Thirst; }
            set { this.Thirst = value; }
        }

        public int Boredom
        {
            get { return this.Boredom; }
            set { this.Boredom = value; }
        }

        public int Tiredness
        {
            get { return this.Tiredness; }
            set { this.Tiredness = value; }
        }

        public bool IsSick
        {
            get { return this.isSick; }
            set { this.isSick = value; }
        }

        //Constructors

        public VirtualPet()
        {

        }

        //Methods

        public void Tick()
        {

        }

        public void Feed()
        {

        }

        public void Drink()
        {

        }

        public void Sleep()
        {

        }

        public void Play()
        {

        }
    }
}
