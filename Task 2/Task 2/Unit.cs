namespace Task_2
{
    public abstract class Unit
    {
        public Unit(float Health, float DistanceToExplosion)
        {
            this.Health = Health;
            this.DistanceToExplosion = DistanceToExplosion;
        }
        private float _health;
        public float Health
        {
            get { return _health; }

            // Ограничение, чтобы нельзя было выйти в отрицательные значения по кол-ву здоровья
            set { _health = float.IsPositive(value) ? value : 0; }
        }
        public float DistanceToExplosion { get; set; }
        public abstract float RemainingHealth(float Distance, float ExplosionPower);
    }

}
