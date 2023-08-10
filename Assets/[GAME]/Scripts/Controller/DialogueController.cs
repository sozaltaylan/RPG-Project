using Game.Managers;
using System;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actors;
    
    public void StartDialogue()
    {
        DialogueManager.Instance.SetDialogueContent(messages, actors);
    }
}

[Serializable]
public class Message
{
    public int actorID;
    public string message;
}

[Serializable]
public class Actor
{
    public string name;
    public Sprite sprite;
}
