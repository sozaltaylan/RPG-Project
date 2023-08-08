using UnityEngine;


[CreateAssetMenu(fileName ="DialogueData", menuName ="Data/Dialogue")]
public class DialogueData : ScriptableObject
{
    public string characterName;
    [TextArea(3, 10)]
    public string[] dialogLines;
}
