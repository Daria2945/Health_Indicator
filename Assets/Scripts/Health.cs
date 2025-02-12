using System;

public class Health
{
    private int _minValue;

    public int CurrentValue { get; private set; }
    public int MaxValue { get; private set; }

    public event Action<int> ChangedValue;

    public Health(int maxValue)
    {
        MaxValue = maxValue;
        CurrentValue = maxValue;
        _minValue = 0;
    }

    public void TakeDamage(int damage)
    {
        int nextValue = CurrentValue - damage;

        if (nextValue > _minValue)
            CurrentValue = nextValue;
        else
            CurrentValue = _minValue;

        ChangedValue?.Invoke(CurrentValue);
    }

    public void Heal(int healUnits)
    {
        int nextValue = CurrentValue + healUnits;

        if(nextValue < MaxValue)
            CurrentValue = nextValue;
        else
            CurrentValue = MaxValue;

        ChangedValue?.Invoke(CurrentValue);
    }
}