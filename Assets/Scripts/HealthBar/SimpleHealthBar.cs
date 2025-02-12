using UnityEngine;
using UnityEngine.UI;

public class SimpleHealthBar : HealthBar
{
    [SerializeField] private Slider _slider;

    protected override void UpdateValue(int currentHealth)
    {
        float nextValue = (float)currentHealth / Character.MaxHealth;

        _slider.value = nextValue;
    }
}