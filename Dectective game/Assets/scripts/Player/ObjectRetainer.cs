using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRetainer : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
