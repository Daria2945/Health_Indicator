using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Character _character;
    [SerializeField] private Image _filling;

    private void Start()
    {
        _character.Health.ChangedValue += ChangeFilling;
    }

    private void OnDisable()
    {
        _character.Health.ChangedValue -= ChangeFilling;
    }

    private void ChangeFilling(int currentHealth)
    {
        float fillValue = (float)currentHealth / _character.MaxHealth;

        _filling.fillAmount = fillValue;
    }
}