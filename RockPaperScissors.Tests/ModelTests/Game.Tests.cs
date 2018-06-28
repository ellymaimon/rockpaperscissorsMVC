using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using RockPaperScissors;

namespace RockPaperScissors.Tests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void GetSetPlayerOne_GetsSetsPlayerOne_True()
        {
            Game testGame = new Game();
            string test = "thaddius";
            testGame.SetPlayerOne(test);
            Assert.AreEqual(test, testGame.GetPlayerOne());
        }

        [TestMethod]
        public void GetSetPlayerTwo_GetsSetsPlayerTwo_True()
        {
            Game testGame = new Game();
            string test = "thadislame";
            testGame.SetPlayerTwo(test);
            Assert.AreEqual(test, testGame.GetPlayerTwo());
        }

        [TestMethod]
        public void GetOutcome_GetsOutCome_True()
        {
            Game testGame = new Game();
            string test1 = "rock";
            string test2 = "paper";
            string winMessage = "Player Two Wins";
            testGame.SetPlayerOne(test1);
            testGame.SetPlayerTwo(test2);
            Assert.AreEqual(winMessage, testGame.GetOutcome());
        }
    }
}
