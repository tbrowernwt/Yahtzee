using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace BrowerYahtzee
{
    public partial class FormGameControl : Form
    {
        private List<FormScorecard> playerScorecards = new List<FormScorecard>();
        private List<Label> playerScoreLabels = new List<Label>();
        private List<TextBox> playerScoreTextBoxes = new List<TextBox>();
        private byte numberPlayers = 1;
        private byte playerTurn = 0;
        private bool isGameOver = true;
        private FormDiceTable diceTable;
        private static string NEW_GAME_MESSAGE = "Game over. Click New Game on the control panel to begin a new game";
        private static string SELECT_SCORE_MESSAGE = "Select an option from the scorecard";
        private static string DUAL_OPTION_MESSAGE = "Select the dice to hold and click Roll or pick from the scorecard";
        private static string ROLL_TO_CONTINUE = "Click Roll button";
        public FormGameControl()
        {
            InitializeComponent();
            diceTable = new FormDiceTable(this);
            diceTable.Show();
            compileLists();
        }
        private void compileLists()
        {
            playerScoreLabels.Add(labelPlayerOne);
            playerScoreLabels.Add(labelPlayerTwo);
            playerScoreLabels.Add(labelPlayerThree);
            playerScoreLabels.Add(labelPlayerFour);

            playerScoreTextBoxes.Add(textBoxPlayerOne);
            playerScoreTextBoxes.Add(textBoxPlayerTwo);
            playerScoreTextBoxes.Add(textBoxPlayerThree);
            playerScoreTextBoxes.Add(textBoxPlayerFour);
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            if (isGameOver)
            {
                isGameOver = false;
                foreach (TextBox t in playerScoreTextBoxes)
                {
                    t.Visible = false;
                    t.Text = "0";
                }
                foreach (Label l in playerScoreLabels)
                {
                    l.Visible = false;
                }
                foreach (FormScorecard s in playerScorecards)
                {
                    s.Close();
                }
                numberPlayers = (byte)numericNumPlayers.Value;
                playerTurn = 0;
                playerScorecards.Clear();
                for (byte b = 0; b < numberPlayers; b++)
                {
                    FormScorecard s = new FormScorecard(this, b);
                    s.Show();
                    playerScoreLabels[b].Visible = true;
                    playerScoreTextBoxes[b].Visible = true;
                    playerScorecards.Add(s);
                }
                diceTable.setRollDieEnabled(true);
            }
            updateGameStatusLabel();
        }
        public void rollPlayerDice()
        {
            playerScorecards[playerTurn]
                .getYahtzeeGameContext().rollDice(playerScorecards[playerTurn].getIfNewRound());
            updateDieTable();
            playerScorecards[playerTurn].updateScorecard();
        }
        private void checkAndUpdateGameOver()
        {
            if (playerScorecards[numberPlayers - 1].getYahtzeeGameContext().getIfGameOver())
            {
                isGameOver = true;
            }
        }
        public void nextPlayer()
        {
            playerScorecards[playerTurn].getYahtzeeGameContext().setCanScoreFlag(false);
            playerTurn = (byte)((playerTurn + 1) % numberPlayers);
            if (playerScorecards[playerTurn].getYahtzeeGameContext().getIfGameOver())
            {
                isGameOver = true;
            }
            updateGameStatusLabel();
        }
        public void flipDieHoldFlag(int die)
        {
            playerScorecards[playerTurn].getYahtzeeGameContext().flipDieHoldFlag(die);
            updateDieTable();
        }
        private void updateDieTable()
        {
            TableRenderer.renderTable(playerScorecards[playerTurn].getYahtzeeGameContext().getDiceList(), diceTable.getDicePictureBoxes(), imageListDieFaces);
            diceTable.getRollCountLabel().Text = playerScorecards[playerTurn].getYahtzeeGameContext().getCountOfRolls().ToString();
            updateGameStatusLabel();
        }
        public void updatePlayerScore(string score, byte player)
        {
            playerScoreTextBoxes[player].Text = score;
        }
        public void updateGameStatusLabel()
        {
            string message = "";
            if (isGameOver)
            {
                message = NEW_GAME_MESSAGE;
            }
            else if (playerScorecards[playerTurn].getYahtzeeGameContext().getIfCanScore())
            {
                message = "Player " + (playerTurn + 1).ToString() + ", ";
                if (playerScorecards[playerTurn].getYahtzeeGameContext().getCountOfRolls() == 3)
                {
                    message = message + SELECT_SCORE_MESSAGE;
                }
                else
                {
                    message = message + DUAL_OPTION_MESSAGE;
                }
            }
            else
            {
                message = "Player " + (playerTurn + 1).ToString() + ", " + ROLL_TO_CONTINUE;
            }
            diceTable.getGameStatusLabel().Text = message;
        }
    }
}
