using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BrowerYahtzee
{
    public class Die
    {
        private bool flaggedForReroll = true;
        private byte faceValue = 1;
        private int dieIndex = 0;
        public Die(int dieIndex)
        {
            this.dieIndex = dieIndex;
        }

        public void flipFlagForReroll(bool forceTrue= false)
        {
            if (forceTrue)
            {
                flaggedForReroll = true;
            }
            else
            {
                flaggedForReroll = !flaggedForReroll;
            }
        }
        public void setValueOfDie(byte value)
        {
            faceValue = value;
        }
        public byte getValueOfDie()
        {
            return faceValue;
        }
        public bool isFlaggedForReroll()
        {
            return flaggedForReroll;
        }
    }
}
