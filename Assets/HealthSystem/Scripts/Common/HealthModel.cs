using System;
using UnityEngine;


public class HealthModel : MonoBehaviour
{
    public event Action HealthChanged;
    
    public int Health { get; private set; }

    [SerializeField] private int _maxHealth;
    
    public int MaxHealth => _maxHealth;
    
    public void Init()
    {
        Health = _maxHealth;
    }
    
    public void TakeDamage(int damage)
    {
        if (damage < 0)
            damage = 0;
        
        Health -= damage;

        if (Health < 0)
            Health = 0;
        
        Debug.Log("Получен урон!");
        Debug.Log($"Здоровье: {Health}");
        
        HealthChanged?.Invoke();
    }

    public void TakeHeal(int heal)
    {
        if (heal < 0)
            throw new Exception("Лечение не может быть отрицательным");

        Health += heal;

        ClampHealth();
        HealthChanged?.Invoke();
    }

    private void ClampHealth()
    {
        if (Health > _maxHealth)
            Health = _maxHealth;
    }
}