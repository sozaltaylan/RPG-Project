using Game.Signals;
using UnityEngine;

public class MissionButton : BaseButton
{
    protected override void HandleButtonClicked()
    {
        UISignals.openCloseMissionPanel(true);
        UISignals.setNewMissionNotification(false);
    }
}
