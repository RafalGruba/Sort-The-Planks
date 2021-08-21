using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingScript : MonoBehaviour
{
    public int numberOfCubes = 10;
    public int cubeHeightMax = 10;
    public GameObject[] cubes;
    public Material myMaterial;



    private void Start()
    {

    }

    // Quick Sort
    IEnumerator QuickSort(GameObject[] unsortedList, int left, int right)
    {
        if (left < right)
        {
            SwapsCounter sc;
            ChecksCounter cc;
            sc = FindObjectOfType<SwapsCounter>();
            cc = FindObjectOfType<ChecksCounter>();
            GameObject temp;
            Vector3 tempPosition1;
            Vector3 tempPosition2;
            int pivotValue = (int)unsortedList[right].transform.localScale.y;
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                cc.IncrementCounter();
                if (unsortedList[j].transform.localScale.y <= pivotValue)
                {
                    i++;
                    cc.IncrementCounter();
                    if (i != j)
                    {
                        yield return new WaitForSeconds(1);

                        sc.IncrementCounter();

                        temp = unsortedList[i];
                        unsortedList[i] = unsortedList[j];
                        unsortedList[j] = temp;

                        tempPosition1 = unsortedList[i].transform.localPosition;

                        LeanTween.moveLocalX(unsortedList[i], unsortedList[j].transform.localPosition.x, 1f);
                        LeanTween.moveLocalZ(unsortedList[i], -3f, 0.5f).setLoopPingPong(1);

                        LeanTween.moveLocalX(unsortedList[j], tempPosition1.x, 1f);
                        LeanTween.moveLocalZ(unsortedList[j], 3f, 0.5f).setLoopPingPong(1);
                    }
                }
            }
            cc.IncrementCounter();
            if (i + 1 != right)
            {
                yield return new WaitForSeconds(1);

                sc.IncrementCounter();

                temp = unsortedList[i + 1];
                unsortedList[i + 1] = unsortedList[right];
                unsortedList[right] = temp;

                tempPosition2 = unsortedList[i + 1].transform.localPosition;

                LeanTween.moveLocalX(unsortedList[i + 1], unsortedList[right].transform.localPosition.x, 1f);
                LeanTween.moveLocalZ(unsortedList[i + 1], -3f, 0.5f).setLoopPingPong(1);

                LeanTween.moveLocalX(unsortedList[right], tempPosition2.x, 1f);
                LeanTween.moveLocalZ(unsortedList[right], 3f, 0.5f).setLoopPingPong(1);
            }

            int pivotIndex = i + 1;

            yield return (QuickSort(cubes, left, pivotIndex - 1));
            yield return (QuickSort(cubes, pivotIndex + 1, right));

        }
    }
    public void StartQuickSort()
    {
        SpawnCubes();
        StartCoroutine(QuickSort(cubes, 0, cubes.Length -1));
    }


    // Bubble Sort
    IEnumerator BubbleSort(GameObject[] unsortedList)
    {
        GameObject temp;
        Vector3 tempPosition;
        SwapsCounter sc;
        ChecksCounter cc;
        sc = FindObjectOfType<SwapsCounter>();
        cc = FindObjectOfType<ChecksCounter>();

        for (int i = 0; i < unsortedList.Length - 1; i++)
        {
            for (int j = 0; j < unsortedList.Length - (1 + i); j++)
            {
                cc.IncrementCounter();
                if (unsortedList[j].transform.localScale.y > unsortedList[j + 1].transform.localScale.y)
                {
                    yield return new WaitForSeconds(1);

                    sc.IncrementCounter();
                    
                    temp = unsortedList[j + 1];
                    unsortedList[j + 1] = unsortedList[j];
                    unsortedList[j] = temp;

                    tempPosition = unsortedList[j + 1].transform.localPosition;

                    LeanTween.moveLocalX(unsortedList[j + 1], unsortedList[j].transform.localPosition.x, 1f);
                    LeanTween.moveLocalZ(unsortedList[j + 1], -3f, 0.5f).setLoopPingPong(1);

                    LeanTween.moveLocalX(unsortedList[j], tempPosition.x, 1f);
                    LeanTween.moveLocalZ(unsortedList[j], 3f, 0.5f).setLoopPingPong(1);
                }
            }
        }
    }
    public void StartBubbleSort()
    {
        SpawnCubes();
        StartCoroutine(BubbleSort(cubes));
    }


    // Selection Sort
    IEnumerator SelectionSort(GameObject[] unsortedList)
    {
        int min;
        GameObject temp;
        Vector3 tempPosition;
        SwapsCounter sc;
        ChecksCounter cc;
        sc = FindObjectOfType<SwapsCounter>();
        cc = FindObjectOfType<ChecksCounter>();

        for (int i = 0; i < unsortedList.Length; i++)
        {
            min = i;

            for (int j = i +1; j < unsortedList.Length; j++)
            {
                cc.IncrementCounter();
                if (unsortedList[j].transform.localScale.y < 
                    unsortedList[min].transform.localScale.y)
                {
                    min = j;
                }    
            }

            cc.IncrementCounter();
            if (min != i)
            {
                yield return new WaitForSeconds(1);

                sc.IncrementCounter();

                temp = unsortedList[i];
                unsortedList[i] = unsortedList[min];
                unsortedList[min] = temp;
                
                tempPosition = unsortedList[i].transform.localPosition;

                LeanTween.moveLocalX(unsortedList[i], unsortedList[min].transform.localPosition.x, 1f);
                LeanTween.moveLocalZ(unsortedList[i], -3f, 0.5f).setLoopPingPong(1);

                LeanTween.moveLocalX(unsortedList[min], tempPosition.x, 1f);
                LeanTween.moveLocalZ(unsortedList[min], 3f, 0.5f).setLoopPingPong(1);
            }
        }
    }
    public void StartSelectionSort()
    {
        SpawnCubes();
        StartCoroutine(SelectionSort(cubes));
    }


    // Spawn Cubes
    void SpawnCubes()
    {
        CameraFOV cFOV = FindObjectOfType<CameraFOV>();
        cFOV.AdjustCamera();

        cubes = new GameObject[numberOfCubes];

        for (int i = 0; i < numberOfCubes; i++)
        {
            int randomNumber = Random.Range(1, cubeHeightMax);

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.localScale = new Vector3(0.9f, randomNumber, 1);
            cube.transform.position = new Vector3(i, randomNumber / 2f, 0);
            cube.transform.parent = this.transform;
            //LeanTween.color(cube, Color.magenta, 0f);
            cube.GetComponent<Renderer>().material = myMaterial;
            cubes[i] = cube;
        }
        transform.position = new Vector3(-numberOfCubes / 2f, -cubeHeightMax /2f, 0);
    }

    public int ReturnNumberOfCubes()
    {
        return numberOfCubes;
    }
}
