namespace Task_2
{
    public class Tank : Unit
    {
        public Tank(float Health, float Arrmor, float DistanceToExplosion) : base(Health, DistanceToExplosion)
        {
            this.Arrmor = Arrmor;
        }
        public float Arrmor { get; set; }
        public override float RemainingHealth(float Distance, float ExplosionPower)
        {
            // 1.	Рассчитать оставшееся здоровье. Параметры – дистанция и сила взрыва. 
            // Урон рассчитывается по формуле – сила взрыва/дистанция. Урон уменьшается на X процентов, 
            // где X – значение свойства «Броня». Затем урон вычитается из здоровья. 
            // Оставшееся здоровье возвращается как результат работы метода.
            return this.Health - ((ExplosionPower / Distance) * (1 - (this.Arrmor * (float)0.01)));
        }
    }

}

