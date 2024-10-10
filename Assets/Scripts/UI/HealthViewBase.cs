using UnityEngine;

namespace Game.UI
{
    public abstract class HealthViewBase : MonoBehaviour
    {
        public abstract void SetHealthInfo(int health, int maxHealth);
        public abstract void SetCurrentHealth(int health);
    }
}