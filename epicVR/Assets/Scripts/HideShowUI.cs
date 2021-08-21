using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShowUI : MonoBehaviour
{
    public GameObject selection;
    public GameObject bubble;
    public GameObject quick;
    public GameObject back;


    public void TurnOffSortButtons()
    {
        selection.SetActive(false);
        bubble.SetActive(false);
        quick.SetActive(false);
    }
    public void TurnOnSortButtons()
    {
        selection.SetActive(true);
        bubble.SetActive(true);
        quick.SetActive(true);
    }
    public void TurnOffBackButton()
    {
        back.SetActive(false);
    }
    public void TurnOnBackButton()
    {
        back.SetActive(true);
    }

}
