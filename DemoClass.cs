using System;

public class DemoClass
{
    public void DictionaryDemo()
    {
        Console.WriteLine("\n---------------Dictionary Demo-------------");

        Dictionary<int, string> objDictionary = new Dictionary<int, string>();
        objDictionary.Add(1, "Person1");
        objDictionary.Add(2, "Person2");
        objDictionary.Add(3, "Person3");

        Console.WriteLine("\nAccess value using key(key=1): " + objDictionary[1]);

        Console.WriteLine("\nIterating Dictionary: ");
        foreach (var element in objDictionary)
        {
            Console.WriteLine($"Key = {element.Key} & Value = {element.Value}");
        }
    }
}
