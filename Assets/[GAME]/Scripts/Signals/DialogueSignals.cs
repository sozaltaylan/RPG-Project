using System;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Signals
{
    public static class DialogueSignals
    {
        public static UnityAction<bool> openDialogueBox;
        public static UnityAction<Transform,bool> lookNPC;
        public static UnityAction<bool> onPlayerNavigationDisable;
        public static UnityAction onPressSpace;
    }

}
