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
        public Field(string type, string bonus)
        {
            mType = type;
            mPowerUp = bonus;
        }
    }
}
