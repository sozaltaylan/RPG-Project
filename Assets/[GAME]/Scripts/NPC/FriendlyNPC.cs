using Cinemachine;
using Game.Managers;
using Game.Signals;
using Unity.VisualScripting;
using UnityEngine;

public class FriendlyNPC : MonoBehaviour
{
    #region Variables


    private float dialogueDistance = 3f;

    [SerializeField] private DialogueController dialogueController;

    #endregion

    #region Methods
    public void Interact()
    {

        if (IsWithinDialogueDistance())
        {
            CameraSignals.cameraState?.Invoke(CameraAnimationState.isNpc, true);
            DialogueSignals.lookNPC?.Invoke(this.transform);
            DialogueSignals.onPlayerNavigationDisable?.Invoke(false);
            DialogueSignals.openDialogueBox(true);
            dialogueController.StartDialogue();
        }
    }

    public bool IsWithinDialogueDistance()
    {
        float distance = Vector3.Distance(this.transform.position, PlayerManager.Instance.GetPlayerPosition());
        return distance <= dialogueDistance;

    }
    #endregion

}
