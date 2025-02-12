using TMPro;
using UnityEngine;

public class TextHealthBar : HealthBar
{
    [SerializeField] private TextMeshProUGUI _text;

    protected override void UpdateValue(int currentHealth)
    {
        _text.text = currentHealth + "/" + Character.MaxHealth;
    }
}