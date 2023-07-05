using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evidence : MonoBehaviour
{
    [SerializeField] EvidenceCollecter collecter;
    [SerializeField] string data;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            collecter.AddEvidence(data);
        }
    }
}
