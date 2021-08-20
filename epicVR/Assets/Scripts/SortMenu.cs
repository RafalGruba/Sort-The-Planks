using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SortMenu : MonoBehaviour
{
    public SortingScript sortingScript;
    public Slider inputNumberOfCubes;
    public Slider inputHeightOfCubes;

    [HideInInspector]
    public SortingScript activeSorter;

    public void StartSelectionSort()
    {
        activeSorter = Instantiate(sortingScript);
        activeSorter.numberOfCubes = Convert.ToInt32(inputNumberOfCubes.value);
        activeSorter.cubeHeightMax = Convert.ToInt32(inputHeightOfCubes.value);
        activeSorter.StartSelectionSort();
    }

    public void StartBubbleSort()
    {
        activeSorter = Instantiate(sortingScript);
        activeSorter.numberOfCubes = Convert.ToInt32(inputNumberOfCubes.value);
        activeSorter.cubeHeightMax = Convert.ToInt32(inputHeightOfCubes.value);
        activeSorter.StartBubbleSort();
    }

    public void StartQuickSort()
    {
        activeSorter = Instantiate(sortingScript);
        activeSorter.numberOfCubes = Convert.ToInt32(inputNumberOfCubes.value);
        activeSorter.cubeHeightMax = Convert.ToInt32(inputHeightOfCubes.value);
        activeSorter.StartQuickSort();
    }

    public void ResetSort()
    {
        Destroy(activeSorter.gameObject);
    }

    public void QuitApp()
    {
        Application.Quit();
    }    

}
