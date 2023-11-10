using GenericsIntro;

internal class Program
{
    private static void Main(string[] args)
    {
        MyList<string> names = new MyList<string>();
        names.Add("alperen");
        Console.WriteLine(names.Length);

        names.Add("mahmut");
        Console.WriteLine(names.Length);


        foreach (var name in names.Items)
        {
            Console.WriteLine(name);
        }
    }
}