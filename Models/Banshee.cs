using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class Banshee : IEntity, IFlyable
{
    public string Name { get; set; }

    //IEntity Action methods
    public void Attack(IEntity target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} with a piercing scream.");
    }

    public void Move()
    {
        Console.WriteLine($"{Name} drops down from the sky.");
    }
    public void Dodge()
    {
        Console.WriteLine($"{Name} dodges to avoid the attack.");
    }
    public void CounterAttack(IEntity target)
    {
        Console.WriteLine($"{Name} counter attacks {target.Name} with a piercing scream.");
    }
    //Custom action methods
    public void Fly()
    {
        Console.WriteLine($"{Name} flaps its wings and flies away .");
    }


}