using JetBrains.Annotations;
using UnityEngine;

public class BaseNPC : MonoBehaviour
{
    public string npcName;
    public float interactionDistance = 3f;

    [SerializeField] DialogueData dialogueData;

    private void Start()
    {
        npcName = dialogueData.characterName;
    }
    public virtual void Interact()
    {

    }
}
