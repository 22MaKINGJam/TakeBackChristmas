using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingTextManager : MonoBehaviour
{
    public GameObject NextOb_text;
    public void PlayNextText()
    {
        NextOb_text.SetActive(true);
    }
    public void ActiveNextFalse()
    {
        gameObject.SetActive(false);
    }
    public void setscoreText()
    {
        PlayerPrefs.SetInt("currentScore", -1);
    }
}
