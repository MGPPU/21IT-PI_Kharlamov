// See https://aka.ms/new-console-template for more information
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new UnitList{
            new Tank(25,0,0),
            new Tank(25,50,1),
            new Tank(25,100,1000),
            new Infantryman(25,0),
            new Infantryman(1000,1),
            new Infantryman(0,1000),
        };

            List.Detonation(1000);
        }
    }

}
