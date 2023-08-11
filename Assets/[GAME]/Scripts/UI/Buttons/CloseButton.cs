using UnityEngine;

public class CloseButton : BaseButton
{
    [SerializeField] protected GameObject toBeClosedObject;
    protected override void HandleButtonClicked()
    {
        toBeClosedObject.SetActive(false);
    }
}
