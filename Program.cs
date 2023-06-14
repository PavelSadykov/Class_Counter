
using System;
namespace Задание__8;

class Counter
{
    private static int count = 0;
    private int instanceNumber;

    public Counter()
    {
        count++;
        instanceNumber = count;
    }

    public int GetInstanceNumber()
    {
        return instanceNumber;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Counter counter1 = new Counter();
        Console.WriteLine("Номер экземпляра counter1: " + counter1.GetInstanceNumber());

        Counter counter2 = new Counter();
        Console.WriteLine("Номер экземпляра counter2: " + counter2.GetInstanceNumber());
    }
}
