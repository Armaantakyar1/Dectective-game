using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EvidenceCollecter : MonoBehaviour
{
    public List<int> collectedEvidence = new List<int>();
    

    public void AddEvidence(int Evidence)
    {
        collectedEvidence.Add(Evidence);

        if (collectedEvidence.Count >= 2)
        {
            CompareObjects();
        }

    }
    private void CompareObjects()
    {
        int firstObject = collectedEvidence[0];
        int secondObject = collectedEvidence[1];

        if (firstObject == secondObject)
        {
            
        }
        else
        {
            
        }
        collectedEvidence.Clear();
    }
}
