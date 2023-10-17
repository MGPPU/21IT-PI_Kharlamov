namespace Task_2
{
    public class UnitList : List<Unit>
    {
        // 1.	Все юниты получают урон в соответствии с удалением от взрыва. 
        // Вывести на экран список полностью уничтоженных юнитов (т.е., здоровье упало до нуля).

        public void Detonation(float ExplosionPower)
        {
            foreach (var element in this)
            {
                element.Health = element.RemainingHealth(element.DistanceToExplosion, ExplosionPower);
                if (element.Health == 0) { Console.WriteLine($"Юнит {element.GetType().Name} уничтожен в {element.DistanceToExplosion} у.е. от места взрыва"); };
            }
        }
    }

}