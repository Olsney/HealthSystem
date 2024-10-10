namespace Game.UI
{
    public class HealthView : HealthViewBase
    {
        private int _health;
        private int _maxHealth;

        public override void SetHealthInfo(int health, int maxHealth)
        {
            _health = health;
            _maxHealth = maxHealth;
        }

        public override void SetCurrentHealth(int health)
        {
            _health = health;
        }
    }
}