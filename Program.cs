
namespace namespacesModularity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldier s = new Soldier(); // problem! soldier is not part of this namespace
            // fix: using army
        }
    }
}
