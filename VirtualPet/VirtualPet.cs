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

        private bool isHungry;
        private bool isThirsty;
        private bool isBored;
        private bool isSick;

        //Properties

        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

        public bool IsThirsty
        {
            get { return this.isThirsty; }
            set { this.isThirsty = value; }
        }

        public bool IsBored
        {
            get { return this.isBored; }
            set { this.isBored = value; }
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

        public static void Tick()
        {

        }

        public static void Feed()
        {

        }

        public static void Drink()
        {

        }

        public static void Sleep()
        {

        }
    }
}
