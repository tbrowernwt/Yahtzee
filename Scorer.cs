using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowerYahtzee
{
    public static class Scorer
    {
        /// <summary>
        /// Count the number of dice that have the same value.
        /// </summary>
        /// <param name="dice">The dice (represented as an integer array) in play</param>
        /// <returns>The maximum count of dice that match value.</returns>
        private static int countLikeDice(int[] dice)
        {
            int maxLikeCount = 0;
            int likeCount = 1;
            Array.Sort(dice);
            for (int i = 1; i < 5; i++)
            {
                if (dice[i - 1] == dice[i])
                {
                    likeCount++;
                }
                else
                {
                    if (likeCount > maxLikeCount)
                    {
                        maxLikeCount = likeCount;
                    }
                    likeCount = 1;
                }
            }
            if(likeCount > maxLikeCount)
            {
                maxLikeCount = likeCount;
            }
            return maxLikeCount;
        }
        /// <summary>
        /// Counts the longest sequence of dice in play for straights
        /// </summary>
        /// <param name="dice">The dice (represented as an integer array) in play</param>
        /// <returns>The count of the largest sequence (i.e. dice {1, 3, 5, 4, 1} = 3)</returns>
        private static int getCountOfSequence(int[] dice)
        {
            Array.Sort(dice);
            int currentCountOfSequence = 1;
            int maxCountOfSequence = 0;
            for (int i = 1; i < 5; i++)
            {
                if (dice[i] - 1 == dice[(i - 1)])
                {
                    currentCountOfSequence++;
                }
                else if (dice[i] == dice[i - 1])
                {
                    // Nothing. Doesn't add to the sequence, but doesn't break the sequence either
                }
                else
                {
                    if (currentCountOfSequence > maxCountOfSequence)
                    {
                        maxCountOfSequence = currentCountOfSequence;
                    }
                    currentCountOfSequence = 1;
                }
            }
            if(currentCountOfSequence > maxCountOfSequence)
            {
                maxCountOfSequence = currentCountOfSequence;
            }
            return maxCountOfSequence;
        }

        /// <summary>
        /// Checks if the dice in play is a Small Straight
        /// </summary>
        /// <param name="dice">The dice (represented as an integer array) in play</param>
        /// <returns>True if a sequence of four or more is in play (i.e. 2, 3, 4, 5)</returns>
        private static bool getIfSmallStraight(int[] dice)
        {
            if (getCountOfSequence(dice) >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Checks if the dice in play is a Large Straight
        /// </summary>
        /// <param name="dice"></param>
        /// <returns>
        /// True if the dice in play is a sequence of five ({1, 2, 3, 4, 5} or {2, 3, 4, 5, 6})
        /// </returns>
        private static bool getIfLargeStraight(int[] dice)
        {
            if(getCountOfSequence(dice) == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Checks if the dice in play counts as a three of a kind
        /// </summary>
        /// <param name="dice">The dice (represented as an integer array) in play</param>
        /// <returns>True if three or more dice are the same value</returns>
        private static bool getIfThreeOfAKind(int[] dice)
        {
            if(countLikeDice(dice) >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Checks if the dice in play counts as four of a kind
        /// </summary>
        /// <param name="dice"></param>
        /// <returns>True if four or more dice are the same value</returns>
        private static bool getIfFourOfAKind(int[] dice)
        {
            if(countLikeDice(dice) >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Checks if the dice in play is a Yahtzee
        /// </summary>
        /// <param name="dice"></param>
        /// <returns>True if all five dice show the same value</returns>
        public static bool getIfYahtzee(int[] dice)
        {
            return countLikeDice(dice) == 5;
        }
        /// <summary>
        /// Tabulates the score for an upper scorecard section
        /// Upper scorecard scores are calculated by taking the chosen value of die (1 - 6)
        /// multiplied by the number of dice showing the chosen value
        /// </summary>
        /// <param name="dice">The dice (represented as an integer array) in play</param>
        /// <param name="scoreOption">The integer representing the value chosen limited 1-6</param>
        /// <returns></returns>
        private static int countUpperSectionOptionScore(int[] dice, int scoreOption)
        {
            int score = 0;
            foreach(int dieValue in dice)
            {
                if(dieValue == scoreOption)
                {
                    score += scoreOption;
                }
            }
            return score;
        }
        /// <summary>
        /// Sums the values of all dice in play
        /// </summary>
        /// <param name="dice">The dice (represented as an integer array) in play</param>
        /// <returns>The sum of the values</returns>
        private static int addAllDice(int[] dice)
        {
            int sum = 0;
            foreach (int dieValue in dice)
            {
                sum += dieValue;
            }
            return sum;
        }
        /// <summary>
        /// Checks if a full house condition exists (a set of 3 + a pair)
        /// </summary>
        /// <param name="dice">The dice (represented as an integer array) in play</param>
        /// <returns>True if a full house condition exists</returns>
        private static bool getIfFullHouse(int[] dice)
        {
            Array.Sort(dice);
            int valueA = dice[0];
            int valueB = dice[4];
            int countOfA = 0;
            int countOfB = 0;
            foreach(int i in dice)
            {
                if (i == valueA)
                {
                    countOfA++;
                }
                else if (i == valueB)
                {
                    countOfB++;
                }
                else
                {
                    return false;
                }
            }
            return (countOfA == 2 || countOfB == 2) && (countOfA == 3 || countOfB == 3);

        }
        /// <summary>
        /// Provides an array of the possible scores based on the current state of the dice
        /// </summary>
        /// <param name="dice">The dice (represented as an integer array) in play</param>
        /// <returns>
        /// An integer array of scores based on order of appearance on scorecard. This does NOT
        /// include the Upper section bonus, upper total, or lower total.
        /// </returns>
        public static int[] getScoreSheetEstimateArray(int[] dice)
        {
            int[] scoreArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < scoreArray.Length; i++)
            {
                switch (i)
                {
                    case 6: // 3 kind
                        if (getIfThreeOfAKind(dice))
                        {
                            scoreArray[i] = addAllDice(dice);
                        }
                        break;
                    case 7:  // 4 kind
                        if (getIfFourOfAKind(dice))
                        {
                            scoreArray[i] = addAllDice(dice);
                        }
                        break;
                    case 8: // full house
                        if (getIfFullHouse(dice))
                        {
                            scoreArray[i] = 25;
                        }
                        break;
                    case 9: // sm straight
                        if(getIfSmallStraight(dice))
                        {
                            scoreArray[i] = 30;
                        }
                        break;
                    case 10: // lg straight
                        if(getIfLargeStraight(dice))
                        {
                            scoreArray[i] = 40;
                        }
                        break;
                    case 11: // yahtzee
                        if(getIfYahtzee(dice))
                        {
                            scoreArray[i] = 50;
                        }
                        break;
                    case 12: // chance
                        scoreArray[i] = addAllDice(dice);
                        break;
                    default:
                        scoreArray[i] = countUpperSectionOptionScore(dice, i + 1);
                        break;
                }
            }
            return scoreArray;
        }
        public static bool checkForYahtzee(int[] dice)
        {
            return getIfYahtzee(dice);
        }
    }

}
