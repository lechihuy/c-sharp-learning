using Learning;

GenericList<int> list = new GenericList<int>();

for (int x = 0; x < 10; x++)
{
    list.AddHead(x);
}

foreach (int i in list)
{
    System.Console.Write(i + " ");
}
System.Console.WriteLine("\nDone");