using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Character _character;

    protected Character Character => _character;

    private void Start()
    {
        UpdateValue(_character.MaxHealth);

        _character.Health.ChangedValue += UpdateValue;
    }

    private void OnDisable()
    {
        _character.Health.ChangedValue -= UpdateValue;
    }

    protected virtual void UpdateValue(int currentHealth) { }
}