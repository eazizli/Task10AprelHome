using Task10Aprel.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Tree tree = new Tree()
        {
            Fruits = new Fruit[] 
            { new Fruit{Name="alma"},
            new Fruit{Name ="heyva"},
            new Fruit{Name="nar"}
            }
        };

        Console.WriteLine(tree[5].Name);


    }
}