using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingTextManager : MonoBehaviour
{
    public GameObject NextOb_text;
    public TextMesh tmp;
    public void PlayNextText()
    {
        NextOb_text.SetActive(true);
    }
}
