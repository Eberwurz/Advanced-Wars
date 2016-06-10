using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace AdvancedWars
{
    public class Player
    {
        private int mGold;
        private string mName;
        private int mShipMoved;
        private Color mColor;

        public Player(string name, Color color)
        {
            mGold = GameConstants.PLAYER_STARTINGGOLD;
            mName = name;
            mShipMoved=0;
            mColor = color;
        }

        public Color Color
        {
            get { return mColor; }
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
