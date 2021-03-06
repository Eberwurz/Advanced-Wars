﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedWars
{
    public class Ship
    {
        public Ship(Type Type,Player player) 
        {
            mType = Type;
            mGold = 0;
            mIsMoveable = false;
            mCanAttack = false;
            mControllingPlayer = player;
        }
        private Type mType;
        private int mGold;
        private bool mIsMoveable;
        private bool mCanAttack;
        private Player mControllingPlayer; 

        public bool Alive
        {
            get { return mType.Health > 0; }
        }

        public bool CanAttack
        {
            get { return mCanAttack; }
            set { mCanAttack = value; }
        }

        public Player ControllingPlayer
        {
            get { return mControllingPlayer; }
        }

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
            mIsMoveable = ship.mIsMoveable;
            mCanAttack = ship.mCanAttack;
            mControllingPlayer = ship.mControllingPlayer;
    }


    }
}
