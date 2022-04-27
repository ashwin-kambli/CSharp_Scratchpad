// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

//Console.WriteLine(new DirectoryComparer().Compare("C:\temp", "C:\temp1"));

BinaryTree bt = new BinaryTree();
bt.Add(3);
bt.Add(31);
bt.Add(2);
bt.Add(23);
bt.Add(15);
bt.Add(9);

bt.Add(1);
bt.Add(-22);
bt.Add(-8);
bt.Add(5);
bt.Add(99);

bt.Print();

Console.WriteLine("Tree Contains 2: {0}", bt.Search(2));
Console.WriteLine("Tree Contains 25: {0}", bt.Search(25));