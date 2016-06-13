using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace AdvancedWars
{
    public delegate void ActivePlayerChangedHandler();
    public class GameManager
    {
        private Field[,] mFields;
        private Player mPlayerRed;
        private Player mPlayerBlue;
        private Bitmap mGameBoard;
        private Player mActivePlayer;
        private int mActivePhase;
        public event ActivePlayerChangedHandler ActivePlayerChanged;

        public Player ActivePlayer
        {
            get
            {
                return mActivePlayer;
            }
        }

        public Bitmap GameBoard
        {
            get
            {
                return mGameBoard;
            }
        }

        public Player PlayerRed
        {
            get { return mPlayerRed; }
        }

        public Player PlayerBlue
        {
            get { return mPlayerBlue; }
        }

        public GameManager(Bitmap GameBoard, Field[,] fields, String pRedName, String pBlueName)
        {
            mFields = fields;
            mGameBoard = GameBoard;
            mPlayerRed = new Player(pRedName, Color.Red);
            mPlayerBlue = new Player(pBlueName, Color.Blue);
            mActivePlayer = mPlayerRed;
            mActivePhase = GameConstants.PHASE_SET;           
        }

        public int ActivePhase
        {
            get { return mActivePhase; }
        }

        internal void nextPhase()
        {
            mActivePhase++;
            if(mActivePhase == 3)
            {
                if (mActivePlayer == mPlayerRed)
                    mActivePlayer = mPlayerBlue;
                else
                    mActivePlayer = mPlayerRed;             
                mActivePhase = GameConstants.PHASE_SET;
                ActivePlayerChanged();
            }
        }
    }
}
