using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedWars
{
    class Ship
    {
        public Ship(Type Type) 
        {
            mType = Type;
            mGold = Type.Cost;
        }
        public Type mType;
        public int mGold;

        public int Gold
        {
            get{return mGold;}
            set{mGold=value;}
        }

        public Type Type
        {
            get { return mType; }
        }


    }
}
