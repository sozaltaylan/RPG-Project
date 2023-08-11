using UnityEngine;

public class MerchantNPC : FriendlyNPCBase
{
    public override void Interact()
    {
        base.Interact();
    }
    protected override bool IsWithinDialogueDistance()
    {
        return base.IsWithinDialogueDistance();
    }
}
