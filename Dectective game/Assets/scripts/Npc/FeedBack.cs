using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedBack : MonoBehaviour
{
    [SerializeField] GameObject background;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        background.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        background.SetActive(false);
    }
}
