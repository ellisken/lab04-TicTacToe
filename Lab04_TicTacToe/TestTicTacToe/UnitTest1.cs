using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace TestTicTacToe
{
    public class UnitTest1
    {
        /* REQUIRED TESTS:
         * Given a game board, test for winners (3 different tests) [Theory]
         * Test for switch in players between turns
         * Confirm player position correlates to correct index of the board array
         * Create one other test of your own
         */

        [Fact]
        public void TestDisplayBoard()
        {
            Board testBoard = new Board();
            testBoard.DisplayBoard(); 
        }
    }
}
