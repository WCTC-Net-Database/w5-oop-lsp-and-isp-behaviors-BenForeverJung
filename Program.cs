using Microsoft.Extensions.DependencyInjection;
using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;
using W5_assignment_template.Services;

namespace W5_assignment_template
{
    class Program
    {       
        static void Main(string[] args)
        {
            var character = new Character();
            var goblin = new Goblin();
            var ghost = new Ghost();
            var banshee = new Banshee();
            var werewolf = new Werewolf();
            var vampire = new Vampire();

            var gameEngine = new GameEngine(character, goblin, ghost, banshee, werewolf, vampire);
            gameEngine?.Run();
        }

    }
}
