using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowerYahtzee
{
    public class YahtzeeGame
    {
        private bool canScoreFlag = false;
        private byte countOfRolls;
        private List<Die> diceOnTable = new List<Die>();
        private bool gameOver = false;
        private int round = 0;
        private Random rng = new Random();
        public YahtzeeGame()
        {
            for(int i = 0; i < 5; i++)
            {
                diceOnTable.Add(new Die(i));
                diceOnTable[i].setValueOfDie((byte) (i + 1));
            }
        }
        public void startNewGame()
        {
            gameOver = false;
            round = 0;
        }
        public bool getIfGameOver()
        {
            return gameOver;
        }
        public List<Die> getDiceList()
        {
            return diceOnTable;
        }
        public void flipDieHoldFlag(int dieNumber, bool forceTrue = false)
        {
            diceOnTable[dieNumber].flipFlagForReroll(forceTrue);
        }
        public int[] getDieValueArray()
        {
            int[] values = new int[5];
            for (int i = 0; i < 5; i++)
            {
                values[i] = diceOnTable[i].getValueOfDie();
            }
            return values;
        }
        public byte getCountOfRolls()
        {
            return countOfRolls;
        }
        public void setGameOver(bool flag)
        {
            gameOver = flag;
        }
        public void rollDice(bool newRound)
        {
            if(!gameOver)
            {
                if(newRound)
                {
                    foreach(Die d in diceOnTable)
                    {
                        d.flipFlagForReroll(true);
                    }
                    countOfRolls = 0;
                    round++;
                }
                if (countOfRolls < 3)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (diceOnTable[i].isFlaggedForReroll())
                        {
                            diceOnTable[i].setValueOfDie((byte)rng.Next(1, 7));
                        }
                    }
                    countOfRolls++;
                    canScoreFlag = true;
                }
            }
        }
        public bool getIfCanScore()
        {
            return canScoreFlag;
        }
        public void setCanScoreFlag(bool flag)
        {
            canScoreFlag = flag;
        }
        public int getRound()
        {
            return round;
        }
    }
}
