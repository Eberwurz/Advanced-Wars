using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leveleditor
{
    public class Field
    {
        private String mType;
        private String mPowerUp;
        private String mPlayer;
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
        public Field(string type)
        {
            mType = type;
            mPowerUp = GameConstants.POWERUP_NONE;
            mPlayer = GameConstants.PLAYER_NONE;
        }
        public Field(string type, string bonus)
        {
            mType = type;
            mPowerUp = bonus;
            mPlayer = GameConstants.PLAYER_NONE;
        }
        public Field(string type, string bonus, string player)
        {
            mType = type;
            mPowerUp = bonus;
            mPlayer = player;
        }

        public void CopyValues(Field field)
        {
            mType = field.mType;
            mPlayer = field.mPlayer;
            mPowerUp = field.mPowerUp;
        }
    }
}
