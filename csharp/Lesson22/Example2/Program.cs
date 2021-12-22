using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {

            var gamesInfo = GetGamesInfo();

            for (int i = 0; i < gamesInfo.Count; i++)
            {
                Console.WriteLine($"{gamesInfo[i].TypeOfGame}:");
                
                for (int j = 0; j < gamesInfo[i].Games.Count; j++)
                {
                    Console.WriteLine($" {gamesInfo[i].Games[j].Name}");
                }
                Console.WriteLine();
            }
            
         
            static List<GameInfo> GetGamesInfo()
            {
                return new List<GameInfo>()
                {
                    new GameInfo ()
                    {
                        TypeOfGame = GameType.RPG,
                        Games = new List<Game>()
                        {
                            new Game(){ Name = "Fallout 4"},
                            new Game(){ Name = "Gothic 2" },
                            new Game(){ Name = "Morrowind"}

                        }
                    },
                    new GameInfo ()
                    {
                        TypeOfGame = GameType.Shooter,
                        Games = new List<Game>()
                        {
                            new Game(){ Name = "CS"},
                            new Game(){ Name = "BF4" },
                            new Game(){ Name = "Doom"}

                        }
                    },
                    new GameInfo ()
                    {
                        TypeOfGame = GameType.Strategy,
                        Games = new List<Game>()
                        {
                            new Game(){ Name = "Civilization"},
                            new Game(){ Name = "Rome" },
                            new Game(){ Name = "Starcraft"}

                        }
                    }

                };

            }
        }
    }
}
