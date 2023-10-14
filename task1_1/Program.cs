
using AnimalClasses.Animals;
using AnimalClasses.AbstractClass;
using System.Xml.Serialization;

class Program{

    public static void Main(){
        Lion myLion = new Lion();
        myLion.Country = "Africa";
        myLion.Name = "Gago";
        myLion.WhatAnimal = eClassificationAnimal.Carnivores;

        XmlSerializer serializer = new XmlSerializer(typeof(Lion));

        using (FileStream outputFile = new FileStream("/home/narek/Documents/C#/lab08/AnimalDiagram.xml", FileMode.OpenOrCreate)){
            serializer.Serialize(outputFile, myLion);
        }
    }
}