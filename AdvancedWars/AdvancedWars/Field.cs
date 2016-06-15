using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedWars
{
    public class Field
    {
        private String mType;
        private String mPowerUp;
        private String mPlayer;
        private Ship mShip;
        private int mPowerUpValue;

        //Konstruktoren
        public Field(string type)
        {
            mType = type;
            mPowerUp = GameConstants.POWERUP_NONE;
            mPlayer = GameConstants.PLAYER_NONE;
            mShip = null;
            mPowerUpValue = 0;
        }
        public Field(string type, string bonus)
        {
            mType = type;
            mPowerUp = bonus;
            mPlayer = GameConstants.PLAYER_NONE;
            mShip = null;
            mPowerUpValue = 0;
        }
        public Field(string type, string bonus, string player)
        {
            mType = type;
            mPowerUp = bonus;
            mPlayer = player;
            mShip = null;
            mPowerUpValue = 0;
        }

        public int PowerUpValue
        {
            get
            {
                return mPowerUpValue;
            }
            set
            {
                mPowerUpValue = value;
            }
        }

        public string Player
        {
            get
            {
                return mPlayer;
            }
            set
            {
                mPlayer = value;
            }
        }
        public string Type
        {
            get
            {
                return mType;
            }
            set
            {
                mType = value;
            }
        }
        public Ship Ship
        {
            get
            {
                return mShip;
            }
            set
            {
                mShip = value;
            }
        }
        public string PowerUp
        {
            get
            {
                return mPowerUp;
            }
            set
            {
                mPowerUp = value;
            }
        }
        //Kopiermethode
        public void CopyValues(Field field)
        {
            mType = field.mType;
            mPlayer = field.mPlayer;
            mPowerUp = field.mPowerUp;
            mShip = field.mShip;
            mPowerUpValue = field.mPowerUpValue;
        }
    }
}
