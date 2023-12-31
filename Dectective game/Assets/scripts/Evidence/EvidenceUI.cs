using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EvidenceUI : MonoBehaviour
{
    [SerializeField] GameObject background;
    [SerializeField] TMP_Text tmpText;
    [SerializeField] GameObject textobj;
    public void UiTextEnable (string text)
    {
        tmpText.text = text;
        background.SetActive(true);
        textobj.SetActive(true);
    }

    public void UiTextDisable()
    {
        tmpText.text = "";
        background.SetActive(false);
    }
}
