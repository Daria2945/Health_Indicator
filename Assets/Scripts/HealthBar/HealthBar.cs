using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Character _character;

    protected Character Character => _character;

    private void Awake()
    {
        UpdateValue(_character.MaxHealth);
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable HealthBar");
        _character.Health.ChangedValue += UpdateValue;

    }

    private void OnDisable()
    {
        _character.Health.ChangedValue -= UpdateValue;
    }

    protected virtual void UpdateValue(int currentHealth) { }
}