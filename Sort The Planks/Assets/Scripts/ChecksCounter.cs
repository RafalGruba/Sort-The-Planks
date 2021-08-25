using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChecksCounter : MonoBehaviour
{
    Text text;
    [HideInInspector]
    public int checksCounter = 0;


    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        UpdateText();
    }

    public void UpdateText()
    {
        text.text = "Number of checks: " + checksCounter.ToString();
    }

    public void IncrementCounter()
    {
        checksCounter++;
    }

    public void ResetCounter()
    {
        checksCounter = 0;
    }
}
