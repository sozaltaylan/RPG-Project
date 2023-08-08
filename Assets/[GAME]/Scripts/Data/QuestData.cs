using UnityEngine;

[CreateAssetMenu(fileName = "QuestData",menuName ="Data/Quest")]
public class QuestData : ScriptableObject
{
    public string questName;
    public string questDescription;

    public bool isCompleted;
}
