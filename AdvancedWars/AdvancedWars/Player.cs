using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedWars
{
    public class Player
    {
        private int mGold;
        private string mName;
        private int mShipMoved;

        public Player(string name)
        {
            mGold = GameConstants.PLAYER_STARTINGGOLD;
            mName = name;
            mShipMoved=0;
        }

        public int Gold
        {
            get { return mGold; }
            set { mGold = value; }
        }

        public string Name
        {
            get { return mName; }
        }

        public int ShipMoved
        {
            get { return mShipMoved; }
            set { mShipMoved = value; }
        }
    }
}
