using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Ghost : IEntity, IDisappearable
    {
        public string Name { get; set; }

        //IEntity Action methods
        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} with a chilling touch.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} floats silently.");
        }
        public void Dodge()
        {
            Console.WriteLine($"{Name} dodges to avoid the attack.");
        }
        public void CounterAttack(IEntity target)
        {
            Console.WriteLine($"{Name} counter attacks {target.Name} with a chilling touch.");
        }
        //Custom action methods
        public void Disappear()
        {
            Console.WriteLine($"{Name} disappears out of sight.");
        }
    }
}
