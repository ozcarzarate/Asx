using Investment.Persistance.Migrations;

namespace Investment.Persistance.Console.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new ScriptGenerator();
            var result = generator.Run(null, null);
            System.Console.WriteLine(result);
}
    }
}
