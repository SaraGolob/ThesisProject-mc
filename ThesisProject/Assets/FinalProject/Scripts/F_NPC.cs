using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_NPC : MonoBehaviour, IInteractable
{
    [SerializeField] F_SO_Dialgue dialogue;
    public void Interact()
    {
        F_DialogueManager.Instance.QueueDialogue(dialogue);
    }
}