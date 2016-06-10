using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leveleditor
{
    public partial class Form1 : Form
    {
        GameBoard mGameBoard;
        Field mSelectedField;
        PictureBox[] mPowerUpPictures;
        PictureBox[] mFieldPictures;
        int mBaseCount;
        string mPlayer = GameConstants.PLAYER_RED;

        public Form1()
        {
            InitializeComponent();
            mGameBoard = new GameBoard(GameConstants.FIELD_X, GameConstants.FIELD_Y);
            mSelectedField = null;
            mPowerUpPictures = new PictureBox[]{picBoost, picSlow, picNone };
            mFieldPictures = new PictureBox[]{ picWater, picIslandRed, picIslandBlue, picRiff };
            mBaseCount = 0;
            picGameField.Image = mGameBoard.GameBoardImage;
            LogMessage("1. Base auswählen", Color.Black);
        }

        private void onFieldTypeClicked(object sender, EventArgs e)
        {
            if(mBaseCount >= 2)
            {
                PictureBox pbClicked = sender as PictureBox;
                if (pbClicked != null)
                {
                    setSelected(pbClicked, mFieldPictures);
                    string fieldType = getFieldType(pbClicked.Name);
                    string fieldPlayer = getFieldPlayer(pbClicked.Name);
                    if (mSelectedField != null)
                    {
                        mSelectedField.Type = fieldType;
                        mSelectedField.Player = fieldPlayer;
                    }
                    else
                    {
                        mSelectedField = new Field(fieldType, GameConstants.POWERUP_NONE, fieldPlayer);
                        picNone.BackColor = Color.Red;
                    }
                }
            }          
        }

        private string getFieldPlayer(string name)
        {
            string player = GameConstants.PLAYER_NONE;
            switch (name)
            {
                case "picIslandRed":
                    player = GameConstants.PLAYER_RED;
                    break;
                case "picIslandBlue":
                    player = GameConstants.PLAYER_BLUE;
                    break;
            }
            return player;
        }

        private string getFieldType(string name)
        {
            string type = GameConstants.TYPE_NORMAL;
            switch (name)
            {
                case "picIslandRed":
                case "picIslandBlue":
                    type = GameConstants.TYPE_BASE;
                    break;
                case "picRiff":
                    type = GameConstants.TYPE_BLOCKADE;
                    break;
            }
            return type;
        }

        private void onFieldBoostClicked(object sender, EventArgs e)
        {
            if(mBaseCount >= 2)
            {
                PictureBox pbClicked = sender as PictureBox;
                if (pbClicked != null)
                {
                    setSelected(pbClicked, mPowerUpPictures);
                    string powerUpType = getPowerUp(pbClicked.Name);
                    if (mSelectedField != null)
                    {
                        mSelectedField.PowerUp = powerUpType;
                    }
                    else
                    {
                        mSelectedField = new Field(GameConstants.TYPE_NORMAL, powerUpType);
                        picWater.BackColor = Color.Red;
                    }
                }
            }            
        }

        private void setSelected(PictureBox pbClicked,PictureBox[] SelectionGroup)
        {
            for(int i=0;i<SelectionGroup.Length; i++)
            {
                if(pbClicked == SelectionGroup[i])
                {
                    pbClicked.BackColor = Color.Red;
                }else
                {
                    SelectionGroup[i].BackColor = Color.Black;
                }
            }
        }

        private string getPowerUp(string name)
        {
            string powerUp = GameConstants.POWERUP_NONE;
            switch(name)
            {
                case "picBoost": powerUp = GameConstants.POWERUP_SPEED;
                                 break;
                case "picSlow": powerUp = GameConstants.POWERUP_SLOW;
                                break;
            }
            return powerUp;
        }

        private void onGameFieldClicked(object sender, EventArgs e)
        {
            MouseEventArgs a = e as MouseEventArgs;
            int indexX = (int)Math.Floor((double)a.X / GameConstants.FIELD_SIZE);
            int indexY = (int)Math.Floor((double)a.Y / GameConstants.FIELD_SIZE);
            if (mBaseCount >= 2)
            {
                if (mSelectedField != null && mGameBoard != null)
                {
                    if (mGameBoard.TrySetField(mSelectedField, indexX, indexY))
                    {
                        picGameField.Image = mGameBoard.GameBoardImage;
                        LogMessage("Feld wurde gesetzt", Color.Green);
                    }
                    else
                    {
                        LogMessage("Feld konnte nicht gesetzt werden", Color.Red);
                    }
                }
                else
                {
                    LogMessage("Erst Feld auswählen", Color.Red);
                }
            } 
            else
            {
                Field basis = new Field(GameConstants.TYPE_BASE, GameConstants.POWERUP_NONE, mPlayer);
                if(mGameBoard.TrySetField(basis, indexX, indexY))
                {
                    if(mBaseCount == 0)
                    {
                        LogMessage("2. Base auswählen", Color.Black);
                        mPlayer = GameConstants.PLAYER_BLUE;
                    }
                    else
                    {
                        LogMessage("", Color.Black);
                    }
                    picGameField.Image = mGameBoard.GameBoardImage;
                    mBaseCount++;
                }
            }          
        }

        private void LogMessage(string text, Color textColor)
        {
            lblLog.ForeColor = textColor;
            lblLog.Text = text;
        }

        private void onSaveButtonClick(object sender, EventArgs e)
        {
            if (mBaseCount >= 2)
            {
                string name = txtName.Text;
                if (!String.IsNullOrWhiteSpace(name))
                {
                    FolderBrowserDialog saveDialog = new FolderBrowserDialog();
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Pfad ohne \ am Ende!
                        string folder = saveDialog.SelectedPath;
                        if (mGameBoard.SaveGameBoard(folder, txtName.Text))
                        {
                            LogMessage("Map Gespeichert!", Color.Green);
                        }
                        else
                        {
                            LogMessage("Speichern fehlgeschlagen!", Color.Red);
                        }
                    }
                }
                else
                {
                    LogMessage("Gültigen Namen eingeben", Color.Red);
                }
            }        
        }
    }
}
