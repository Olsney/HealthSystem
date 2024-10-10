using Game.UI;
using UnityEngine;
using UnityEngine.UI;

namespace World.Environment
{
    public class ButtonHeal : MonoBehaviour
    {
        [SerializeField] private HealthController _healthController;
        [SerializeField] private Button _button;
        [SerializeField] private int _heal;

        public void OnEnable()
        {
            _button.onClick.AddListener(Heal);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(Heal);
        }

        private void Heal()
        {
            _healthController.TakeHeal(_heal);
        }
    }
}