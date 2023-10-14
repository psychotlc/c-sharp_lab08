using System.Xml.Serialization;
using AnimalClasses.AbstractClass;
using AnimalClasses.Animals;

class Program{

    public static void Main(){
        XmlSerializer serializer = new XmlSerializer(typeof(Lion));
        
        using (FileStream input = new FileStream("/home/narek/Documents/C#/lab08/AnimalDiagram.xml", FileMode.OpenOrCreate)){
            Animal? myLion = serializer.Deserialize(input) as Lion;

            Console.WriteLine($"Lion.Name = {myLion.Name}\nLion.Country = {myLion.Country}");
        }
    } 
}