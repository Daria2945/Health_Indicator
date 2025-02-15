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
        Debug.Log("Awake character, health");
    }

    public void TakeDamage(int damage)
    {
        Health.TakeDamage(damage);
    }

    public void ReceiveTreatment(int unitHealth)
    {
        Health.ReceiveTreatment(unitHealth);
    }
}