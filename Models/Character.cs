using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class Character : IEntity, ILootable
{
    public string Name { get; set; }

    //IEntity Action methods
    public void Attack(IEntity target)
    {
        Console.WriteLine($"Sir {Name} attacks {target.Name} with their sword");
    }

    public void Move()
    {
        Console.WriteLine($"Sir {Name} bravely moves forward.");
    }
    public void Dodge()
    {
        Console.WriteLine($"Sir {Name} dodges to avoid the attack.");
    }

    public void CounterAttack(IEntity target)
    {
        Console.WriteLine($"Sir {Name} counter attacks {target.Name} with their sword");
    }
    //Custom action methods

    public void Loot(IEntity target)
    {
        Console.WriteLine($"{Name} loots the body of {target.Name}.");
    }



}
