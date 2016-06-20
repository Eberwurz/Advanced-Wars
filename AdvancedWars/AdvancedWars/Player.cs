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
        private int mHealth;
        private List<Ship> mShips;

        public Player(string name, Color color)
        {
            mGold = GameConstants.PLAYER_STARTINGGOLD;
            mName = name;
            mShipMoved=0;
            mColor = color;
            mHealth = GameConstants.BASEHEALTH;
            mShips = new List<Ship>();
        }

        public void AddShip(Ship s)
        {
            mShips.Add(s);
        }

        public void RemoveShip(Ship s)
        {
            if (mShips.Contains(s))
            {
                mShips.Remove(s);
            }
        }

        public void ResetShips()
        {
            foreach (Ship ship in mShips)
            {
                if(ship !=null)
                {
                    ship.IsMoveable = true;
                    ship.CanAttack = true;
                }
            }
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

        public int Health
        {
            get { return mHealth; }
            set { mHealth = value; }
        }

        public bool isAlive()
        {
            return mHealth > 0;
        }
    }
}
