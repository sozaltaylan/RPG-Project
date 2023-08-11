using Game.Signals;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestNPC : FriendlyNPCBase
{
    [SerializeField] protected QuestData quest;

    public override void Interact()
    {
        base.Interact();

        if (IsWithinDialogueDistance())
        {
            QuestSignals.startQuest?.Invoke(quest);
            UISignals.setQuestOnMissionPanel?.Invoke(0, quest.questDescription); // !!!!!!
            UISignals.setNewMissionNotification?.Invoke(true);
        }
        
    }
    protected override bool IsWithinDialogueDistance()
    {
        return base.IsWithinDialogueDistance();
    }
    
}


