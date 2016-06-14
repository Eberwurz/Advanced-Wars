using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedWars
{
    public class Ship
    {
        public Ship(Type Type) 
        {
            mType = Type;
            mGold = Type.Cost;
        }
        private Type mType;
        private int mGold;
        private bool mIsMoveable;

        public bool IsMoveable
        {
            get { return mIsMoveable; }
            set { mIsMoveable = value; }
        }

        public int Gold
        {
            get{return mGold;}
            set{mGold=value;}
        }

        public Type Type
        {
            get { return mType; }
        }

        //Klonmethode
        public void clone(Ship ship)
        {
            mType = ship.mType;
            mGold = ship.mGold;
            mIsMoveable = false;
        }


    }
}
