using UnityEngine;
using UnityEngine.Events;

namespace Game.Signals
{
    public static class UISignals 
    {
        public static UnityAction<bool> openCloseMissionPanel;
        public static UnityAction<int, string> setQuestOnMissionPanel;
        public static UnityAction<bool> setNewMissionNotification;
    }
}
