using System;
namespace PR1_Save_the_Ocean
{
    class Program
    {
        static void Main()
        {
            int startMenuOption, occupacionOption, rescueOption, typeAnimal;
            Player player = new Player();

            do
            {
                Game.Title();
                Console.WriteLine();
                do
                {
                    Game.ChooseStartOption();
                    startMenuOption = Convert.ToInt32(Console.ReadLine());
                } while (!Game.ValidateOption(startMenuOption));
                Console.Clear();
                if (Game.ValidateStartGame(startMenuOption))
                {
                    if (player.Name == null)
                    {
                        do
                        {
                            Game.ChooseOccupation();
                            occupacionOption = Convert.ToInt32(Console.ReadLine());
                        } while (!Game.ValidateOption(occupacionOption));
                        Console.WriteLine();
                        Game.InsertNameMsg();
                        player.Name = Console.ReadLine();
                        player.Occupation = (Occupation)occupacionOption;
                        player.Exp = occupacionOption == 1 ? 45 : 80;
                        Console.Clear();
                    }
                    Game.RescueCallMsg(player);
                    typeAnimal = Game.Random(3);
                    Console.WriteLine();
                    if (typeAnimal == 0)
                    {
                        SeaTurtle seaTurtle = new SeaTurtle(SeaTurtle.names[Game.Random(4)], 1, SeaTurtle.species[Game.Random(4)], Game.Random(1, 100), Math.Round(Game.RandomDouble(80, 200), 2));
                        Rescue rescue = new Rescue(Rescue.GenerateNumRescue(), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Rescue.locations[Game.Random(4)]);
                        Console.WriteLine(rescue.ToString(), rescue.NumRescue, rescue.Date, seaTurtle.SuperFamily, seaTurtle.GA, rescue.Location);
                        Console.WriteLine();
                        Game.AnimalInfoMsg();
                        Console.WriteLine();
                        Console.WriteLine(seaTurtle.ToString(), seaTurtle.Name, seaTurtle.SuperFamily, seaTurtle.Species, seaTurtle.Weight);
                        Console.WriteLine();
                        seaTurtle.ShowGA();
                        do
                        {
                            Game.ChooseOption();
                            rescueOption = Convert.ToInt32(Console.ReadLine());
                        } while (!Game.ValidateOption(rescueOption));
                        Console.Clear();
                        if (seaTurtle.CalcNewGA(rescueOption))
                        {
                            Game.RescueSuccess(seaTurtle);
                            player.Exp += Game.successXP;
                        }
                        else
                        {
                            Game.RescueFailure(seaTurtle);
                            player.Exp -= Game.failureXP;
                        }
                    }
                    else if (typeAnimal == 1)
                    {
                        SeaBird seaBird = new SeaBird(SeaBird.names[Game.Random(4)], 2, SeaBird.species[Game.Random(4)], Game.Random(1, 100), Math.Round(Game.RandomDouble(10, 80), 2));
                        Rescue rescue = new Rescue(Rescue.GenerateNumRescue(), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Rescue.locations[Game.Random(4)]);
                        Console.WriteLine(rescue.ToString(), rescue.NumRescue, rescue.Date, seaBird.SuperFamily, seaBird.GA, rescue.Location);
                        Console.WriteLine();
                        Game.AnimalInfoMsg();
                        Console.WriteLine();
                        Console.WriteLine(seaBird.ToString(), seaBird.Name, seaBird.SuperFamily, seaBird.Species, seaBird.Weight);
                        Console.WriteLine();
                        seaBird.ShowGA();
                        do
                        {
                            Game.ChooseOption();
                            rescueOption = Convert.ToInt32(Console.ReadLine());
                        } while (!Game.ValidateOption(rescueOption));
                        Console.Clear();
                        if (seaBird.CalcNewGA(rescueOption))
                        {
                            Game.RescueSuccess(seaBird);
                            player.Exp += Game.successXP;
                        }
                        else
                        {
                            Game.RescueFailure(seaBird);
                            player.Exp -= Game.failureXP;
                        }
                    }
                    else
                    {
                        Cetacean cetacean = new Cetacean(Cetacean.names[Game.Random(4)], 3, Cetacean.species[Game.Random(4)], Game.Random(1, 100), Math.Round(Game.RandomDouble(100, 100000), 2));
                        Rescue rescue = new Rescue(Rescue.GenerateNumRescue(), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Rescue.locations[Game.Random(4)]);
                        Console.WriteLine(rescue.ToString(), rescue.NumRescue, rescue.Date, cetacean.SuperFamily, cetacean.GA, rescue.Location);
                        Console.WriteLine();
                        Game.AnimalInfoMsg();
                        Console.WriteLine();
                        Console.WriteLine(cetacean.ToString(), cetacean.Name, cetacean.SuperFamily, cetacean.Species, cetacean.Weight);
                        Console.WriteLine();
                        cetacean.ShowGA();
                        do
                        {
                            Game.ChooseOption();
                            rescueOption = Convert.ToInt32(Console.ReadLine());
                        } while (!Game.ValidateOption(rescueOption));
                        Console.Clear();
                        if (cetacean.CalcNewGA(rescueOption))
                        {
                            Game.RescueSuccess(cetacean);
                            player.Exp += Game.successXP;
                        }
                        else
                        {
                            Game.RescueFailure(cetacean);
                            player.Exp -= Game.failureXP;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine(player.ToString(), player.Name, player.Occupation, player.Exp);
                    Console.WriteLine();
                    Game.RescueEnd();
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!Game.ValidateEndGame(startMenuOption));
            Game.EndGame();
        }
    }
}