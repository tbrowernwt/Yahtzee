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
        private List<PictureBox> dieFacePictureBoxes = new List<PictureBox>();

        private static string NEW_GAME_MESSAGE = "Game over. Click New Game on the scorecard to begin a new game";
        private static string SELECT_SCORE_MESSAGE = "Select an option from the scorecard";
        private static string DUAL_OPTION_MESSAGE = "Select the dice to hold and click Roll or pick from the scorecard";
        private static string NEW_GAME_FIRST_ROLL_MESSAGE = "Click Roll button to begin";
        private static string ROLL_TO_CONTINUE = "Click Roll button to continue";

        public FormDiceTable(FormScorecard scorecard)
        {
            InitializeComponent();
            this.scorecard = scorecard;
            dieFacePictureBoxes.Add(pictureBoxDie1);
            dieFacePictureBoxes.Add(pictureBoxDie2);
            dieFacePictureBoxes.Add(pictureBoxDie3);
            dieFacePictureBoxes.Add(pictureBoxDie4);
            dieFacePictureBoxes.Add(pictureBoxDie5);
            scorecard.getYahtzeeGameContext().startNewGame();
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            scorecard.getYahtzeeGameContext().rollDice(scorecard.getIfNewRound());
            scorecard.getYahtzeeGameContext().setCanScoreFlag(true);
            updateFormView();
            scorecard.updateScorecard();
        }

        private void pictureBoxDie1_Click(object sender, EventArgs e)
        {
            scorecard.getYahtzeeGameContext().flipDieHoldFlag(0);
            updateFormView();

        }

        private void pictureBoxDie2_Click(object sender, EventArgs e)
        {
            scorecard.getYahtzeeGameContext().flipDieHoldFlag(1);
            updateFormView();
        }

        private void pictureBoxDie3_Click(object sender, EventArgs e)
        {
            scorecard.getYahtzeeGameContext().flipDieHoldFlag(2);
            updateFormView();
        }

        private void pictureBoxDie4_Click(object sender, EventArgs e)
        {
            scorecard.getYahtzeeGameContext().flipDieHoldFlag(3);
            updateFormView();
        }

        private void pictureBoxDie5_Click(object sender, EventArgs e)
        {
            scorecard.getYahtzeeGameContext().flipDieHoldFlag(4);
            updateFormView();
        }
        private void updateFormView()
        {
            TableRenderer.renderTable(scorecard.getYahtzeeGameContext().getDiceList(), dieFacePictureBoxes, imageListDieFaces);
            labelRollCountNumber.Text = scorecard.getYahtzeeGameContext().getCountOfRolls().ToString();
            updateGameStatusLabel();
        }
        public void updateGameStatusLabel()
        {
            if (scorecard.getYahtzeeGameContext().getIfGameOver())
            {
                labelStatusOfGame.Text = NEW_GAME_MESSAGE;
            }
            else if (scorecard.getYahtzeeGameContext().getIfCanScore())
            {
                if (scorecard.getYahtzeeGameContext().getCountOfRolls() == 3)
                {
                    labelStatusOfGame.Text = SELECT_SCORE_MESSAGE;
                }
                else
                {
                    labelStatusOfGame.Text = DUAL_OPTION_MESSAGE;
                }
            }
            else
            {
                labelStatusOfGame.Text = ROLL_TO_CONTINUE;
            }
        }
    }
}
