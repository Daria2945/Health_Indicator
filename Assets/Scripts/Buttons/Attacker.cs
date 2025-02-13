using UnityEngine;

public class Attacker : ActionButton
{
    [SerializeField] private int _damage;

    protected override void OnButtonClick()
    {
        Attack();
    }

    private void Attack()
    {
        Character.TakeDamage(_damage);
    }
}