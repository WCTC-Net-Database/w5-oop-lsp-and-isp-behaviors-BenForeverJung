using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Transactions;
using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _banshee;
        private readonly IEntity _werewolf;
        private readonly IEntity _vampire;

        public bool _randomBool;


        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity banshee, IEntity werewolf, IEntity vampire)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _banshee = banshee;
            _werewolf = werewolf;
            _vampire = vampire;
            
        }

        // set global variables
        int playerGameScore = 0;
        int characterBattleScore = 0;
        int opponentBattleScore = 0;
        Random random = new();

        public void Run()
        {

            var playgame = "1";
            while (playgame == "1")
            {
                playerGameScore = 0;
                // Introduce the game and get the users Name
                Console.WriteLine("******  Welcome to The Gauntlet  ******");
                Console.WriteLine(
                    "Beat 3 of my 5 monsters you will become a Gauntlet Champion and receive a Gauntlet Champion Token.");
                Console.WriteLine(
                    "A Gauntlet Champion Token will allow you free passage through the Haunted Forest for your lifetime.");
                Console.WriteLine(
                    $"There is no mercy in the Gauntlet and you must battle all 5 monsters. The first to land 2 attacks wins the battle");
                Console.WriteLine();
                Console.WriteLine("What is your name brave knight?");
                var userName = Console.ReadLine();
                Console.WriteLine($"Hello Sir {userName}, let us begin the battles");
                Console.WriteLine();
                Console.WriteLine(
                    "--------------------------------------------------------------------------------------------------");
                Console.WriteLine();
                //  apply characters names
                _character.Name = userName;
                _goblin.Name = "Goblin";
                _ghost.Name = "Ghost";
                _banshee.Name = "Banshee";
                _werewolf.Name = "Werewolf";
                _vampire.Name = "Vampire";

                // process through the battles
                _character.Move();

                BattleGoblin();
                BattleGhost();
                BattleBanshee();
                BattleWerewolf();
                BattleVampire();

                if (playerGameScore >= 3)
                {
                    Console.WriteLine(
                        "**********************************************************************************************************");
                    Console.WriteLine();
                    Console.WriteLine(
                        $"Congratulations Sir {_character.Name}, you have won {playerGameScore} of the 5 battles!");
                    Console.WriteLine(
                        $"I Present you with this Gauntlet Champion Token, which grants you passage through the Haunted Forest for your lifetime!");
                    Console.WriteLine($"Long Live the Gauntlet Champion Sir {_character.Name}!");
                    Console.WriteLine();
                    Console.WriteLine(
                        "**********************************************************************************************************");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(
                        "**********************************************************************************************************");
                    Console.WriteLine();
                    Console.WriteLine($"Sir {_character.Name} you have won {playerGameScore} of the 5 battles.");
                    Console.WriteLine(
                        $"You have not achieved the minimum victories to receive the Gauntlet Champion Token.");
                    Console.WriteLine(
                        $"Entering the Haunted Forest without the Gauntlet Champion Token will result in certain peril or DEATH!");
                    Console.WriteLine();
                    Console.WriteLine(
                        "**********************************************************************************************************");
                    Console.WriteLine();
                }

                Console.WriteLine("Press 1 and Enter to play again or 2 and Enter to exit");
                playgame = Console.ReadLine();
            }
        }
        public void BattleGoblin()
        {
            _goblin.Move();
            Console.WriteLine($"you will now battle the {_goblin.Name}. Press Enter to Begin.");
            Console.ReadLine();
            Console.WriteLine();
            while (characterBattleScore < 2 && opponentBattleScore < 2)
            {
                bool randomBool = random.Next(2) == 1;

                randomBool = random.Next(2) == 1;
                if (randomBool == true)
                {
                    randomBool = random.Next(2) == 1;
                    if (randomBool == true)
                    {
                        _character.Attack(_goblin);
                        Console.WriteLine("Attack lands and scores a point");
                        characterBattleScore++;
                    }
                    else
                    {
                        _character.Attack(_goblin);
                        _goblin.Dodge();
                        _goblin.CounterAttack(_character);
                        Console.WriteLine("Counter attack lands and scores a point");
                        opponentBattleScore++;
                    }
                }
                else
                {
                    randomBool = random.Next(2) == 1;
                    if (randomBool == true)
                    {
                        _goblin.Attack(_character);
                        Console.WriteLine("Attack lands and scores a point");
                        opponentBattleScore++;
                    }
                    else
                    {
                        _goblin.Attack(_character);
                        _character.Dodge();
                        _character.CounterAttack(_goblin);
                        Console.WriteLine("Counter attack lands and scores a point");
                        characterBattleScore++;
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            if (characterBattleScore == 2)
            {
                Console.WriteLine(
                    $"{_character.Name} Wins the Battle, {characterBattleScore} to {opponentBattleScore}!");
                playerGameScore++;
                ((Goblin)_goblin).Scurry();
            }
            else
            {
                Console.WriteLine(
                    $"{_character.Name} Loses the Battle, {characterBattleScore} to {opponentBattleScore}!");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            //Clear battle scores
            characterBattleScore = 0;
            opponentBattleScore = 0;
        }

        public void BattleGhost()
        {
            _ghost.Move();
            Console.WriteLine($"you will now battle the {_ghost.Name}. Press Enter to Begin.");
            Console.ReadLine();
            Console.WriteLine();
            while (characterBattleScore < 2 && opponentBattleScore < 2)
            {
                bool randomBool = random.Next(2) == 1;

                randomBool = random.Next(2) == 1;
                if (randomBool == true)
                {
                    randomBool = random.Next(2) == 1;
                    if (randomBool == true)
                    {
                        _character.Attack(_ghost);
                        Console.WriteLine("Attack lands and scores a point");
                        characterBattleScore++;
                    }
                    else
                    {
                        _character.Attack(_ghost);
                        _ghost.Dodge();
                        _ghost.CounterAttack(_character);
                        Console.WriteLine("Counter attack lands and scores a point");
                        opponentBattleScore++;
                    }
                }
                else
                {
                    randomBool = random.Next(2) == 1;
                    if (randomBool == true)
                    {
                        _ghost.Attack(_character);
                        Console.WriteLine("Attack lands and scores a point");
                        opponentBattleScore++;
                    }
                    else
                    {
                        _ghost.Attack(_character);
                        _character.Dodge();
                        _character.CounterAttack(_ghost);
                        Console.WriteLine("Counter attack lands and scores a point");
                        characterBattleScore++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            if (characterBattleScore == 2)
            {
                Console.WriteLine($"{_character.Name} Wins the Battle, {characterBattleScore} to {opponentBattleScore}!");
                playerGameScore++;
                ((Ghost)_ghost).Disappear();
            }
            else
            {
                Console.WriteLine($"{_character.Name} Loses the Battle, {characterBattleScore} to {opponentBattleScore}!");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            //Clear battle scores
            characterBattleScore = 0;
            opponentBattleScore = 0;
        }
        
        public void BattleBanshee()
        {
            _banshee.Move();
            Console.WriteLine($"you will now battle the {_banshee.Name}. Press Enter to Begin.");
            Console.ReadLine();
            Console.WriteLine();
            while (characterBattleScore < 2 && opponentBattleScore < 2)
            {
                bool randomBool = random.Next(2) == 1;

                randomBool = random.Next(2) == 1;
                if (randomBool == true)
                {
                    randomBool = random.Next(2) == 1;
                    if (randomBool == true)
                    {
                        _character.Attack(_banshee);
                        Console.WriteLine("Attack lands and scores a point");
                        characterBattleScore++;
                    }
                    else
                    {
                        _character.Attack(_banshee);
                        _banshee.Dodge();
                        _banshee.CounterAttack(_character);
                        Console.WriteLine("Counter attack lands and scores a point");
                        opponentBattleScore++;
                    }
                }
                else
                {
                    randomBool = random.Next(2) == 1;
                    if (randomBool == true)
                    {
                        _banshee.Attack(_character);
                        Console.WriteLine("Attack lands and scores a point");
                        opponentBattleScore++;
                    }
                    else
                    {
                        _banshee.Attack(_character);
                        _character.Dodge();
                        _character.CounterAttack(_banshee);
                        Console.WriteLine("Counter attack lands and scores a point");
                        characterBattleScore++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            if (characterBattleScore == 2)
            {
                Console.WriteLine($"{_character.Name} Wins the Battle, {characterBattleScore} to {opponentBattleScore}!");
                playerGameScore++;
                ((Banshee)_banshee).Fly();
            }
            else
            {
                Console.WriteLine($"{_character.Name} Loses the Battle, {characterBattleScore} to {opponentBattleScore}!");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            //Clear battle scores
            characterBattleScore = 0;
            opponentBattleScore = 0;
        }

        public void BattleWerewolf()
        {
            _werewolf.Move();
            Console.WriteLine($"you will now battle the {_werewolf.Name}. Press Enter to Begin.");
            Console.ReadLine();
            Console.WriteLine();
            while (characterBattleScore < 2 && opponentBattleScore < 2)
            {
                bool randomBool = random.Next(2) == 1;

                randomBool = random.Next(2) == 1;
                if (randomBool == true)
                {
                    randomBool = random.Next(2) == 1;
                    if (randomBool == true)
                    {
                        _character.Attack(_werewolf);
                        Console.WriteLine("Attack lands and scores a point");
                        characterBattleScore++;
                    }
                    else
                    {
                        _character.Attack(_werewolf);
                        _werewolf.Dodge();
                        _werewolf.CounterAttack(_character);
                        Console.WriteLine("Counter attack lands and scores a point");
                        opponentBattleScore++;
                    }
                }
                else
                {
                    randomBool = random.Next(2) == 1;
                    if (randomBool == true)
                    {
                        _werewolf.Attack(_character);
                        Console.WriteLine("Attack lands and scores a point");
                        opponentBattleScore++;
                    }
                    else
                    {
                        _werewolf.Attack(_character);
                        _character.Dodge();
                        _character.CounterAttack(_werewolf);
                        Console.WriteLine("Counter attack lands and scores a point");
                        characterBattleScore++;
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            if (characterBattleScore == 2)
            {
                Console.WriteLine(
                    $"{_character.Name} Wins the Battle, {characterBattleScore} to {opponentBattleScore}!");
                playerGameScore++;
                ((Werewolf)_werewolf).Scurry();
            }
            else
            {
                Console.WriteLine(
                    $"{_character.Name} Loses the Battle, {characterBattleScore} to {opponentBattleScore}!");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            //Clear battle scores
            characterBattleScore = 0;
            opponentBattleScore = 0;
        }

        public void BattleVampire()
        {
            _vampire.Move();
            Console.WriteLine($"you will now battle the {_vampire.Name}. Press Enter to Begin.");
            Console.ReadLine();
            Console.WriteLine();
            while (characterBattleScore < 2 && opponentBattleScore < 2)
            {
                bool randomBool = random.Next(2) == 1;

                randomBool = random.Next(2) == 1;
                if (randomBool == true)
                {
                    randomBool = random.Next(2) == 1;
                    if (randomBool == true)
                    {
                        _character.Attack(_vampire);
                        Console.WriteLine("Attack lands and scores a point");
                        characterBattleScore++;
                    }
                    else
                    {
                        _character.Attack(_vampire);
                        _vampire.Dodge();
                        _vampire.CounterAttack(_character);
                        Console.WriteLine("Counter attack lands and scores a point");

                        opponentBattleScore++;
                    }
                }
                else
                {
                    randomBool = random.Next(2) == 1;
                    if (randomBool == true)
                    {
                        _vampire.Attack(_character);
                        Console.WriteLine("Attack lands and scores a point");
                        opponentBattleScore++;
                    }
                    else
                    {
                        _vampire.Attack(_character);
                        _character.Dodge();
                        _character.CounterAttack(_vampire);
                        Console.WriteLine("Counter attack lands and scores a point");
                        characterBattleScore++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            if (characterBattleScore == 2)
            {
                Console.WriteLine($"{_character.Name} Wins the Battle, {characterBattleScore} to {opponentBattleScore}!");
                playerGameScore++;
                ((Vampire)_vampire).Fly();
            }
            else
            {
                Console.WriteLine($"{_character.Name} Loses the Battle, {characterBattleScore} to {opponentBattleScore}!");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            //Clear battle scores
            characterBattleScore = 0;
            opponentBattleScore = 0;
        }





        //_character.Move();
        //_character.Dodge();
        //_character.Attack(_goblin);
        //((Character) _character).Loot(_goblin);
        //Console.WriteLine("-------------------------");

        //_goblin.Move();
        //_goblin.Attack(_character);
        //_goblin.Dodge();
        //((Goblin)_goblin).Scurry();
        //Console.WriteLine("-------------------------");


        //_ghost.Move();
        //_ghost.Attack(_character);
        //_ghost.Dodge();
        //((Ghost) _ghost).Disappear();
        //Console.WriteLine("-------------------------");
    }
}
