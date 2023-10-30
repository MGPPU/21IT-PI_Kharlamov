namespace Task_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceman = new Serviceman("Виктор Петрович Баринов");
            var automobile = new Automobile("В776УС⁷⁷");
            var rep = new Repair<Serviceman, Automobile>(serviceman, automobile);
            rep.CarRepair();
        }
    }
}