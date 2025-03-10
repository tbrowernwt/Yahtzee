using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowerYahtzee
{

    public static class TableRenderer
    {
        private static int TOSSYCOORD = 12;
        private static int KEEPYCOORD = 91;

        private static int DIE1XCOORD = 12;
        private static int DIE2XCOORD = 97;
        private static int DIE3XCOORD = 182;
        private static int DIE4XCOORD = 265;
        private static int DIE5XCOORD = 350;

        public static void renderTable(List<Die> diceOnTable, List<System.Windows.Forms.PictureBox> dicePicBoxes, ImageList dieFaces)
        {
            int picXCoord = 0;
            int picYCoord = 0;
            for (int i = 0; i < diceOnTable.Count; i++)
            {
                dicePicBoxes[i].Image = dieFaces.Images[diceOnTable[i].getValueOfDie() - 1];
                switch (i)
                {
                    case 0:
                        picXCoord = DIE1XCOORD;
                        break;
                    case 1:
                        picXCoord = DIE2XCOORD;
                        break;
                    case 2:
                        picXCoord = DIE3XCOORD;
                        break;
                    case 3:
                        picXCoord = DIE4XCOORD;
                        break;
                    default:
                        picXCoord = DIE5XCOORD;
                        break;
                }
                if (diceOnTable[i].isFlaggedForReroll())
                {
                    picYCoord = TOSSYCOORD;
                }
                else
                {
                    picYCoord = KEEPYCOORD;
                }
                dicePicBoxes[i].Location = new System.Drawing.Point(picXCoord, picYCoord);
            }
        }
    }
}
