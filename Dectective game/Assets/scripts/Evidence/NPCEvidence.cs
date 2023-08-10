using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCEvidence : MonoBehaviour
{
    
    [SerializeField] bool found = false;
    [SerializeField] NotebookGrid book;
    [SerializeField] GameObject evidence;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            book = collision.GetComponent<NotebookGrid>();
            if (found == false && Input.GetKeyDown(KeyCode.Space) && book != null)
            {
                book.Addition(evidence);

                found = true;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            book = collision.GetComponent<NotebookGrid>();
            if (found == false && Input.GetKeyDown(KeyCode.Space) && book != null)
            {
                book.Addition(evidence);

                found = true;
            }
        }

    }

}
