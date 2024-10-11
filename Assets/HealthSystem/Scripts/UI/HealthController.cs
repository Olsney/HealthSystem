using UnityEngine;

namespace Game.UI
{
    public class HealthController : MonoBehaviour
    {
        [SerializeField] private HealthModel _healthModel;

        public void TakeDamage(int damage)
        {
            _healthModel.TakeDamage(damage);
        }

        public void TakeHeal(int heal)
        {
            _healthModel.TakeHeal(heal);
        }
    }
}