using System;
using UnityEngine;
using UnityEngine.Serialization;

public class HealthModel : MonoBehaviour
{
    [SerializeField] private int _maxValue;
    
    public event Action Changed;
    
    public int Value { get; private set; }
    public int MaxValue => _maxValue;
    
    public void Init()
    {
        Value = _maxValue;
    }
    
    public void TakeDamage(int damage)
    {
        if (damage < 0)
            damage = 0;
        
        Value -= damage;

        if (Value < 0)
            Value = 0;
        
        Debug.Log("Получен урон!");
        Debug.Log($"Здоровье: {Value}");
        
        Changed?.Invoke();
    }

    public void TakeHeal(int heal)
    {
        if (heal < 0)
            throw new Exception("Лечение не может быть отрицательным");

        Value += heal;

        ClampHealth();
        Changed?.Invoke();
    }

    private void ClampHealth()
    {
        if (Value > _maxValue)
            Value = _maxValue;
    }
}