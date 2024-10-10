using Game.UI;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDamage : MonoBehaviour
{
    [SerializeField] private HealthController _healthController;
    [SerializeField] private Button _button;
    [SerializeField] private int _damage = 10;

    private void OnEnable()
    {
        _button.onClick.AddListener(TakeDamage);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(TakeDamage);
    }

    private void TakeDamage()
    {
        _healthController.TakeDamage(_damage);
    }
}