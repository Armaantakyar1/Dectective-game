using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EvidenceCollecter : MonoBehaviour
{
    public List<string> collectedEvidence = new List<string>();
    

    public void AddEvidence(string Evidence)
    {
        collectedEvidence.Add(Evidence);

        if (collectedEvidence.Count >= 2)
        {
            CompareObjects();
        }

    }
    private void CompareObjects()
    {
        string firstObject = collectedEvidence[0];
        string secondObject = collectedEvidence[1];

        if (firstObject == secondObject)
        {
            Debug.Log("The objects are identical.");
        }
        else
        {
            Debug.Log("The objects are different.");
        }
        collectedEvidence.Clear();
    }
}
