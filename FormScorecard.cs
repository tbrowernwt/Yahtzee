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
        private static string NEW_GAME_MESSAGE = "Game over. Click New Game on the scorecard to begin a new game";
        private static string SELECT_SCORE_MESSAGE = "Select an option from the scorecard";
        private static string DUAL_OPTION_MESSAGE = "Select the dice to hold and click Roll or pick from the scorecard";
        private static string NEW_GAME_FIRST_ROLL_MESSAGE = "Click Roll button to begin";
        private static string ROLL_TO_CONTINUE = "Click Roll button to continue";

        private bool canScoreFlag = false;
        private List<Label> labelListScorableEstimates = new List<Label>();
        private YahtzeeGame game;
        private List<TextBox> textBoxListScorableFields = new List<TextBox>();
        public FormScorecard(ref YahtzeeGame game)
        {
            InitializeComponent();
            compileLists();
            this.game = game;
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
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            clearScorecard();
            game.startNewGame();
            canScoreFlag = false;
            labelStatusOfGame.Text = NEW_GAME_FIRST_ROLL_MESSAGE;
        }
        public void updateScorecard()
        {
            updateScoreEstimates();
            updateGameStatusLabel();
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
        }
        public void updateScoreEstimates()
        {
            int[] scoreEstimates = Scorer.getScoreSheetEstimateArray(game.getDieValueArray());
            for (int i = 0; i < labelListScorableEstimates.Count; i++)
            {
                labelListScorableEstimates[i].Text = scoreEstimates[i].ToString();
            }
        }
        public void updateGameStatusLabel()
        {
            if (game.getIfGameOver())
            {
                labelStatusOfGame.Text = NEW_GAME_MESSAGE;
            }
            else if (canScoreFlag)
            {
                if (game.getCountOfRolls() == 3)
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
            return !canScoreFlag;
        }
        public void setCanScoreFlag(bool flag)
        {
            canScoreFlag = flag;
        }
        private void processScoreFieldClick(object sender, EventArgs e)
        {
            TextBox selection = sender as TextBox;
            if (canScoreFlag && selection.Text == "")
            { 
                canScoreFlag = false;
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
    }
}
