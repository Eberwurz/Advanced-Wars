using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedWars
{
    public class Type
    {
        private int mDamage;
        private int mHealth;
        private int mDefense;
        private int mCost;
        private int mMovement;

        public Type(string type)
        {
            mDamage = GameConstants.SHIP_DAMAGE;  
            mHealth = GameConstants.SHIP_HEALTH;       
            mDefense = GameConstants.SHIP_DEFENSE;
            mCost = GameConstants.SHIP_COST;
            mMovement = GameConstants.SHIP_MOVEMENT;
            if (type == GameConstants.TYPE_BIGSHIP)
            {
                mDamage += GameConstants.BIGSHIP_DAMAGEMOD;
                mHealth += GameConstants.BIGSHIP_HEALTHMOD;
                mDefense += GameConstants.BIGSHIP_DEFENSEHMOD;
                mCost += GameConstants.BIGSHIP_COSTMOD;
                mMovement += GameConstants.BIGSHIP_MOVEMENTMOD;
            }

            if (type == GameConstants.TYPE_DEFENSESHIP)
            {
                mDamage += GameConstants.DEFENSE_DAMAGEMOD;
                mHealth += GameConstants.DEFENSE_HEALTHMOD;
                mDefense += GameConstants.DEFENSE_DEFENSEHMOD;
                mCost += GameConstants.DEFENSE_COSTMOD;
                mMovement += GameConstants.DEFENSE_MOVEMENTMOD;
            }

            if (type == GameConstants.TYPE_TRANSPORTER)
            {
                mDamage+=GameConstants.TRANSPORTER_DAMAGEMOD;
                mHealth+=GameConstants.TRANSPORTER_HEALTHMOD;
                mDefense+=GameConstants.TRANSPORTER_DEFENSEHMOD;
                mCost+= GameConstants.TRANSPORTER_COSTMOD;
                mMovement+=GameConstants.TRANSPORTER_MOVEMENTMOD;
            }
        }

        public int Damage
        {
            get { return mDamage; }
           
        }

        public int Health
        {
            get { return mHealth; }
            set { mHealth = value; }
        }

        public int Defense
        {
            get { return mDefense; }
            
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
