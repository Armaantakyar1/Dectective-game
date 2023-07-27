using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evidence : MonoBehaviour
{
    [SerializeField] EvidenceCollecter collecter;
    [SerializeField] int data;
    [SerializeField] GameObject itself;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            collecter.AddObject(itself);
            collecter.AddEvidence(data);
        }
    }
}
