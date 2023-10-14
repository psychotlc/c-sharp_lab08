using AnimalClasses.AbstractClass;
using AnimalClasses.Attributes;

namespace AnimalClasses.classes;

[Comment("This is a Cow")]
public class Cow : Animal
{
    public override eFavoriteFood GetFavoriteFood()
    {
        return eFavoriteFood.Plants;
    }

    public override void SayHello()
    {
        Console.WriteLine("MUUU");
    }
}