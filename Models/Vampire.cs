using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class Vampire : IEntity, IFlyable
{
    public string Name { get; set; }

    //IEntity Action methods
    public void Attack(IEntity target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} with a piercing bite to the neck.");
    }

    public void Move()
    {
        Console.WriteLine($"A bat flies in and transforms into a {Name}.");
    }
    public void Dodge()
    {
        Console.WriteLine($"{Name} dodges to avoid the attack.");
    }
    public void CounterAttack(IEntity target)
    {
        Console.WriteLine($"{Name} counter attacks {target.Name} with a piercing bite to the neck.");

    }
    //Custom action methods
    public void Fly()
    {
        Console.WriteLine($"{Name} transforms back to a bat and flies away.");
    }


}