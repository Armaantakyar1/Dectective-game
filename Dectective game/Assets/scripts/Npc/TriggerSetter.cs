using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSetter : MonoBehaviour
{
    [SerializeField] Collider2D BoxSet;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        BoxSet.isTrigger = true;
        
        
    }
}
