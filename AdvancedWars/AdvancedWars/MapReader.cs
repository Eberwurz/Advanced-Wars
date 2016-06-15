using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;

namespace AdvancedWars
{
    class MapReader
    {
        private string mXMLName;
        private string mBitmapName;
        private string mLoadPath;
        private string mMapName;
        private Field[,] mFields;
        private Bitmap mBitmap;

        public string MapName
        {
            get { return mMapName; }
        }

        public Field[,] Fields
        {
            get { return mFields; }
        }

        public Bitmap Bitmap
        {
            get { return mBitmap; }
        }

        public MapReader(string path)
        {
            mLoadPath = path;
            mMapName = "";
            mXMLName = "\\xmlConfig.xml";
            mBitmapName = "\\GameBoard.bmp";
        }

        //Läd das XML aus dem Verzeichnis. Gibt bei Erfolg true zurück
        public bool TryLoadXMLFromPath()
        {
            bool success = true;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(mLoadPath + mXMLName);
                XmlNode gameField = doc.SelectSingleNode("/GameField");
                mMapName = gameField.Attributes.GetNamedItem("Name").InnerText;
                XmlNode size = doc.SelectSingleNode("/GameField/Size");
                int y = Convert.ToInt32(size.Attributes.GetNamedItem("Columns").InnerText);
                int x = Convert.ToInt32(size.Attributes.GetNamedItem("Rows").InnerText);
                mFields = new Field[x, y];
                XmlNode fields = doc.SelectSingleNode("/GameField/Fields");
                int acX = 0;
                int acY = 0;
                foreach (XmlNode child in fields.ChildNodes)
                {
                    if (child.LocalName == "Field")
                    {
                        mFields[acX, acY] = new Field(child.Attributes.GetNamedItem("Type").InnerText, child.Attributes.GetNamedItem("PowerUps").InnerText, child.Attributes.GetNamedItem("Player").InnerText);
                        acX++;
                        if (acX == x)
                        {
                            acX = 0;
                            acY++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                success = false;
                Console.WriteLine(ex.Message);
            }
            return success;
        }

        //Läd die Bitmap im Verzeichnis. Gib bei Erfolg true zurück
        public bool TryLoadBitmap()
        {
            bool success = true;
            try
            {
                mBitmap = new Bitmap(mLoadPath + mBitmapName);
            }catch (Exception ex)
            {
                success = false;
                Console.WriteLine(ex.Message);
            }
            return success;
        }
    }
}
