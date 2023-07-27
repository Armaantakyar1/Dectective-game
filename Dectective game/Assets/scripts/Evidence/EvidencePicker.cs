using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidencePicker : MonoBehaviour
{
    [SerializeField] GameManager manager;
    [SerializeField] bool found = false;
    [SerializeField] bool enter = false;
    [SerializeField] EvidenceUI UI;
    [SerializeField] string text;
    NotebookGrid book;
    [SerializeField] GameObject evidence;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& enter == true)
        {
            UI.UiTextEnable(text);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        book = collision.GetComponent<NotebookGrid>();
        if (Input.GetKeyDown(KeyCode.Space) && found == false)
        {
            book.Addition(evidence);
            manager.FoundEvidence();
            found = true;
        }
        enter = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UI.UiTextDisable();
        enter = false;
    }

}
