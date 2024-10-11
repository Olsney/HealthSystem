using UnityEngine;

namespace Game.UI
{
    public class HealthPresenter : MonoBehaviour
    {
        [SerializeField] private HealthModel _healthModel;
        [SerializeField] private HealthViewBase[] _healthView;

        private void OnEnable()
        {
            _healthModel.Changed += OnChanged;
        }

        private void OnDisable()
        {
            _healthModel.Changed -= OnChanged;
        }


        public void Init()
        {
            foreach (var healthView in _healthView)
            {
                healthView.SetHealthInfo(_healthModel.MaxValue, _healthModel.Value);
            }
        }

        private void OnChanged()
        {
            foreach (var healthView in _healthView)
            {
                healthView.SetCurrentHealth(_healthModel.Value);
            }
        }
    }
}