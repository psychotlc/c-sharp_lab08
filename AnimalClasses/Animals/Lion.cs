

using AnimalClasses.AbstractClass;
using AnimalClasses.Attributes;

namespace AnimalClasses.Animals;

[Comment("This is a Lion")]
public class Lion : Animal
{
    public override eFavoriteFood GetFavoriteFood()
    {
        return eFavoriteFood.Meat;
    }

    public override void SayHello()
    {
        Console.WriteLine("RAAAR");
    }
}