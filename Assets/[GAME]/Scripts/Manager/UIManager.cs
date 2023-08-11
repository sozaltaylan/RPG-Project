using UnityEngine;
using Game.Exceptions;
using Game.Signals;

namespace Game.Managers
{
    public class UIManager : MonoSingleton<UIManager>
    {
        #region Variables

        [SerializeField] private GameObject missionsPanel;
        [SerializeField] private MissionsPanelController missionsPanelController;
        [SerializeField] private GameObject newMissionNotification;

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
            UISignals.openCloseMissionPanel += OpenCloseMissionsPanel;
            UISignals.setQuestOnMissionPanel += ListActiveQuest;
            UISignals.setNewMissionNotification += SetNewMissionNotification;
        }

        private void EventUnsubscription()
        {
            UISignals.openCloseMissionPanel -= OpenCloseMissionsPanel;
            UISignals.setQuestOnMissionPanel -= ListActiveQuest;
            UISignals.setNewMissionNotification -= SetNewMissionNotification;

        }

        #endregion

        #region Methods

        private void OpenCloseMissionsPanel(bool active)
        {
            missionsPanel.SetActive(active);
        }

        public void ListActiveQuest(int missionNumber, string quest)
        {
            missionsPanelController.ListActiveQuest(missionNumber, quest);
        }

        public void SetNewMissionNotification(bool active) 
        {
            newMissionNotification.SetActive(active);   
        }
        #endregion
    }
}