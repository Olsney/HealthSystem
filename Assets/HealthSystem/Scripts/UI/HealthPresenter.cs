using UnityEngine;

namespace Game.UI
{
    public class HealthPresenter : MonoBehaviour
    {
        [SerializeField] private HealthModel _healthModel;
        [SerializeField] private HealthViewBase[] _healthView;

        private void OnEnable()
        {
            _healthModel.HealthChanged += OnHealthChanghed;
        }

        private void OnDisable()
        {
            _healthModel.HealthChanged -= OnHealthChanghed;
        }


        private void OnHealthChanghed()
        {
            Debug.Log("Устанавливаем значения здоровья во вью");
            
            foreach (var healthView in _healthView)
            {
                healthView.SetCurrentHealth(_healthModel.Health);
            }
        }

        public void Init()
        {
            foreach (var healthView in _healthView)
            {
                healthView.SetHealthInfo(_healthModel.MaxHealth, _healthModel.Health);
            }
        }
    }
}