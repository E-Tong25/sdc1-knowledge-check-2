Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Rock>();
for (int i = 0; i<numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var rock = new Rock();

    Console.WriteLine("Enter the name of the rock record.");
    rock.Name = Console.ReadLine();
    Console.WriteLine("Enter the value for price of the rock record.");
    rock.Price = int.Parse(Console.ReadLine());
    Console.WriteLine("Is this a metal rock record?");
    rock.IsMetal = Console.ReadLine();

    recordList.Add(rock);
}

// Prints out the list of records using Console.WriteLine()

Console.WriteLine(recordList.ToString());

Console.ReadLine();

foreach (var rock in recordList)
{
    Console.WriteLine($"Name: {rock.Name}, Price: {rock.Price}, Is Metal: {rock.IsMetal}");
}
Console.ReadLine();