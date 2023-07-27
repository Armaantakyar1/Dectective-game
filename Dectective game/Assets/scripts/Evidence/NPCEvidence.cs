using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCEvidence : MonoBehaviour
{
    
    [SerializeField] bool found = false;
    [SerializeField] bool enter = false;
    [SerializeField] NotebookGrid book;
    [SerializeField] GameObject evidence;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        book = collision.GetComponent<NotebookGrid>();
        if (Input.GetKeyDown(KeyCode.Space) && found == false)
        {
            book.Addition(evidence);

            found = true;
        }
        enter = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        enter = false;
    }

}
