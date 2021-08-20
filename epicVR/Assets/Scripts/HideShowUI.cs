using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShowUI : MonoBehaviour
{
    public GameObject selection;
    public GameObject bubble;
    public GameObject quick;


    public void TurnOffButtons()
    {
        selection.SetActive(false);
        bubble.SetActive(false);
        quick.SetActive(false);
    }

    public void TurnOnButtons()
    {
        selection.SetActive(true);
        bubble.SetActive(true);
        quick.SetActive(true);
    }

}
