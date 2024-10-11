using System.Collections;
using Game.UI;
using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthbar : HealthViewBase
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _delay;
    [SerializeField] private float _changesSpeed;
    
    private int _maxHealth;
    private Coroutine _coroutine;

    public override void SetHealthInfo(int health, int maxHealth)
    {
        _slider.maxValue = maxHealth;
        _slider.value = health;
    }

    public override void SetCurrentHealth(int health)
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }
        
        _coroutine = StartCoroutine(ChangeHealth(health));
    }

    private IEnumerator ChangeHealth(int health)
    {
        WaitForSeconds wait = new WaitForSeconds(_delay);

        while (!Mathf.Approximately(_slider.value, health))
        {
            _slider.value = Mathf.MoveTowards(_slider.value, health, _changesSpeed);

            yield return wait;
        }
    }
}