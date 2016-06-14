using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedWars
{
    public class GameConstants
    {
        public const int PLAYER_STARTINGGOLD = 100;

        public const string TYPE_BIGSHIP = "Bigship";
        public const string TYPE_TRANSPORTER = "Transporter";
        public const string TYPE_DEFENSESHIP = "Defense";
        public const string TYPE_STANDART = "Standart";

        public const int SHIP_HEALTH = 100;
        public const int SHIP_MOVEMENT = 4;
        public const int SHIP_COST = 25;
        public const int SHIP_DAMAGE = 50;

        public const int BIGSHIP_HEALTHMOD = 10;
        public const int BIGSHIP_MOVEMENTMOD = -2;
        public const int BIGSHIP_COSTMOD = 15;
        public const int BIGSHIP_DAMAGEMOD = 50;

        public const int TRANSPORTER_HEALTHMOD = -40;
        public const int TRANSPORTER_MOVEMENTMOD = 2;
        public const int TRANSPORTER_COSTMOD = -10;
        public const int TRANSPORTER_DAMAGEMOD = -50;

        public const int DEFENSE_HEALTHMOD = 50;
        public const int DEFENSE_MOVEMENTMOD = -3;
        public const int DEFENSE_COSTMOD = 20;
        public const int DEFENSE_DAMAGEMOD = -20;

        public const int PHASE_SET = 0;
        public const int PHASE_MOVE = 1;
        public const int PHASE_FIGHT = 2;

        public const string PLAYER_RED = "red";
        public const string PLAYER_BLUE = "blue";
        public const string PLAYER_NONE = "";

        public const string FIELDTYPE_NORMAL = "normal";
        public const string FIELDTYPE_BASE = "base";
        public const string FIELDTYPE_BLOCKADE = "blockade";

        public const int GAMEFIELD_WIDTH = 600;
        public const int GAMEFIELD_HEIGHT = 500;
        public const int GAMEFIELD_TILESIZE = 50;
    }

}
