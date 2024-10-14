namespace Assets.Source.Entity.Chimps
{
    internal class Indicators
    {
        private readonly Sense _hunger, _health, _joy;

        public Sense Hunger => _hunger;
        public Sense Health => _health;
        public Sense Joy => _joy;

        public Indicators(float maxHunger = 100, float maxHealth = 100, float maxJoy = 100)
        {
            _hunger = new Sense(maxHunger);
            _health = new Sense(maxHealth);
            _joy = new Sense(maxJoy);
        }
    }
}
