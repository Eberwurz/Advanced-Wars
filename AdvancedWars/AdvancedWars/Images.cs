using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace AdvancedWars
{

    //Singleton Klasse zum Abrufen der Schiff Bilder
    public class Images
    {
        private static readonly Images s_Instance = new Images();

        public static Images Instance { get { return s_Instance; } }

        public const int TYPE_BIGSHIP_RED = 0;
        public const int TYPE_TRANSPORTER_RED = 1;
        public const int TYPE_DEFENSESHIP_RED = 2;
        public const int TYPE_STANDART_RED = 3;
        public const int TYPE_BIGSHIP_BLUE = 4;
        public const int TYPE_TRANSPORTER_BLUE = 5;
        public const int TYPE_DEFENSESHIP_BLUE = 6;
        public const int TYPE_STANDART_BLUE = 7;
        public const int TYPE_BIGSHIP_RED_100 = 8;
        public const int TYPE_TRANSPORTER_RED_100 = 9;
        public const int TYPE_DEFENSESHIP_RED_100 = 10;
        public const int TYPE_STANDART_RED_100 = 11;
        public const int TYPE_BIGSHIP_BLUE_100 = 12;
        public const int TYPE_TRANSPORTER_BLUE_100 = 13;
        public const int TYPE_DEFENSESHIP_BLUE_100 = 14;
        public const int TYPE_STANDART_BLUE_100 = 15;
        public const int TYPE_POWERUP_COIN = 16;
        public const int TYPE_POWERUP_HEALTH = 17;
        public const int TYPE_POWERUP_FAST = 18;
        public const int TYPE_POWERUP_SLOW = 19;
        public const int TYPE_FIELD_NORMAL = 20;
        public const int TYPE_FIELD_MOUNTAIN = 21;
        public const int TYPE_FIELD_ISLANDBLUE = 22;
        public const int TYPE_FIELD_ISLANDRED = 23;

        public const int IMAGE_COUNT = 24;

        private IDictionary<int, string> mFilenames = new Dictionary<int, string>()
    {
        {TYPE_BIGSHIP_RED, "Images\\Kanonen50rot.png"},
        {TYPE_TRANSPORTER_RED, "Images\\Kleines50rot.png"},
        {TYPE_DEFENSESHIP_RED, "Images\\Piraten50rot.png"},
        {TYPE_STANDART_RED, "Images\\Standart50rot.png"},
        {TYPE_BIGSHIP_BLUE, "Images\\Kanonen50blau.png"},
        {TYPE_TRANSPORTER_BLUE, "Images\\Kleines50blau.png"},
        {TYPE_DEFENSESHIP_BLUE, "Images\\Piraten50blau.png"},
        {TYPE_STANDART_BLUE, "Images\\Standart50blau.png"},
        {TYPE_BIGSHIP_RED_100, "Images\\GUI\\Kanonen100rot.png"},
        {TYPE_TRANSPORTER_RED_100, "Images\\GUI\\Kleines100rot.png"},
        {TYPE_DEFENSESHIP_RED_100, "Images\\GUI\\Piraten100rot.png"},
        {TYPE_STANDART_RED_100, "Images\\GUI\\Standart100rot.png"},
        {TYPE_BIGSHIP_BLUE_100, "Images\\GUI\\Kanonen100blau.png"},
        {TYPE_TRANSPORTER_BLUE_100, "Images\\GUI\\Kleines100blau.png"},
        {TYPE_DEFENSESHIP_BLUE_100, "Images\\GUI\\Piraten100blau.png"},
        {TYPE_STANDART_BLUE_100, "Images\\GUI\\Standart100blau.png"},
        {TYPE_POWERUP_COIN, "Images\\Münze50.png"},
        {TYPE_POWERUP_HEALTH, "Images\\Leben50.png"},
        {TYPE_POWERUP_FAST, "Images\\Vorspulen50.png"},
        {TYPE_POWERUP_SLOW, "Images\\zurückspulen50.png"},
        {TYPE_FIELD_NORMAL, "Images\\Wellen50.png"},
        {TYPE_FIELD_MOUNTAIN, "Images\\Felsen50.png"},
        {TYPE_FIELD_ISLANDBLUE, "Images\\InselBlau50.png"},
        {TYPE_FIELD_ISLANDRED, "Images\\InselRot50.png"}
    };

        private IDictionary<int, Bitmap> mBitaps = new Dictionary<int, Bitmap>();

        public Images()
        {
            for (int id = 0; id < IMAGE_COUNT; id++)
            {
                mBitaps.Add(id, new Bitmap(mFilenames[id]));
            }
        }

        public Bitmap GetImage(int id)
        {
            Bitmap image = null;
            mBitaps.TryGetValue(id, out image);
            return image;
        }
    }
}
