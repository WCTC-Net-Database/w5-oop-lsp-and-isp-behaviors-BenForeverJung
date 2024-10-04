using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Goblin : IEntity, IScurryable
    {
        //IEntity Action methods
        public string Name { get; set; }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} with their Claws.");
        }
        public void Move()
        {
            Console.WriteLine($"{Name} moves forward aggressively.");
        }
        public void Dodge()
        {
            Console.WriteLine($"{Name} dodges to avoid the attack.");
        }
        public void CounterAttack(IEntity target)
        {
            Console.WriteLine($"{Name} counter attacks {target.Name} with their Claws.");
        }
        //Custom action methods
        public void Scurry()
        {
            Console.WriteLine($"{Name} quickly scurries away.");
        }
    }
}
