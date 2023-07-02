using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerDialogue : MonoBehaviour
{
    [SerializeField] GameObject dialogueUI;
    [SerializeField] GameObject dialogueText;
    [SerializeField] GameObject dialogueOptions;
    [SerializeField] GameObject dialogueOptionsPrefab;
    [SerializeField] TextMeshProUGUI dialogueSpeaker;
    [SerializeField] TextMeshProUGUI dialogueLine;

    public GameObject DialogueText { get => dialogueText; }
    public TextMeshProUGUI DialogueSpeaker { get => dialogueSpeaker; }
    public TextMeshProUGUI DialogueLine { get => dialogueLine; }
    public GameObject DialogueOptionsPrefab { get => dialogueOptionsPrefab; }
    public GameObject DialogueOptions { get => dialogueOptions; }
    public GameObject DialogueUI { get => dialogueUI; }
}
