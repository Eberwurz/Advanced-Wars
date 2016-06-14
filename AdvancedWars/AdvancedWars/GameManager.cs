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
        private Point mRedBasePoint;
        private Point mBlueBasePoint;
        private int mActivePhase;
        public event ActivePlayerChangedHandler ActivePlayerChanged;

        //Gib den aktiven Spieler zurück
        public Player ActivePlayer
        {
            get
            {
                return mActivePlayer;
            }
        }

        //Gib Spielfeld zurück
        public Bitmap GameBoard
        {
            get
            {
                return mGameBoard;
            }
        }

        //Aktive Base zurückgeben
        public Point ActivePlayerBase
        {
            get
            {
                Point point = mRedBasePoint;
                if (ActivePlayer == mPlayerBlue)
                    point = mBlueBasePoint;
                return point;
            }
        }

        //Gib den roten Spieler zurück
        public Player PlayerRed
        {
            get { return mPlayerRed; }
        }

        //Gib den blauen Spieler zurück
        public Player PlayerBlue
        {
            get { return mPlayerBlue; }
        }

        //Konstruktor. Initialisiert Variabeln
        public GameManager(Bitmap GameBoard, Field[,] fields, String pRedName, String pBlueName)
        {
            mFields = fields;
            mGameBoard = GameBoard;
            mPlayerRed = new Player(pRedName, Color.Red);
            mPlayerBlue = new Player(pBlueName, Color.Blue);
            mActivePlayer = mPlayerRed;
            mActivePhase = GameConstants.PHASE_SET;
            getBasePoints();        
        }

        private void getBasePoints()
        {
            for (int y = 0; y < mFields.GetLength(1); y++)
            {
                for (int x = 0; x < mFields.GetLength(0); x++)
                {
                    if (mFields[x,y] != null)
                    {
                        if (mFields[x, y].Type == GameConstants.FIELDTYPE_BASE)
                        {
                            if (mFields[x, y].Player == GameConstants.PLAYER_RED)
                                mRedBasePoint = new Point(x * GameConstants.GAMEFIELD_TILESIZE, y * GameConstants.GAMEFIELD_TILESIZE);
                            else if (mFields[x, y].Player == GameConstants.PLAYER_BLUE)
                                mBlueBasePoint = new Point(x * GameConstants.GAMEFIELD_TILESIZE, y * GameConstants.GAMEFIELD_TILESIZE);
                        }
                    }
                }
            }
        }

        //Gibt aktive Phase zurück
        public int ActivePhase
        {
            get { return mActivePhase; }
        }

        //Wechsle die Phase
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
