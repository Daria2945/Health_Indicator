using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private int _maxHealth;

    private Health _health;

    public Health Health => _health;
    public int MaxHealth => _maxHealth;

    private void Awake()
    {
        _health = new Health(_maxHealth);
    }

    public void TakeDamage(int damage)
    {
        Health.TakeDamage(damage);
    }

    public void Heal(int unitHealth)
    {
        Health.Heal(unitHealth);
    }
}