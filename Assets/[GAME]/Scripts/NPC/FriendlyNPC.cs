using Cinemachine;
using Game.Managers;
using Game.Signals;
using Unity.VisualScripting;
using UnityEngine;

public class FriendlyNPC : MonoBehaviour
{
    #region Variables

    public string npcName;
    public string[] dialogue;

    private float dialogueDistance = 3f;

    [SerializeField] private DialogueData dialogueData;
    [SerializeField] private CinemachineVirtualCamera npcCamera;

    #endregion

    #region Methods
    private void Start()
    {
        npcName = dialogueData.characterName;
        dialogue = dialogueData.dialogLines;
    }
    public void Interact()
    {

        if (IsWithinDialogueDistance())
        {
            CameraSignals.cameraState?.Invoke(CameraAnimationState.isNpc, true);
            DialogueSignals.onNPCTalked?.Invoke(this.transform);
            DialogueSignals.onPlayerNavigationDisable?.Invoke(false);

        }
    }

    public bool IsWithinDialogueDistance()
    {
        float distance = Vector3.Distance(this.transform.position, PlayerManager.Instance.GetPlayerPosition());
        return distance <= dialogueDistance;

    }
    #endregion

}
