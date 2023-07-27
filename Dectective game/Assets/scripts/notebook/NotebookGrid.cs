using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookGrid : MonoBehaviour
{
    [SerializeField] List<GameObject> pieces = new List<GameObject>();

    public void EnableGrid()
    {
        foreach(GameObject obj in pieces)
        {
            obj.SetActive(true);
        }
    }

    public void DisableGrid()
    {
        foreach (GameObject obj in pieces)
        {
            obj.SetActive(false);
        }
    }
    public void Addition(GameObject addition)
    {
        pieces.Add(addition);
        
    }
    public void AddToGrid(GameObject addition)
    {
        pieces.Add(addition);
        addition.SetActive(true);
    }
    public void RemoveFromGrid(GameObject delete)
    {
        pieces.Remove(delete);
        delete.SetActive(false);
    }
}
