using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidencePicker : MonoBehaviour
{
    [SerializeField] GameManager manager;
    [SerializeField] bool found;
    [SerializeField] GameObject UI;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)&& found == false)
        {
            UI.SetActive(true);
            if (found == false)
            {
                manager.FoundEvidence();
                found = true;
            }

        }
    }
}
