using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    [SerializeField] bool isItOver;
    [SerializeField] NPCDialogue dialog;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isItOver == true)
        {
            dialog.EnterDialog();
        }
    }

    private void OnMouseOver()
    {
        isItOver = true;
    }

    private void OnMouseExit()
    {
        isItOver = false;
    }
}
