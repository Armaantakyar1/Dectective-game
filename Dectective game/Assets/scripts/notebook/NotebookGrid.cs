using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookGrid : MonoBehaviour
{
    [SerializeField] List<GameObject> pieces = new List<GameObject>();

    public void AddToGrid(GameObject addition)
    {
        pieces.Add(addition);
    }
}
