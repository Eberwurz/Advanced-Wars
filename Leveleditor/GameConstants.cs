using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leveleditor
{
    public class GameConstants
    {
        public const string TYPE_NORMAL = "normal";
        public const string TYPE_BASE = "base";
        public const string TYPE_BLOCKADE = "blockade";

        public const int FIELD_SIZE = 50;
        public const int FIELD_WIDTH = 12;
        public const int FIELD_HEIGHT = 10; 

        public const string POWERUP_NONE = "";
        public const string POWERUP_SPEED = "speed";
        public const string POWERUP_SLOW = "slow";

        public const string PLAYER_RED = "red";
        public const string PLAYER_BLUE = "blue";
        public const string PLAYER_NONE = "";

    }
}
