using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLibrary;
using Moq;
using System;
using System.Reflection;

namespace GameLibraryTest;

[TestClass]
public class GameTests
{
    [TestMethod]
     public void RandomNumberGenerator()
    {
        Game game = new Game("Player");
        int randomNumber = game.GetRandomNumber();
        Assert.IsTrue(randomNumber >= 0 && randomNumber <= 100);
        
    }

     [TestMethod]
     public void PlayerNameGenerator()
    {
        Game game = new Game("Player");
        string playerName = game.GetPlayerName();
        Assert.IsTrue(playerName == "Player");
        
    }
    
 
    
}