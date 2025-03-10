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
        private FormScorecard scorecard;
        private YahtzeeGame game;
        private List<PictureBox> dieFacePictureBoxes = new List<PictureBox>();

        public FormDiceTable(ref YahtzeeGame game)
        {
            InitializeComponent();
            this.game = game;
            scorecard = new FormScorecard(ref game);
            scorecard.Show();
            dieFacePictureBoxes.Add(pictureBoxDie1);
            dieFacePictureBoxes.Add(pictureBoxDie2);
            dieFacePictureBoxes.Add(pictureBoxDie3);
            dieFacePictureBoxes.Add(pictureBoxDie4);
            dieFacePictureBoxes.Add(pictureBoxDie5);
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            game.rollDice(scorecard.getIfNewRound());
            scorecard.setCanScoreFlag(true);
            updateFormView();
            scorecard.updateScorecard();
        }

        private void pictureBoxDie1_Click(object sender, EventArgs e)
        {
            game.flipDieHoldFlag(0);
            updateFormView();

        }

        private void pictureBoxDie2_Click(object sender, EventArgs e)
        {
            game.flipDieHoldFlag(1);
            updateFormView();
        }

        private void pictureBoxDie3_Click(object sender, EventArgs e)
        {
            game.flipDieHoldFlag(2);
            updateFormView();
        }

        private void pictureBoxDie4_Click(object sender, EventArgs e)
        {
            game.flipDieHoldFlag(3);
            updateFormView();
        }

        private void pictureBoxDie5_Click(object sender, EventArgs e)
        {
            game.flipDieHoldFlag(4);
            updateFormView();
        }
        private void updateFormView()
        {
            TableRenderer.renderTable(game.getDiceList(), dieFacePictureBoxes, imageListDieFaces);
            labelRollCountNumber.Text = game.getCountOfRolls().ToString();
        }
    }
}
