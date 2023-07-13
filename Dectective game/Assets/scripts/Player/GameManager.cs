using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]List<GameObject> notebook = new List<GameObject>();
    [SerializeField] GameObject itself;
    bool open;
    [SerializeField] int evidenceFound;
    void Update()
    {
        if (evidenceFound >= 6 && open == false)
        {
            foreach (GameObject obj in notebook)
            {
                obj.SetActive(true);
            }
            itself.SetActive(false);
        }
    }

    public void FoundEvidence()
    {
        evidenceFound++;
    }

}
