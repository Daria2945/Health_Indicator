using System;

public class Health
{
    private int _maxValue;
    private int _currentValue;
    private int _minValue;

    public event Action<int> ChangedValue;

    public Health(int maxValue)
    {
        if (maxValue <= 0)
        {
            _maxValue = 1;
            _currentValue = _maxValue;

            return;
        }

        _maxValue = maxValue;
        _currentValue = maxValue;
        _minValue = 0;
    }

    public void TakeDamage(int damage)
    {
        int nextValue = _currentValue - damage;

        if (nextValue > _minValue)
            _currentValue = nextValue;
        else
            _currentValue = _minValue;

        ChangedValue?.Invoke(_currentValue);
    }

    public void ReceiveTreatment(int healUnits)
    {
        int nextValue = _currentValue + healUnits;

        if(nextValue < _maxValue)
            _currentValue = nextValue;
        else
            _currentValue = _maxValue;

        ChangedValue?.Invoke(_currentValue);
    }
}