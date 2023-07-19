using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NPCDialogue : MonoBehaviour
{
    DialogueState dialogueState = DialogueState.NotInRange;
    PlayerDialogue playerDialogue;
    Queue<string> dialogueText = new Queue<string>();
    Queue<string> dialogueSpeaker = new Queue<string>();
    [SerializeField] Dialogue dialogue;
    List<GameObject> optionList = new List<GameObject>();


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckState();
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            EndDialogue();
        }
    }

    private void ClearOptions()
    {
        foreach (var option in optionList)
        {
            Destroy(option);
        }
        optionList.Clear();
    }

    void CheckState()
    {
        switch (dialogueState)
        {
            case DialogueState.InRange:
                Time.timeScale = 0;
                playerDialogue.DialogueUI.SetActive(true);
                StartDialogue(dialogue.IntroLines);
                break;

            case DialogueState.InDialogue:
                if (dialogueText.Count == 0)
                {
                    if (dialogue.DialogueOptions.Length == 0)
                    {
                        ExitingDialogue();
                    }
                    else
                    {
                        dialogueState = DialogueState.InDialogueOptions;
                        playerDialogue.DialogueText.SetActive(false);
                        playerDialogue.DialogueOptions.SetActive(true);
                        foreach (var option in dialogue.DialogueOptions)
                        {
                            optionList.Add(Instantiate(playerDialogue.DialogueOptionsPrefab, playerDialogue.DialogueOptions.transform));
                            optionList[optionList.Count - 1].GetComponent<TextMeshProUGUI>().text = option.PlayerLine;
                            optionList[optionList.Count - 1].GetComponentInChildren<Button>().onClick.AddListener(() => SelectOption(option));
                        }
                        optionList.Add(Instantiate(playerDialogue.DialogueOptionsPrefab, playerDialogue.DialogueOptions.transform));
                        optionList[optionList.Count - 1].GetComponent<TextMeshProUGUI>().text = dialogue.EndDialogue.PlayerLine;
                        optionList[optionList.Count - 1].GetComponentInChildren<Button>().onClick.AddListener(ExitingDialogue);
                    }
                    break;
                }
                NextLine();
                break;

            case DialogueState.ExitingDialogue:
                if (dialogueText.Count == 0)
                {
                    ExitingDialogue();
                    break;
                }
                NextLine();
                break;
        }
    }

    void ExitingDialogue()
    {
        if (dialogue.EndDialogue.NpcDialogue == null || dialogue.EndDialogue.NpcDialogue.Lines.Length == 0)
        {
            EndDialogue();
        }
        else if (dialogueState != DialogueState.ExitingDialogue)
        {
            StartDialogue(dialogue.EndDialogue.NpcDialogue);
            dialogueState = DialogueState.ExitingDialogue;
        }
        else
        {
            EndDialogue();
        }
    }

    private void EndDialogue()
    {
        ClearOptions();
        if (dialogueText.Count > 0)
        {
            dialogueSpeaker.Clear();
            dialogueText.Clear();
        }
        playerDialogue.DialogueText.SetActive(false);
        playerDialogue.DialogueUI.SetActive(false);
        playerDialogue.DialogueOptions.SetActive(false);
        dialogueState = DialogueState.InRange;
        Time.timeScale = 1;
    }

    void SelectOption(DialogueOptions dialogueOptions)
    {
        ClearOptions();
        StartDialogue(dialogueOptions.NpcDialogue);
    }

    void StartDialogue(DialogueData dialogueData)
    {
        playerDialogue.DialogueOptions.SetActive(false);
        playerDialogue.DialogueText.SetActive(true);
        foreach (var line in dialogueData.Lines)
        {
            dialogueSpeaker.Enqueue(line.Speaker);
            dialogueText.Enqueue(line.Text);
        }
        NextLine();
        dialogueState = DialogueState.InDialogue;
    }

    private void NextLine()
    {
        if (dialogueText.Peek() != null)
        {
            playerDialogue.DialogueSpeaker.text = dialogueSpeaker.Dequeue();
            playerDialogue.DialogueLine.text = dialogueText.Dequeue();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out playerDialogue))
        {
            dialogueState = DialogueState.InRange;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        dialogueState = DialogueState.NotInRange;
    }
}

public enum DialogueState
{
    NotInRange,
    InRange,
    InDialogue,
    InDialogueOptions,
    ExitingDialogue
}
