using UnityEngine;
using UnityEngine.UI;

public class Attacker : MonoBehaviour
{
    [SerializeField] private Button _attackButton;
    [SerializeField] private Character _character;
    [SerializeField] private int _damage;

    private void OnEnable()
    {
        _attackButton.onClick.AddListener(Attack);
    }

    private void OnDisable()
    {
        _attackButton.onClick.RemoveListener(Attack);
    }

    private void Attack()
    {
        _character.TakeDamage(_damage);
    }
}