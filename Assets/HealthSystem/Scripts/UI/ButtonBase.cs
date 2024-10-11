using Game.UI;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public abstract class ButtonBase : MonoBehaviour
    {
        [SerializeField] protected HealthController HealthController;
        [SerializeField] protected Button Button;
        [SerializeField] protected int Value;
        
        private void OnEnable()
        {
            Button.onClick.AddListener(ChangeValue);
        }

        private void OnDisable()
        {
            Button.onClick.RemoveListener(ChangeValue);
        }

        protected abstract void ChangeValue();
    }
}