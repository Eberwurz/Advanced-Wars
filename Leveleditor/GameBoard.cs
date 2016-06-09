using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leveleditor
{
    class GameBoard
    {
        private Field[,] mFields;
        private int mWidth;
        private int mHeight;
        private Point mRedBase;
        private Point mBlueBase;

        //Bitmaps
        private Bitmap mGameBoardImage;
        private Bitmap mImageRaster;

        private Bitmap mImageNormal;
        private Bitmap mImageBase;
        private Bitmap mImageBaseRed;
        private Bitmap mImageBaseBlue;
        private Bitmap mImageMountain;

        private Bitmap mImageBoost;
        private Bitmap mImageSlow;
        //------------------
        //Konstruktoren
        //------------------

        //TODO Startbild laden
        public GameBoard(int width, int height)
        {
            mWidth = width;
            mHeight = height;
            mFields = new Field[width, height];
            initPictures();
            initFields();
            mRedBase =new Point(-1, -1);
            mBlueBase =new Point(-1, -1);
        }

        private void initPictures()
        {
            try
            {
                mGameBoardImage = new Bitmap(600,500);
                mImageBase= new Bitmap("Images\\Island.png");
                mImageBaseRed = new Bitmap("Images\\IslandRed.png");
                mImageBaseBlue = new Bitmap("Images\\IslandBlue.png");
                mImageNormal = new Bitmap("Images\\Wellen50.png");
                mImageMountain = new Bitmap("Images\\Riff.png");
                mImageBoost = new Bitmap("Images\\Boost.png");
                mImageSlow = new Bitmap("Images\\Slow.png");
                mImageRaster = new Bitmap("Images\\GUI\\Gitter.png");
                mImageRaster.MakeTransparent(Color.White);
                mImageBoost.MakeTransparent(Color.White);
                mImageSlow.MakeTransparent(Color.White);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Bilder konnten nicht geladen werden!","Fehler");
            }
            
        }

        //------------------
        //GETTER UND SETTER
        //------------------

        public Bitmap GameBoardImage
        {
            get { return mGameBoardImage; }
        }

        public Field[,] Fields
        {
            get
            {
                return mFields;
            }
        }

        public Field GetField(int x, int y)
        {
            Field field = null;
            if (x >= 0 && x < mWidth)
            {
                if (y >= 0 && y < mHeight)
                {
                    field = mFields[x, y];
                }
            }
            return field;
        }

        public bool TrySetField(Field selectedField, int x, int y)
        {
            bool success = false;
            if (mFields[x, y].Type != GameConstants.TYPE_BASE && mFields[x, y].Player == GameConstants.PLAYER_NONE)
            {
                if (x >= 0 && x < mWidth)
                {
                    if (y >= 0 && y < mHeight)
                    {
                        Fields[x, y].CopyValues(selectedField);
                        if(selectedField.Player != GameConstants.PLAYER_NONE)
                            setBasePoint(x,y, selectedField.Player);
                        updateGameBoardImage(mFields[x, y], x, y);
                        success = true;
                    }
                }
            }
            return success;
        }

        private void setBasePoint(int x,int y, string color)
        {
            if(color == GameConstants.PLAYER_RED)
            {
                if(mRedBase.X != -1)
                {
                    mFields[mRedBase.X, mRedBase.Y] = new Field(GameConstants.TYPE_NORMAL);
                    updateGameBoardImage(mFields[mRedBase.X, mRedBase.Y], mRedBase.X, mRedBase.Y);
                }                 
                mRedBase = new Point(x, y);
            }else if(color == GameConstants.PLAYER_BLUE)
            {
                if (mBlueBase.X != -1)
                {
                    mFields[mBlueBase.X, mBlueBase.Y] = new Field(GameConstants.TYPE_NORMAL);
                    updateGameBoardImage(mFields[mBlueBase.X, mBlueBase.Y], mBlueBase.X, mBlueBase.Y);
                }
                mBlueBase = new Point(x, y);
            }
        }

        //------------------
        //Methoden
        //------------------

        private void updateGameBoardImage(Field field, int x, int y)
        {
            //Geh an die Stelle x, y und ersetze das dortige Feld mit passendem Image zu Field
            Bitmap fieldImage = getFieldImage(field);
            Graphics a = Graphics.FromImage(mGameBoardImage);
            a.DrawImage(fieldImage, x*GameConstants.FIELD_SIZE, y*GameConstants.FIELD_SIZE,GameConstants.FIELD_SIZE,GameConstants.FIELD_SIZE);
            RenderRaster(a);
            a.Dispose();
        }

        private void RenderRaster(Graphics a)
        {
            //Möglicherweise überholen wenn veränderbare Feldgröße
            a.DrawImage(mImageRaster, 0, 0);
        }

        private Bitmap getFieldImage(Field field)
        {
            Bitmap img = new Bitmap(50, 50);
            img = (Bitmap)mImageNormal.Clone();
            //TODO Boosts auf nicht erreichbaren Objekten
            bool boostAvailable = true;
            switch(field.Type)
            {
                case GameConstants.TYPE_BLOCKADE:
                    img = (Bitmap)mImageMountain.Clone();
                    break;
                case GameConstants.TYPE_BASE:
                    if(field.Player == GameConstants.PLAYER_BLUE)
                        img = (Bitmap)mImageBaseBlue.Clone();
                    else if (field.Player == GameConstants.PLAYER_RED)
                        img = (Bitmap)mImageBaseRed.Clone();
                    else
                        img = (Bitmap)mImageBase.Clone();
                    boostAvailable = false;
                    break;   
            }
            if (boostAvailable)
            {
                Bitmap boost = null;
                if (field.PowerUp != GameConstants.POWERUP_NONE)
                {
                    if (field.PowerUp == GameConstants.POWERUP_SLOW)
                        boost = mImageSlow;
                    else
                        boost = mImageBoost;
                    Graphics g = Graphics.FromImage(img);
                    g.DrawImage(boost, 0, 0);
                }
            }              
            return img;
        }

        private void initFields()
        {
            for (int x = 0; x < mWidth; x++)
            {
                for (int y = 0; y < mHeight; y++)
                {
                    mFields[x, y] = new Field(GameConstants.TYPE_NORMAL, GameConstants.POWERUP_NONE);
                    updateGameBoardImage(mFields[x, y], x, y);
                }
            }
        }

        public bool SaveGameBoard(string path, string name)
        {
            bool success = true;
            try
            {
                string directoryPath = path + "\\map";
                Directory.CreateDirectory(directoryPath);
                //Aktuelles GameBoard
                mGameBoardImage.Save(directoryPath + "\\GameBoard.bmp");
                //XMLPart
                xmlWriter writer = new xmlWriter(directoryPath);
                writer.WriteXMLFile(mFields, name);
            }catch(Exception ex)
            {
                success = false;
            }
            return success;
        }
    }
}
