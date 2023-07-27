using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionActivator : MonoBehaviour
{
    [SerializeField] List<GameObject> options = new List<GameObject>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (GameObject obj in options)
        {
            obj.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        foreach (GameObject obj in options)
        {
            obj.SetActive(false);
        }
    }

}
