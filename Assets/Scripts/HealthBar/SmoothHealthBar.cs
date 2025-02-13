using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBar : HealthBar
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _smoothStep;

    private Coroutine _coroutine;
    private bool _isWorkCoroutine;

    protected override void UpdateValue(int currentHealth)
    {
        if (_isWorkCoroutine)
        {
            if (_coroutine != null)
                StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(UpdatingValue(currentHealth));
    }

    private IEnumerator UpdatingValue(int currentHealth)
    {
        float nextValue = (float)currentHealth / Character.MaxHealth;

        while (_slider.value != nextValue)
        {
            _isWorkCoroutine = _slider.value != nextValue;
            _slider.value = Mathf.MoveTowards(_slider.value, nextValue, _smoothStep * Time.deltaTime);

            yield return null;
        }

        _isWorkCoroutine = false;
    }
}