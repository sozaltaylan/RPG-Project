using UnityEngine;
using Game.Exceptions;
using UnityEngine.UI;
using TMPro;
using Game.Signals;
using Unity.VisualScripting;

namespace Game.Managers
{
    public class DialogueManager : MonoSingleton<DialogueManager>
    {
        #region Variables

        public Image actorImage;
        public TextMeshProUGUI actorName;
        public TextMeshProUGUI actorMessage;
        public RectTransform background;

        Message[] currentMesage;
        Actor[] currentActor;
        int activeMessage = 0;

        public GameObject dialogueBox;

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
            DialogueSignals.openDialogueBox += OpenDialogue;
        }

        private void EventUnsubscription()
        {
            DialogueSignals.openDialogueBox -= OpenDialogue;
        }



        #endregion

        #region Methods

        public void OpenDialogue(bool active)
        {
            dialogueBox.SetActive(active);

        }

        public void SetDialogueContent(Message[] messages, Actor[] actors)
        {
            currentMesage = messages;
            currentActor = actors;
            activeMessage = 0;

            DisplayMessage();

        }

        private void DisplayMessage()
        {
            Message displayToMessage = currentMesage[activeMessage];
            actorMessage.text = displayToMessage.message;

            Actor displayToActor = currentActor[displayToMessage.actorID];
            actorName.text = displayToActor.name;
            actorImage.sprite = displayToActor.sprite;

        }

        #endregion

    }
}
