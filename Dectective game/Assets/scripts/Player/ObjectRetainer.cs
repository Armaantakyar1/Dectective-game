using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRetainer : MonoBehaviour
{
    [SerializeField] NotebookGrid notebook;
    void Awake()
    {
        DontDestroyOnLoad(notebook);
    }
}
