using System;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Signals
{
    public static class DialogueSignals
    {
        public static UnityAction<bool> openDialogueBox;
        public static UnityAction<Transform> lookNPC;
        public static UnityAction<bool> onPlayerNavigationDisable;
    }

}
