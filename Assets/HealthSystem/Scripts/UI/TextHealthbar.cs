using TMPro;
using UnityEngine;

namespace Game.UI
{
    public class TextHealthbar : HealthViewBase
    {
        [SerializeField] private TextMeshProUGUI _text;
        
        private int _maxHealth;

        public override void SetHealthInfo(int health, int maxHealth)
        {
            _maxHealth = maxHealth;
            
            _text.text = $"{health} / {_maxHealth}";
        }

        public override void SetCurrentHealth(int health)
        {
            _text.text = $"{health} / {_maxHealth}";
        }
    }
}