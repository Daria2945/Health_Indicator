using UnityEngine;
using UnityEngine.UI;

public class Healer : MonoBehaviour
{
    [SerializeField] private Button _healButton;
    [SerializeField] private Character _character;
    [SerializeField] private int _unitHealth;

    private void OnEnable()
    {
        _healButton.onClick.AddListener(Heal);
    }

    private void OnDisable()
    {
        _healButton.onClick.RemoveListener(Heal);
    }

    private void Heal()
    {
        _character.Heal(_unitHealth);
    }
}
