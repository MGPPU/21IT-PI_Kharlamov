namespace Task_2
{
    public class Infantryman : Unit
    {
        public Infantryman(float Health, float DistanceToExplosion) : base(Health, DistanceToExplosion) { }

        public override float RemainingHealth(float Distance, float ExplosionPower)
        {
            // 1.	Рассчитать оставшееся здоровье. Параметры – дистанция и сила взрыва. 
            // Урон рассчитывается по формуле – сила взрыва/дистанция. Урон вычитается из здоровья. 
            // Оставшееся здоровье возвращается как результат работы метода.

            return this.Health - (ExplosionPower / Distance);
        }
    }

}