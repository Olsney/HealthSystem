using Game.UI;
using UnityEngine;
using UnityEngine.UI;

public class InstantHealthbar : HealthViewBase
{
    [SerializeField] private Image _image;
    
    private int _maxHealth;
    
    public override void SetHealthInfo(int health, int maxHealth)
    {
        _maxHealth = maxHealth;
        _image.fillAmount = health / maxHealth;

        Debug.Log($"Быстрый хелсбар заполнился - оно стало {_image.fillAmount}");
    }

    public override void SetCurrentHealth(int health)
    {
        _image.fillAmount = (float)health / _maxHealth;
        Debug.Log($"Значение здоровья картины {_image.fillAmount}");
    }
}