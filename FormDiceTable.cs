using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowerYahtzee
{
    public partial class FormDiceTable : Form
    {
        private List<PictureBox> dieFacePictureBoxes = new List<PictureBox>();
        private FormGameControl controller;


        public FormDiceTable(FormGameControl controller)
        {
            InitializeComponent();
            this.controller = controller;
            dieFacePictureBoxes.Add(pictureBoxDie1);
            dieFacePictureBoxes.Add(pictureBoxDie2);
            dieFacePictureBoxes.Add(pictureBoxDie3);
            dieFacePictureBoxes.Add(pictureBoxDie4);
            dieFacePictureBoxes.Add(pictureBoxDie5);
        }
        public List<PictureBox> getDicePictureBoxes()
        {
            return dieFacePictureBoxes;
        }
        public Label getRollCountLabel()
        {
            return labelRollCountNumber;
        }
        public Label getGameStatusLabel()
        {
            return labelStatusOfGame;
        }
        private void buttonRoll_Click(object sender, EventArgs e)
        {
            controller.rollPlayerDice();
        }

        private void pictureBoxDie1_Click(object sender, EventArgs e)
        {
            controller.flipDieHoldFlag(0);
        }

        private void pictureBoxDie2_Click(object sender, EventArgs e)
        {
            controller.flipDieHoldFlag(1);
        }

        private void pictureBoxDie3_Click(object sender, EventArgs e)
        {
            controller.flipDieHoldFlag(2);
        }

        private void pictureBoxDie4_Click(object sender, EventArgs e)
        {
            controller.flipDieHoldFlag(3);
        }

        private void pictureBoxDie5_Click(object sender, EventArgs e)
        {
            controller.flipDieHoldFlag(4);
        }
        public void setRollDieEnabled(bool enabled)
        {
            buttonRoll.Enabled = enabled;
        }
    }
}
