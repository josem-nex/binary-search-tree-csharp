namespace BinaryTree;
class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        var binary = new BinaryTree<int>();
        binary.Insert(20);
        binary.Insert(15);
        binary.Insert(30);
        binary.Insert(10);
        binary.Insert(18);
        binary.Insert(27);
        binary.Insert(40);
        binary.Insert(8);
        binary.Insert(12);
        binary.Insert(17);
        binary.Insert(19);
        binary.Insert(25);
        binary.Insert(29);
        binary.Insert(37);
        binary.Insert(45);

        binary.Print();

        System.Console.WriteLine(binary.AssertValidTree());
    }
    
}
