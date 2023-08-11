using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Exceptions;
using Game.Signals;

namespace Game.Managers
{
    public class QuestManager : MonoSingleton<QuestManager>
    {
        #region Variables

        public List<QuestData> activeQuests = new List<QuestData>();
        public List<QuestData> completedQuest = new List<QuestData>();

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
            QuestSignals.startQuest += StartQuest;
            QuestSignals.completedQuest += CompleteQuest;
        }
        private void EventUnsubscription()
        {
            QuestSignals.startQuest -= StartQuest;
            QuestSignals.completedQuest -= CompleteQuest;
        }


        #endregion
        #region Methods

        public void StartQuest(QuestData quest)
        {
            activeQuests.Add(quest);
           
        }
        public void CompleteQuest(QuestData quest)
        {
            activeQuests.Remove(quest);
            completedQuest.Add(quest);
        }

        public int GetActiveQuestNumber()
        {
            return activeQuests.Count;
        }
       



        #endregion




    }



}
