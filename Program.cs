
using schoolApp.Entities;

namespace namespacesModularity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soldier s = new Soldier(); // problem! soldier is not part of this namespace
            // fix: using army

            // school
            // if i want to import a student class - i can import it 
            //  with the specific module from schoolApp namespace
            Student student = new Student();
            student.annoy();
            
        }
    }
}
