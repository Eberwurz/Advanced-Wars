﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedWars
{
    public class Type
    {
        private int mDamage;
        private int mHealth;
        private int mCost;
        private int mMovement;
        private string mName;
        private int mRadius;

        public Type(string type)
        {
            mName = type;
            mDamage = GameConstants.SHIP_DAMAGE;  
            mHealth = GameConstants.SHIP_HEALTH;       
            mCost = GameConstants.SHIP_COST;
            mMovement = GameConstants.SHIP_MOVEMENT;
            mRadius = GameConstants.SHIP_RADIUS;
            if (type == GameConstants.TYPE_BIGSHIP)
            {
                mDamage += GameConstants.BIGSHIP_DAMAGEMOD;
                mHealth += GameConstants.BIGSHIP_HEALTHMOD;
                mCost += GameConstants.BIGSHIP_COSTMOD;
                mMovement += GameConstants.BIGSHIP_MOVEMENTMOD;
                mRadius = GameConstants.BIGSHIP_RADIUSMOD;
            }

            if (type == GameConstants.TYPE_DEFENSESHIP)
            {
                mDamage += GameConstants.DEFENSE_DAMAGEMOD;
                mHealth += GameConstants.DEFENSE_HEALTHMOD;
                mCost += GameConstants.DEFENSE_COSTMOD;
                mMovement += GameConstants.DEFENSE_MOVEMENTMOD;
                mRadius = GameConstants.DEFENSE_RADIUSMOD;
            }

            if (type == GameConstants.TYPE_TRANSPORTER)
            {
                mDamage+=GameConstants.TRANSPORTER_DAMAGEMOD;
                mHealth+=GameConstants.TRANSPORTER_HEALTHMOD;
                mCost+= GameConstants.TRANSPORTER_COSTMOD;
                mMovement+=GameConstants.TRANSPORTER_MOVEMENTMOD;
                mRadius = GameConstants.TRANSPORTER_RADIUSMOD;
            }
        }

        public string Name
        {
            get { return mName; }
        }

        public int Damage
        {
            get { return mDamage; }
           
        }
        public int Radius
        {
            get { return mRadius; }

        }

        public int Health
        {
            get { return mHealth; }
            set { mHealth = value; }
        }

        public int Cost
        {
            get
            {
                return mCost;
            }

        }

        public int Movement
        {
            get
            {
                return mMovement;
            }

        }

       
    }
}
