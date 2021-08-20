using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapsCounter : MonoBehaviour
{
    Text text;
    [HideInInspector]
    public int spawsCounter = 0;


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
        text.text = "Number of swaps: " + spawsCounter.ToString();
    }

    public void IncrementCounter()
    {
        spawsCounter++;
    }

    public void ResetCounter()
    {
        spawsCounter = 0;
    }
}
