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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& enter == true)
        {
            UI.UiTextEnable(text);
            if(found == false)
            {
                manager.FoundEvidence();
                found = true;
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        enter = true;

        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        UI.UiTextDisable();
        enter = false;
    }

}
