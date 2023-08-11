using Cinemachine;
using Game.Managers;
using Game.Signals;
using Unity.VisualScripting;
using UnityEngine;

public class FriendlyNPCBase : MonoBehaviour
{
    #region Variables


    protected float dialogueDistance = 3f;

    [SerializeField] protected DialogueController dialogueController;

    #endregion

    #region Methods
    public virtual void Interact()
    {

        if (IsWithinDialogueDistance())
        {
            CameraSignals.cameraState?.Invoke(CameraAnimationState.isNpc, true);
            DialogueSignals.lookNPC?.Invoke(this.transform, true);
            DialogueSignals.onPlayerNavigationDisable?.Invoke(false);
            DialogueSignals.openDialogueBox(true);
            dialogueController.StartDialogue();
           
        }
    }

    protected virtual bool IsWithinDialogueDistance()
    {
        float distance = Vector3.Distance(this.transform.position, PlayerManager.Instance.GetPlayerPosition());
        return distance <= dialogueDistance;

    }
    #endregion

}
