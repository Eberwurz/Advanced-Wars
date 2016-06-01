using System;
using System.Collections.Generic;
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
        public GameBoard(int width, int height)
        {
            mWidth = width;
            mHeight = height;
            mFields = new Field[width,height];
        }

        public Field[,] Fields
        {
            get
            {
                return mFields;
            }
        }

        public bool setField(Field field,int x, int y)
        {
            bool success = false;
            if(x>=0 && x<mWidth)
            {
                if (y>=0 && y<mHeight)
                {
                    mFields[x, y] = field;
                    success = true;
                }
            }
            return success;
        }
    }
}
