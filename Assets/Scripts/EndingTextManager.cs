using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingTextManager : MonoBehaviour
{
    public GameObject NextOb_text;
    public void PlayNextText()
    {
        if (NextOb_text != null)
        NextOb_text.SetActive(true);
    }
}
