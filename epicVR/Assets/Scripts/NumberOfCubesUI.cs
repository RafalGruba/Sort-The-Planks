using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NumberOfCubesUI : MonoBehaviour
{
    Text text;


    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    public void UpdateText(float value)
    {
        text.text = "Number of cubes: " + value.ToString();
    }

}
