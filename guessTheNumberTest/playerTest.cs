using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLibrary;

namespace GameLibraryTest
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void PlayerConstructor_NameInitializedCorrectly()
        {
            // Arrange
            string playerName = "John";
            // Act
            Player  _humanPlayer = new HumanPlayer(playerName);
            // Assert
            Assert.AreEqual(playerName, _humanPlayer.Name);
        }

         [TestMethod]
        public void MakeGuess_ValidInput()
        {
            string playerName = "John";
            int expectedGuess = 42; // Adivinanza esperada

            // Simula entrada de usuario utilizando un TextReader mock
            using (var stringReader = new StringReader(expectedGuess.ToString()))
            {
                Console.SetIn(stringReader);
                HumanPlayer player = new HumanPlayer(playerName);
                player.MakeGuess();
                // Assert
                Assert.AreEqual(expectedGuess, player.LastAttempt);
            }
        }
    
    }
}
