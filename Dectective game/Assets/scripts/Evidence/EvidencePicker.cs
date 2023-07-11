using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidencePicker : MonoBehaviour
{
    [SerializeField] GameManager manager;
    [SerializeField] NotebookGrid Grid;
    [SerializeField] bool found;
    [SerializeField] GameObject UI;
    [SerializeField] GameObject paper;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)&& found == false)
        {
            UI.SetActive(true);
            if (found == false)
            {
                Grid.AddToGrid(paper);
                manager.FoundEvidence();
                found = true;
            }

        }
    }
}
