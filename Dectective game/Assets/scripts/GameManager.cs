using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]GameObject notebook;
    bool open;
    [SerializeField] int evidenceFound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (evidenceFound >= 6 && open == false)
        {
            notebook.SetActive(true);
            open = true;
        }
    }

    public void FoundEvidence()
    {
        evidenceFound++;
    }

}
