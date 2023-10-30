namespace Task_2
{
    public class Repair<M, A> where M : Serviceman where A : Automobile
    {
        public Repair(M serviceman, A automobile)
        {
            this.Serviceman = serviceman;
            this.Automobile = automobile;
        }
        public M Serviceman { get; set; }
        public A Automobile { get; set; }
        public void CarRepair()
        {
            Console.WriteLine($"Мастер {Serviceman.Fullname} отремонтировал автомобиль под номером {Automobile.LicensePlate}");
        }
    }

}