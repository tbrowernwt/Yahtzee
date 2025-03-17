using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowerYahtzee
{
    public partial class FormScorecard : Form
    {
        private FormGameControl gameControl;
        private byte player;
        private YahtzeeGame game = new YahtzeeGame();
        private List<Label> labelListScorableEstimates = new List<Label>();
        private List<TextBox> textBoxListScorableFields = new List<TextBox>();
        public FormScorecard(FormGameControl gameControl, byte playerNum)
        {
            this.player = playerNum;
            InitializeComponent();
            compileLists();
            this.gameControl = gameControl;
            this.Text = "Player " + (playerNum + 1).ToString() + " scorecard";
            game.startNewGame();
        }
        private void compileLists()
        {
            labelListScorableEstimates.Add(labelOnesEstimate);
            labelListScorableEstimates.Add(labelTwosEstimate);
            labelListScorableEstimates.Add(labelThreesEstimate);
            labelListScorableEstimates.Add(labelFoursEstimate);
            labelListScorableEstimates.Add(labelFivesEstimate);
            labelListScorableEstimates.Add(labelSixesEstimate);
            labelListScorableEstimates.Add(labelThreeKindEstimate);
            labelListScorableEstimates.Add(labelFourKindEstimate);
            labelListScorableEstimates.Add(labelFullHouseEstimate);
            labelListScorableEstimates.Add(labelSmStrEstimate);
            labelListScorableEstimates.Add(labelLgStrEstimate);
            labelListScorableEstimates.Add(labelYahtzeeEstimate);
            labelListScorableEstimates.Add(labelChanceEstimate);

            textBoxListScorableFields.Add(textBoxAcesBox);
            textBoxListScorableFields.Add(textBoxTwosBox);
            textBoxListScorableFields.Add(textBoxThreesBox);
            textBoxListScorableFields.Add(textBoxFoursBox);
            textBoxListScorableFields.Add(textBoxFivesBox);
            textBoxListScorableFields.Add(textBoxSixesBox);
            textBoxListScorableFields.Add(textBoxThreeKind);
            textBoxListScorableFields.Add(textBoxFourKind);
            textBoxListScorableFields.Add(textBoxFullHouse);
            textBoxListScorableFields.Add(textBoxSmStraight);
            textBoxListScorableFields.Add(textBoxLgStraight);
            textBoxListScorableFields.Add(textBoxYahtzee);
            textBoxListScorableFields.Add(textBoxChance);
        }
        public void updateScorecard()
        {
            updateScoreEstimates();
            int upperScore = 0;
            int lowerScore = 0;
            int totalScore = 0;
            for (int i = 0; i < textBoxListScorableFields.Count; i++)
            {
                if (textBoxListScorableFields[i].Text != "")
                {
                    if (i < 6)
                    {
                        upperScore += int.Parse(textBoxListScorableFields[i].Text);
                    }
                    else
                    {
                        lowerScore += int.Parse(textBoxListScorableFields[i].Text);
                    }
                }
            }
            if(upperScore >= 63)
            {
                textBoxBonusBox.Text = "35";
                upperScore += 35;
            }
            if(checkBoxBonusYahtzeeOne.Checked)
            {
                lowerScore += 100;
            }
            if(checkBoxBonusYahtzeeTwo.Checked)
            {
                lowerScore += 100;
            }
            if(checkBoxBonusYahtzeeThree.Checked)
            {
                lowerScore += 100;
            }
            totalScore = upperScore + lowerScore;
            textBoxUpperTotal.Text = upperScore.ToString();
            textBoxLowerTotal.Text = lowerScore.ToString();
            textBoxGrandTotal.Text = totalScore.ToString();
            gameControl.updatePlayerScore(textBoxGrandTotal.Text, player);
        }
        private void updateScoreEstimates()
        {
            int[] scoreEstimates = Scorer.getScoreSheetEstimateArray(game.getDieValueArray());
            for (int i = 0; i < labelListScorableEstimates.Count; i++)
            {
                labelListScorableEstimates[i].Text = scoreEstimates[i].ToString();
            }
        }

        public void clearScorecard()
        {
            foreach (Label l in labelListScorableEstimates)
            {
                l.Text = "0";
                l.Visible = true;
            }
            foreach(TextBox b in textBoxListScorableFields)
            {
                b.Text = "";
            }
            textBoxBonusBox.Text = "";
            checkBoxBonusYahtzeeOne.Checked = false;
            checkBoxBonusYahtzeeTwo.Checked = false;
            checkBoxBonusYahtzeeThree.Checked = false;
            textBoxUpperTotal.Text = "0";
            textBoxLowerTotal.Text = "0";
            textBoxGrandTotal.Text = "0";
        }
        public bool getIfNewRound()
        {
            return !game.getIfCanScore();
        }
        private void processScoreFieldClick(object sender, EventArgs e)
        {
            TextBox selection = sender as TextBox;
            if (game.getIfCanScore() && selection.Text == "")
            {
                game.setCanScoreFlag(false);
                if (Scorer.getIfYahtzee(game.getDieValueArray()) && textBoxYahtzee.Text == "50")
                {
                    addTallyToBonusYahtzees();
                }
                noteScore(selection, textBoxListScorableFields.IndexOf(selection));
                if (game.getRound() == 13)
                {
                    game.setGameOver(true);
                }
            }
            updateScorecard();
        }
        private void noteScore(TextBox textBoxScoreChosen, int optionIndex)
        {
            textBoxScoreChosen.Text = labelListScorableEstimates[optionIndex].Text;
            labelListScorableEstimates[optionIndex].Visible = false;
            gameControl.nextPlayer();
        }
        private void addTallyToBonusYahtzees()
        {
            if (!checkBoxBonusYahtzeeOne.Checked)
            {
                checkBoxBonusYahtzeeOne.Checked = true;
            }
            else if (!checkBoxBonusYahtzeeTwo.Checked)
            {
                checkBoxBonusYahtzeeTwo.Checked = true;
            }
            else
            {
                checkBoxBonusYahtzeeThree.Checked = true;
            }
        }
        public YahtzeeGame getYahtzeeGameContext()
        {
            return game;
        }
    }
}
