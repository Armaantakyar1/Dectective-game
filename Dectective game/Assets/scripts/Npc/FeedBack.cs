using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedBack : MonoBehaviour
{
    [SerializeField] GameObject background;
    private void OnMouseOver()
    {
        background.SetActive(true);
    }

    private void OnMouseExit()
    {
        background.SetActive(false);
    }
}
