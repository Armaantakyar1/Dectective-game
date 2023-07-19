using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject newDialog;
    [SerializeField] GameObject oldDialog;
    [SerializeField] GameObject itself;
    bool open;
    [SerializeField] int evidenceFound;
    void Update()
    {
        if (evidenceFound >= 6 && open == false)
        {
            newDialog.SetActive(true);
            oldDialog.SetActive(false);
            itself.SetActive(false);
        }
    }

    public void FoundEvidence()
    {
        evidenceFound++;
    }

}
