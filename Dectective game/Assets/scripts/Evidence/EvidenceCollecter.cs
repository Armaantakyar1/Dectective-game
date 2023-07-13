using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EvidenceCollecter : MonoBehaviour
{
    [SerializeField] List<int> collectedEvidence = new List<int>();
    [SerializeField] List<GameObject> collectedObjects = new List<GameObject>();
    [SerializeField] List<GameObject> enablingObject = new List<GameObject>();

    public void AddObject(GameObject obj)
    {
        collectedObjects.Add(obj);
    }

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
            enableObject(firstObject);
            disableObj();

        }

        collectedEvidence.Clear();
        collectedObjects.Clear();
    }

    void enableObject(int index)
    {
        enablingObject[index].SetActive(true);
    }

    void disableObj()
    {
        foreach (GameObject obj in collectedObjects)
        {
            obj.SetActive(false);
        }
    }

}
