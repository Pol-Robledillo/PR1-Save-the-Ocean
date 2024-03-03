using PR1_Save_the_Ocean;
namespace Tests_PR1_Save_the_Ocean
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPlayerToString()
        {
            // Arrange
            Player player = new Player("Pol", 1, 45);
            string expected = "+-----------------------------------------------+\r\n" +
                   "|                    JUGADOR                    |\r\n" +
                   "+-----------------------------------------------+\r\n" +
                   "|Nom\t\t|Ocupació\t|Experiència\t|\r\n" +
                   "+-----------------------------------------------+\r\n" +
                   "|{0}\t\t|{1}\t\t|{2}\t\t|\r\n" +
                   "+-----------------------------------------------+\r\n";

            // Act
            string result = player.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestRescueToString()
        {
            // Arrange
            Rescue rescue = new Rescue("RES123", "2021-10-10 10:10:10", "Palamós");
            string expected = "+-----------------------------------------------------------------------+\r\n" +
                   "|                                 RESCAT                                |\r\n" +
                   "+-----------------------------------------------------------------------+\r\n" +
                   "|# Rescat|Data Rescat\t\t|Superfamilia\t|GA\t|Localització\t|\r\n" +
                   "+-----------------------------------------------------------------------+\r\n" +
                   "| {0} |{1}\t|{2}\t|{3}\t|{4}\t|\r\n" +
                   "+-----------------------------------------------------------------------+";

            // Act
            string result = rescue.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestSeaTurtleToString()
        {
            // Arrange
            SeaTurtle seaTurtle = new SeaTurtle("Leonardo", 1, "Tortuga Verda", 50, 100);
            string expected = "+---------------------------------------------------------------+\r\n" +
                   "|                            FITXA                              |\r\n" +
                   "+---------------------------------------------------------------+\r\n" +
                   "|Nom\t\t|Superfamília\t|Espècie\t|Pes aproximat\t|\r\n" +
                   "+---------------------------------------------------------------+\r\n" +
                   "|{0}\t|{1}\t|{2}\t|{3}\t\t|\r\n" +
                   "+---------------------------------------------------------------+";

            // Act
            string result = seaTurtle.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestSeaTurtleCalcNewGA()
        {
            // Arrange
            SeaTurtle seaTurtle = new SeaTurtle("Leonardo", 1, "Tortuga Verda", 50, 100);
            int option = 1;
            bool expected = true;

            // Act
            bool result = seaTurtle.CalcNewGA(option);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestSeaTurtleShowGA()
        {
            // Arrange
            SeaTurtle seaTurtle = new SeaTurtle("Leonardo", 1, "Tortuga Verda", 10, 20.5);
            string expected = "La tortuga marina té un grau d'acceptació del 10%. ";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                seaTurtle.ShowGA();

                // Assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void TestSeaBirdToString()
        {
            // Arrange
            SeaBird seaBird = new SeaBird("Piolín", 1, "Albatros", 50, 100);
            string expected = "+---------------------------------------------------------------+\r\n" +
                   "|                            FITXA                              |\r\n" +
                   "+---------------------------------------------------------------+\r\n" +
                   "|Nom\t\t|Superfamília\t|Espècie\t|Pes aproximat\t|\r\n" +
                   "+---------------------------------------------------------------+\r\n" +
                   "|{0}\t|{1}\t|{2}\t|{3}\t\t|\r\n" +
                   "+---------------------------------------------------------------+";

            // Act
            string result = seaBird.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestSeaBirdCalcNewGA()
        {
            // Arrange
            SeaBird seaBird = new SeaBird("Piolín", 1, "Albatros", 50, 100);
            int option = 1;
            bool expected = true;

            // Act
            bool result = seaBird.CalcNewGA(option);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestSeaBirdShowGA()
        {
            // Arrange
            SeaBird seaBird = new SeaBird("Piolín", 1, "Albatros", 10, 20.5);
            string expected = "L'au marina té un grau d'acceptació del 10%. ";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                seaBird.ShowGA();

                // Assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void TestCetaceanToString()
        {
            // Arrange
            Cetacean cetacean = new Cetacean("Tony", 1, "Balena", 50, 100);
            string expected = "+---------------------------------------------------------------+\r\n" +
                   "|                            FITXA                              |\r\n" +
                   "+---------------------------------------------------------------+\r\n" +
                   "|Nom\t\t|Superfamília\t|Espècie\t|Pes aproximat\t|\r\n" +
                   "+---------------------------------------------------------------+\r\n" +
                   "|{0}\t|{1}\t|{2}\t|{3}\t\t|\r\n" +
                   "+---------------------------------------------------------------+";

            // Act
            string result = cetacean.ToString();

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestCetaceanCalcNewGA()
        {
            // Arrange
            Cetacean cetacean = new Cetacean("Tony", 1, "Balena", 50, 100);
            int option = 1;
            bool expected = false;

            // Act
            bool result = cetacean.CalcNewGA(option);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestCetaceanShowGA()
        {
            // Arrange
            Cetacean cetacean = new Cetacean("Tony", 1, "Balena", 10, 20.5);
            string expected = "El cetaci té un grau d'acceptació del 10%. ";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                cetacean.ShowGA();

                // Assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void TestGameTitle()
        {
            // Arrange
            string expected = "-------------------------------\r\n" +
                              "\tSave the Ocean!\r\n" +
                              "-------------------------------\r\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Game.Title();

                // Assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void TestGameChooseStartOption()
        {
            // Arrange
            string expected = "Què vols fer?\r\n" +
                              "1. Jugar!\r\n" +
                              "2. Sortir\r\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Game.ChooseStartOption();

                // Assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void TestGameChooseOccupation()
        {
            // Arrange
            string expected = "Que vols ser?\r\n" +
                              "1. Tècnic (45 XP)\r\n" +
                              "2. Veterinari (80 XP)\r\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Game.ChooseOccupation();

                // Assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void TestGameInsertNameMsg()
        {
            // Arrange
            string expected = "Com et dius?\r\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Game.InsertNameMsg();

                // Assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void TestGameRescueCallMsg()
        {
            // Arrange
            Player player = new Player("Pol", 1, 45);
            string expected = "Hola, Pol! El 112 ha rebut una trucada d’avís d’un exemplar a rescatar. \r\nLes dades que ens han donat són les següents:\r\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Game.RescueCallMsg(player);

                // Assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void TestGameAnimalInfoMsg()
        {
            // Arrange
            string expected = "Aquí tens la seva fitxa, per a més informació:\r\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Game.AnimalInfoMsg();

                // Assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void TestGameChooseOption()
        {
            // Arrange
            string expected = "Què vols fer?\r\n" +
                "1. Curar aquí\r\n" +
                "2. Traslladar al centre\r\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Game.ChooseOption();

                // Assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void TestGameValidateOption()
        {
            // Arrange
            int option = 1;
            bool expected = true;

            // Act
            bool result = Game.ValidateOption(option);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestGameValidateStartGame()
        {
            // Arrange
            int option = 1;
            bool expected = true;

            // Act
            bool result = Game.ValidateStartGame(option);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestGameValidateEndGame()
        {
            // Arrange
            int option = 2;
            bool expected = true;

            // Act
            bool result = Game.ValidateEndGame(option);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestGameRandom()
        {
            // Arrange
            int max = 3;

            // Act
            int resultNum = Game.Random(max);

            // Assert
            Assert.IsTrue(resultNum >= 0 && resultNum <= max);
        }
        [TestMethod]
        public void TestGameRandomMinMax()
        {
            // Arrange
            int min = 1;
            int max = 3;

            // Act
            int resultNum = Game.Random(min, max);

            // Assert
            Assert.IsTrue(resultNum >= min && resultNum <= max);
        }
        [TestMethod]
        public void TestGameRandomDouble()
        {
            // Arrange
            double min = 1;
            double max = 3;

            // Act
            double resultNum = Game.RandomDouble(min, max);

            // Assert
            Assert.IsTrue(resultNum >= min && resultNum <= max);
        }
        [TestMethod]
        public void TestGameRescueSuccessTurtle()
        {
            // Arrange
            SeaTurtle seaTurtle = new SeaTurtle("Leonardo", 1, "Tortuga Verda", 10, 20.5);
            string expectedOutput = "El tractament aplicat ha reduït el GA fins al 10%. L’exemplar està recuperat i pot tornar al seu hàbitat. \r\nLa teva experiència ha augmentat en +45XP.\r\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Game.RescueSuccess(seaTurtle);

                // Assert
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }
        [TestMethod]
        public void TestGameRescueFailureTurtle()
        {
            // Arrange
            SeaTurtle seaTurtle = new SeaTurtle("Leonardo", 1, "Tortuga Verda", 50, 100);
            string expected = "El tractament aplicat ha reduït el GA fins al 50%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. \r\nLa teva experiència s’ha reduït en -20XP.\r\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Game.RescueFailure(seaTurtle);

                // Assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void TestGameRescueSuccessBird()
        {
            // Arrange
            SeaBird seaBird = new SeaBird("Piolín", 1, "Albatros", 50, 100);
            string expectedOutput = "El tractament aplicat ha reduït el GA fins al 50%. L’exemplar està recuperat i pot tornar al seu hàbitat. \r\nLa teva experiència ha augmentat en +45XP.\r\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Game.RescueSuccess(seaBird);

                // Assert
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }
        [TestMethod]
        public void TestGameRescueFailureBird()
        {
            // Arrange
            SeaBird seaBird = new SeaBird("Piolín", 1, "Albatros", 50, 100);
            string expected = "El tractament aplicat ha reduït el GA fins al 50%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. \r\nLa teva experiència s’ha reduït en -20XP.\r\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Game.RescueFailure(seaBird);

                // Assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void TestGameRescueSuccessCetacean()
        {
            // Arrange
            Cetacean cetacean = new Cetacean("Tony", 1, "Balena", 50, 100);
            string expectedOutput = "El tractament aplicat ha reduït el GA fins al 50%. L’exemplar està recuperat i pot tornar al seu hàbitat. \r\nLa teva experiència ha augmentat en +45XP.\r\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Game.RescueSuccess(cetacean);

                // Assert
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }
        [TestMethod]
        public void TestGameRescueFailureCetacean()
        {
            // Arrange
            Cetacean cetacean = new Cetacean("Tony", 1, "Balena", 50, 100);
            string expected = "El tractament aplicat ha reduït el GA fins al 50%. No ha estat prou efectiu i cal traslladar l’exemplar al centre. \r\nLa teva experiència s’ha reduït en -20XP.\r\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Game.RescueFailure(cetacean);

                // Assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void TestGameRescueEnd()
        {
            // Arrange
            string expected = "Fins al proper rescat! (Prem qualsevol tecla per continuar)\r\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Game.RescueEnd();

                // Assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void TestGameEndGame()
        {
            // Arrange
            string expected = "Gràcies per jugar!\r\n";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Game.EndGame();

                // Assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
    }
}