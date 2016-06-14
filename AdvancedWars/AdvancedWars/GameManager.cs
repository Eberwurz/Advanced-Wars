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
        private Point[] mRedBaseSpawnAreaPoints;
        private Point[] mBlueBaseSpawnAreaPoints;
        private int mActivePhase;
        private List<Ship> mShipsSetThisTurn;
        public event ActivePlayerChangedHandler ActivePlayerChanged;

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
            mShipsSetThisTurn = new List<Ship>();
        }

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
        public Point[] ActivePlaySpawnAreaPoints
        {
            get
            {
                Point[] points = mRedBaseSpawnAreaPoints;
                if (ActivePlayer == mPlayerBlue)
                    points = mBlueBaseSpawnAreaPoints;
                return points;
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

        //Sucht die Basis auf der Map
        private void getBasePoints()
        {
            for (int y = 0; y < mFields.GetLength(1); y++)
            {
                for (int x = 0; x < mFields.GetLength(0); x++)
                {
                    if (mFields[x,y] != null)
                    {
                        if (mFields[x, y].Type == GameConstants.FIELDTYPE_BASE && mFields[x,y].Player != GameConstants.PLAYER_NONE)
                        {
                            setBaseSpawnAreaPoints(mFields[x, y].Player, x, y);
                        }
                    }
                }
            }
        }

        //Speichert die Koordinaten pro Feld, in das Schiffe plaziert werden dürfen.
        private void setBaseSpawnAreaPoints(string player, int BaseX, int BaseY)
        {
            List<Point> fields = new List<Point>();
            for (int x = BaseX - 1; x<BaseX+2;x++)
            {
                for(int y = BaseY - 1; y<BaseY+2;y++)
                {
                    if (x >= 0 && x < mFields.GetLength(0) && y >= 0 && y < mFields.GetLength(1))
                    {
                        if (BaseX != x || BaseY != y)
                        {
                            fields.Add(new Point(x, y));
                        }
                    }
                }
            }
            if (player == GameConstants.PLAYER_RED)
                mRedBaseSpawnAreaPoints = fields.ToArray();
            else
                mBlueBaseSpawnAreaPoints = fields.ToArray();
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

        //Versucht ein Schiff zu plazieren. Gibt bei Erfolg true zurück.
        internal bool TrySetShip(Ship ship,int x,int y)
        {
            bool success = false;
            Point selectedPoint = new Point(x, y);  
            if(ActivePlayer.Gold >= ship.Gold)
            {
                foreach (Point p in ActivePlaySpawnAreaPoints)
                {
                    if (selectedPoint.Equals(p))
                    {
                        success = true;
                        break;
                    }
                }
                if (success)
                {
                    if (mFields[x, y].Ship == null)
                    {
                        mFields[x, y].Ship = ship;
                        ActivePlayer.Gold -= ship.Gold;
                        mShipsSetThisTurn.Add(ship);
                        drawShip(ship.Type.Name,x, y);
                    }
                    else
                        success = false;
                }
            }            
            return success;
        }

        //Setzt die Bewegungsverzögerung auf false und löscht dann die Einträge in der Schiffliste.
        private void setMoveableAndClearShipList()
        {
            foreach (Ship ship in mShipsSetThisTurn)
            {
                ship.IsMoveable = true;
            }
            mShipsSetThisTurn.Clear();
        }

        //Zeichnet ein Schiff auf die Map.
        private void drawShip(string shiptype,int x, int y)
        {
            int TileX = x * GameConstants.GAMEFIELD_TILESIZE;
            int TileY = y * GameConstants.GAMEFIELD_TILESIZE;
            int imageID = 0;
            if (ActivePlayer.Color == Color.Red)
            {
                switch(shiptype)
                {
                    case GameConstants.TYPE_STANDART:
                        imageID = Images.TYPE_STANDART_RED;
                        break;
                    case GameConstants.TYPE_TRANSPORTER:
                        imageID = Images.TYPE_TRANSPORTER_RED;
                        break;
                    case GameConstants.TYPE_DEFENSESHIP:
                        imageID = Images.TYPE_DEFENSESHIP_RED;
                        break;
                    case GameConstants.TYPE_BIGSHIP:
                        imageID = Images.TYPE_BIGSHIP_RED;
                        break;
                }    
            }else
            {
                switch (shiptype)
                {
                    case GameConstants.TYPE_STANDART:
                        imageID = Images.TYPE_STANDART_BLUE;
                        break;
                    case GameConstants.TYPE_TRANSPORTER:
                        imageID = Images.TYPE_TRANSPORTER_BLUE;
                        break;
                    case GameConstants.TYPE_DEFENSESHIP:
                        imageID = Images.TYPE_DEFENSESHIP_BLUE;
                        break;
                    case GameConstants.TYPE_BIGSHIP:
                        imageID = Images.TYPE_BIGSHIP_BLUE;
                        break;
                }
            }           
            Graphics g = Graphics.FromImage(mGameBoard);
            g.DrawImage(Images.Instance.GetImage(imageID), TileX, TileY, GameConstants.GAMEFIELD_TILESIZE, GameConstants.GAMEFIELD_TILESIZE);
            g.Dispose();
        }
    }
}
