using UnityEngine;
using Game.Controller;
using Game.Exceptions;
using Game.Managers;
using Game.Signals;

public class PlayerManager : MonoSingleton<PlayerManager>
{
    #region Variables

    #region SerializeFields

    [SerializeField] private PlayerController playerController;

    #endregion

    #endregion

    #region Events

    private void OnEnable()
    {
        EventSubscription();
    }
    private void OnDisable()
    {
        EventUnsubscription();
    }

    private void EventSubscription()
    {
        CoreGameSignals.onPositionClicked += PositionClicked;
        DialogueSignals.lookNPC += LookToNpc;
    }

    private void EventUnsubscription()
    {
        CoreGameSignals.onPositionClicked -= PositionClicked;
        DialogueSignals.lookNPC -= LookToNpc;
    }


    private void PositionClicked(Vector3 hit)
    {
        playerController.MoveToClickedPosition(hit);
    }

    public Vector3 GetPlayerPosition()
    {
        return playerController.transform.position;
    }

    private void LookToNpc(Transform pos)
    {
        playerController.LookNPC(pos);
    }

    #endregion
}
