﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace AdvancedWars
{
    public delegate void GameManagerChangedHandler();
    public class GameManager
    {
        private Field[,] mFields;
        private Player mPlayerRed;
        private Player mPlayerBlue;
        private Bitmap mGameBoard;
        private Player mActivePlayer;
        private Point[] mRedBaseSpawnAreaPoints;
        private Point[] mBlueBaseSpawnAreaPoints;
        private Point[] mShipMovementAreaPoints;
        private Point[] mShipCombatAreaPoints;
        private Point mSelectedFieldPoint;
        private int mActivePhase;
        private int mRound;
        public event GameManagerChangedHandler ActivePlayerChanged;
        public event GameManagerChangedHandler GameOver;
        

        //Konstruktor. Initialisiert Variabeln
        public GameManager(Bitmap GameBoard, Field[,] fields, String pRedName, String pBlueName)
        {
            mFields = fields;
            mGameBoard = GameBoard;
            mPlayerRed = new Player(pRedName, Color.Red);
            mPlayerBlue = new Player(pBlueName, Color.Blue);
            mActivePlayer = mPlayerRed;
            mActivePhase = GameConstants.PHASE_SET;
            mRound = 0;
            getBasePoints();
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

        //Aktive Base zurückgeben
        public Point[] ShipMovementAreaPoints
        {
            get
            {
                return mShipMovementAreaPoints;
            }
        }

        //Aktive Base zurückgeben
        public Point[] ShipCombatAreaPoints
        {
            get
            {
                return mShipCombatAreaPoints;
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
                mRound++;
                mActivePlayer.ResetShips();
                if (mActivePlayer == mPlayerRed)
                    mActivePlayer = mPlayerBlue;
                else
                    mActivePlayer = mPlayerRed;
                mActivePhase = GameConstants.PHASE_SET;
                ActivePlayerChanged();
                if(mRound == 2)
                {
                    spawnPowerUps();
                    mRound = 0;
                }              
            }
        }

        private void spawnPowerUps()
        {
            string[] powerUps = new string[] { GameConstants.POWERUP_GOLD, GameConstants.POWERUP_SLOW, GameConstants.POWERUP_SPEED, GameConstants.POWERUP_HEALTH };
            Random random = new Random((int)DateTime.Now.Ticks);
            for (int i=0; i<3; i++)
            {
                int powerUp = random.Next(0, powerUps.Length);
                int fieldX = random.Next(0, mFields.GetLength(0));
                int fieldY = random.Next(0, mFields.GetLength(1));
                int value = 0;
                if (powerUps[powerUp]== GameConstants.POWERUP_GOLD)
                {
                    value = random.Next(1, GameConstants.MAXRANDOMDROP_GOLD);
                }
                if (powerUps[powerUp] == GameConstants.POWERUP_HEALTH)
                {
                    value = random.Next(10, GameConstants.MAXRANDOMDROP_HEALTH);
                }
                
                if (mFields[fieldX,fieldY].PowerUp == GameConstants.POWERUP_NONE)
                {
                    mFields[fieldX, fieldY].PowerUp = powerUps[powerUp];
                    mFields[fieldX, fieldY].PowerUpValue = value;                  
                }else
                {   //Wird ein Feld getroffen, dass ein PowerUp hat, wird dieses entfernt.
                    mFields[fieldX, fieldY].PowerUp = GameConstants.POWERUP_NONE;
                    mFields[fieldX, fieldY].PowerUpValue = 0;
                }
                updateFieldImage(mFields[fieldX, fieldY], fieldX, fieldY);
            }           
        }

        //Versucht ein Schiff zu plazieren. Gibt bei Erfolg true zurück.
        internal bool TrySetShip(Ship ship,int x,int y)
        {
            bool success = false;
            if(ship != null)
            {
                Point selectedPoint = new Point(x, y);
                if (ActivePlayer.Gold >= ship.Type.Cost)
                {
                    if (ActivePlaySpawnAreaPoints.Contains(selectedPoint))
                    {
                        if (mFields[x, y].Ship == null)
                        {
                            mFields[x, y].Ship = ship;
                            ActivePlayer.Gold -= ship.Type.Cost;
                            ActivePlayer.AddShip(ship);
                            Graphics g = Graphics.FromImage(mGameBoard);
                            drawShip(mFields[x,y],g, x * GameConstants.GAMEFIELD_TILESIZE, y * GameConstants.GAMEFIELD_TILESIZE);
                            g.Dispose();
                            success = true;
                        }
                    }
                }
            }            
            return success;
        }

        public Ship getSelectedShip()
        {
            return mFields[mSelectedFieldPoint.X, mSelectedFieldPoint.Y].Ship;
        }

        //Gibt zurück, ob am angeklickten Punkt ein Schiff des aktiven Spielers ist, dass bewegt werden kann. Wenn ja setzt es die Bereiche
        public bool ActivePlayersShipClicked(Point p)
        {
            bool success = false;
            if(mFields[p.X,p.Y].Ship != null)
            {
                if(mFields[p.X, p.Y].Ship.ControllingPlayer == mActivePlayer)
                {
                    if (mActivePhase == GameConstants.PHASE_MOVE)
                    {
                        if (mFields[p.X, p.Y].Ship.IsMoveable)
                        {
                            success = true;
                            mSelectedFieldPoint = p;
                            setMovementAreaPoints(p);
                        }
                    }
                    else if (mActivePhase == GameConstants.PHASE_FIGHT)
                    {
                        if (mFields[p.X, p.Y].Ship.CanAttack)
                        {
                            success = true;
                            mSelectedFieldPoint = p;
                            setCombatAreaPoints(p);
                        }
                    } 
                }
            }
            return success;
        }

        //Setzt den Bereich um ein Schiff in der Angriffsphase
        private void setCombatAreaPoints(Point p)
        {
            int radius = mFields[p.X, p.Y].Ship.Type.Radius;
            List<Point> fields = new List<Point>();
            for (int x = p.X - radius; x <= p.X + radius; x++)
            {
                for (int y = p.Y - radius; y <= p.Y + radius; y++)
                {
                    if (x >= 0 && x < mFields.GetLength(0) && y >= 0 && y < mFields.GetLength(1))
                    {
                        if(p.X != x || p.Y != y)
                            fields.Add(new Point(x, y));
                    }
                }
            }
            mShipCombatAreaPoints = fields.ToArray();
        }

        //Setzt den Bereich den ein Schiff in der Bewegungssphase fahren kann.
        private void setMovementAreaPoints(Point p)
        {
            int movement = mFields[p.X, p.Y].Ship.Type.Movement;
            if(mFields[p.X,p.Y].PowerUp == GameConstants.POWERUP_SLOW)
            {
                movement -= 1;
            }else if(mFields[p.X, p.Y].PowerUp == GameConstants.POWERUP_SPEED)
            {
                movement += 2;
            }
            List<Point> fields = new List<Point>();
            for (int x = p.X; x <= p.X + movement; x++)
            {
                if (x >= 0 && x < mFields.GetLength(0))
                {
                    if (mFields[x, p.Y].Type == GameConstants.FIELDTYPE_BLOCKADE)
                        break;
                    fields.Add(new Point(x, p.Y));
                }
            }
            for (int x = p.X - 1; x >= p.X - movement; x--)
            {
                if (x >= 0 && x < mFields.GetLength(0))
                {
                    if (mFields[x, p.Y].Type == GameConstants.FIELDTYPE_BLOCKADE)
                        break;
                    fields.Add(new Point(x, p.Y));
                }
            }
            for (int y = p.Y + 1; y <= p.Y + movement; y++)
            {
                if (y >= 0 && y < mFields.GetLength(1))
                {
                    if (mFields[p.X, y].Type == GameConstants.FIELDTYPE_BLOCKADE)
                        break;
                    fields.Add(new Point(p.X, y));
                }
            }
            for (int y = p.Y - 1; y >= p.Y - movement; y--)
            {
                if (y >= 0 && y < mFields.GetLength(1))
                {
                    if (mFields[p.X, y].Type == GameConstants.FIELDTYPE_BLOCKADE)
                        break;
                    fields.Add(new Point(p.X, y));
                }
            }
            mShipMovementAreaPoints = fields.ToArray();
        }

        public bool TryMoveShip(Point p)
        {
            bool success = false;
            Field selectedField = mFields[mSelectedFieldPoint.X, mSelectedFieldPoint.Y];

            if (mShipMovementAreaPoints.Contains(p))
            {
                if ((mFields[p.X,p.Y].Ship) == null && selectedField.Ship != null)
                {
                    if (ActivePlaySpawnAreaPoints.Contains(p))
                    {
                        ActivePlayer.Gold += selectedField.Ship.Gold;
                        selectedField.Ship.Gold = 0;
                    }
                    if(mFields[p.X,p.Y].PowerUp == GameConstants.POWERUP_GOLD)
                    {
                        selectedField.Ship.Gold += mFields[p.X, p.Y].PowerUpValue;
                        mFields[p.X, p.Y].PowerUp = GameConstants.POWERUP_NONE;
                        mFields[p.X, p.Y].PowerUpValue = 0;
                    }
                    else if(mFields[p.X, p.Y].PowerUp == GameConstants.POWERUP_HEALTH)
                    {
                        selectedField.Ship.Type.Health += mFields[p.X, p.Y].PowerUpValue;
                        mFields[p.X, p.Y].PowerUp = GameConstants.POWERUP_NONE;
                        mFields[p.X, p.Y].PowerUpValue = 0;
                    }
                    mFields[p.X, p.Y].Ship = selectedField.Ship;
                    selectedField.Ship = null;
                    mFields[p.X, p.Y].Ship.IsMoveable = false;
                    //update image TODO
                    updateFieldImage(mFields[p.X, p.Y], p.X, p.Y);
                    updateFieldImage(selectedField, mSelectedFieldPoint.X, mSelectedFieldPoint.Y);

                    success = true;
                } 
            }
            return success;
        }

        //Versucht ein Gegnerisches Schiff anzugreifen. Gibt True zurück, wenn ein gegnerisches Schiff oder das eigene Schiff angeklickt wurde.
        public bool TryAttackShip(Point p)
        {
            bool success = false;
            Field selectedField = mFields[mSelectedFieldPoint.X, mSelectedFieldPoint.Y];
            if (mShipCombatAreaPoints.Contains(p))
            {
                if(mFields[p.X,p.Y].Ship != null)
                {
                    if(mFields[p.X,p.Y].Ship.ControllingPlayer != ActivePlayer)
                    {
                        mFields[p.X, p.Y].Ship.Type.Health = mFields[p.X, p.Y].Ship.Type.Health - selectedField.Ship.Type.Damage;
                        if(!mFields[p.X, p.Y].Ship.Alive)
                        {
                            mFields[p.X, p.Y].PowerUp = GameConstants.POWERUP_GOLD;
                            mFields[p.X, p.Y].PowerUpValue = Convert.ToInt32(mFields[p.X, p.Y].Ship.Gold * 0.5) + Convert.ToInt32(mFields[p.X, p.Y].Ship.Type.Cost/2);
                            Player opponent = mPlayerRed;
                            if (mActivePlayer == mPlayerRed)
                                opponent = mPlayerBlue;
                            opponent.RemoveShip(mFields[p.X, p.Y].Ship);
                            mFields[p.X, p.Y].Ship = null;
                            updateFieldImage(mFields[p.X, p.Y], p.X,p.Y);
                        }
                        success = true;
                        selectedField.Ship.CanAttack = false;
                    }
                }
                else if(mFields[p.X,p.Y].Type == GameConstants.FIELDTYPE_BASE)
                {
                    string color = GameConstants.PLAYER_BLUE;
                    Player pl = mPlayerBlue;
                    if(ActivePlayer.Color == Color.Blue)
                    {
                        color = GameConstants.PLAYER_RED;
                        pl = mPlayerRed;
                    }
                    if(mFields[p.X,p.Y].Player == color)
                    {
                        pl.Health = pl.Health - selectedField.Ship.Type.Damage;
                        if(!pl.isAlive())
                        {
                            //gameover
                            GameOver();
                        }
                        success = true;
                        selectedField.Ship.CanAttack = false;
                    }                    
                }
            }
            else
            {
                if (selectedField == mFields[p.X,p.Y])
                {
                    //bricht Auswahl ab!
                    success = true;
                }
            }
            return success;
        }
        //Updated das Feld an der Stelle x, y
        private void updateFieldImage(Field field, int x, int y)
        {
            Graphics g = Graphics.FromImage(mGameBoard);
            int TileX = x * GameConstants.GAMEFIELD_TILESIZE;
            int TileY = y * GameConstants.GAMEFIELD_TILESIZE;
            drawField(field,g, TileX, TileY);
            drawPowerUp(field, g, TileX, TileY);
            drawShip(field, g, TileX, TileY);
            renderRaster(g);
            
            g.Dispose();
        }
        //Zeichnet das Feld
        private void drawField(Field field,Graphics g, int x, int y)
        {
            int imageID = 0;
            switch (field.Type)
            {
                case GameConstants.FIELDTYPE_NORMAL:
                    imageID = Images.TYPE_FIELD_NORMAL;
                    break;
                case GameConstants.FIELDTYPE_BLOCKADE:
                    imageID = Images.TYPE_FIELD_MOUNTAIN;
                    break;
                case GameConstants.FIELDTYPE_BASE:
                    if (field.Player == GameConstants.PLAYER_RED)
                        imageID = Images.TYPE_FIELD_ISLANDRED;
                    else
                        imageID = Images.TYPE_FIELD_ISLANDBLUE;
                    break;
            }
            g.DrawImage(Images.Instance.GetImage(imageID), x, y, GameConstants.GAMEFIELD_TILESIZE, GameConstants.GAMEFIELD_TILESIZE);
        }
        //Zeichnet das PowerUp
        private void drawPowerUp(Field field, Graphics g, int tileX, int tileY)
        {
            int imageID = 0;
            switch (field.PowerUp)
            {
                case GameConstants.POWERUP_GOLD:
                    imageID = Images.TYPE_POWERUP_COIN;
                    break;
                case GameConstants.POWERUP_NONE:
                    return;
                case GameConstants.POWERUP_SPEED:
                    imageID = Images.TYPE_POWERUP_FAST;
                    break;
                case GameConstants.POWERUP_SLOW:
                    imageID = Images.TYPE_POWERUP_SLOW;
                    break;
                case GameConstants.POWERUP_HEALTH:
                    imageID = Images.TYPE_POWERUP_HEALTH;
                    break;
            }
            g.DrawImage(Images.Instance.GetImage(imageID), tileX, tileY, GameConstants.GAMEFIELD_TILESIZE, GameConstants.GAMEFIELD_TILESIZE);
        }

        //Zeichnet ein Schiff auf die Map.
        private void drawShip(Field field, Graphics g, int x, int y)
        {
            if (field.Ship != null)
            {
                int imageID = 0;
                if (ActivePlayer.Color == Color.Red)
                {
                    switch (field.Ship.Type.Name)
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
                }
                else
                {
                    switch (field.Ship.Type.Name)
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
                g.DrawImage(Images.Instance.GetImage(imageID), x, y, GameConstants.GAMEFIELD_TILESIZE, GameConstants.GAMEFIELD_TILESIZE);
            }
        }

        //Zeichnet das Raster
        private void renderRaster(Graphics a)
        {
            Pen pen = new Pen(Color.Black, 2);
            //Möglicherweise überholen wenn veränderbare Feldgröße
            for (int x = GameConstants.GAMEFIELD_TILESIZE; x < GameConstants.GAMEFIELD_WIDTH; x = x + GameConstants.GAMEFIELD_TILESIZE)
            {
                a.DrawLine(pen, x, 0, x, GameConstants.GAMEFIELD_HEIGHT);
            }
            for (int y = GameConstants.GAMEFIELD_TILESIZE; y < GameConstants.GAMEFIELD_HEIGHT; y = y + GameConstants.GAMEFIELD_TILESIZE)
            {
                a.DrawLine(pen, 0, y, GameConstants.GAMEFIELD_WIDTH, y);
            }
        }
    }
}
