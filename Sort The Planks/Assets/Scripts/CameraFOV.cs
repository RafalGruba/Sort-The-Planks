using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFOV : MonoBehaviour
{
    int numberOfCubes;

    public void AdjustCamera()
    {
        numberOfCubes = FindObjectOfType<SortingScript>().ReturnNumberOfCubes();
        transform.position = new Vector3(0, 0, -20f);

        if (numberOfCubes > 30)
        {
            transform.position = new Vector3(0, 0, -24f);
            if (numberOfCubes > 40)
            {
                transform.position = new Vector3(0, 0, -28f);
                if (numberOfCubes > 50)
                {
                    transform.position = new Vector3(0, 0, -32f);
                    if (numberOfCubes > 60)
                    {
                        transform.position = new Vector3(0, 0, -38f);
                        if (numberOfCubes > 70)
                        {
                            transform.position = new Vector3(0, 0, -42f);
                            if (numberOfCubes > 80)
                            {
                                transform.position = new Vector3(0, 0, -46f);
                                if (numberOfCubes > 90)
                                {
                                    transform.position = new Vector3(0, 0, -51f);
                                }
                            }
                        }
                    }
                }
            }
        }

    }


}
