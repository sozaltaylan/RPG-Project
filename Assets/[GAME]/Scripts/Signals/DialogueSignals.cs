using UnityEngine;
using UnityEngine.Events;

namespace Game.Signals
{
    public static class DialogueSignals
    {
        public static UnityAction<DialogueData> startDialogue;
        public static UnityAction<Transform> onNPCTalked;
        public static UnityAction<bool> onPlayerNavigationDisable;
        public static UnityAction<bool> stopPlayer;
    }

}
