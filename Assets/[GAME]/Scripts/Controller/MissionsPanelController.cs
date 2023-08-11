using Game.Managers;
using TMPro;
using UnityEngine;

public class MissionsPanelController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] missions;

    public void ListActiveQuest(int missionNumber, string quest)
    {
        missions[missionNumber].text = quest;
    }

}

