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
    SFXManager sfxInstance;

    private void Start()
    {
        sfxInstance = FindObjectOfType<SFXManager>();        
    }

    public void StartSelectionSort()
    {
        sfxInstance.PlaybuttonClickedSFX();
        activeSorter = Instantiate(sortingScript);
        activeSorter.numberOfCubes = Convert.ToInt32(inputNumberOfCubes.value);
        activeSorter.cubeHeightMax = Convert.ToInt32(inputHeightOfCubes.value);
        activeSorter.StartSelectionSort();
    }

    public void StartBubbleSort()
    {
        sfxInstance.PlaybuttonClickedSFX();
        activeSorter = Instantiate(sortingScript);
        activeSorter.numberOfCubes = Convert.ToInt32(inputNumberOfCubes.value);
        activeSorter.cubeHeightMax = Convert.ToInt32(inputHeightOfCubes.value);
        activeSorter.StartBubbleSort();
    }

    public void StartQuickSort()
    {
        sfxInstance.PlaybuttonClickedSFX();
        activeSorter = Instantiate(sortingScript);
        activeSorter.numberOfCubes = Convert.ToInt32(inputNumberOfCubes.value);
        activeSorter.cubeHeightMax = Convert.ToInt32(inputHeightOfCubes.value);
        activeSorter.StartQuickSort();
    }

    public void ResetSort()
    {
        sfxInstance.PlaybuttonClickedSFX();
        Destroy(activeSorter.gameObject);
    }

    public void QuitApp()
    {
        sfxInstance.PlaybuttonClickedSFX();
        Application.Quit();
    }    

}
