using UnityEngine;
using UnityEngine.Events;

namespace Game.Signals
{
    public static class QuestSignals
    {
        public static UnityAction<QuestData> startQuest;
        public static UnityAction<QuestData> completedQuest;
    }
}
