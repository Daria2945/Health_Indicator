using UnityEngine;

public class Healer : ActionButton
{
    [SerializeField] private int _unitHealth;

    protected override void OnButtonClick()
    {
        Heal();
    }

    private void Heal()
    {
        Character.ReceiveTreatment(_unitHealth);
    }
}