using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! Lista ligada simple \n");

        var singleList = new SingleList<String>();

        singleList.Add("Juan");
        singleList.Add("Jose");
        singleList.Add("Jan");

        Console.WriteLine(singleList);
    }
}