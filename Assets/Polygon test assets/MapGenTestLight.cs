using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenTestLight : MonoBehaviour
{
    public GameObject[] objects;
    void Start()
    {
        int[,] arr = new int[8, 8] { { 1, 0, 1, 0, 1, 0, 1, 0 }, { 0, 1, 0, 1, 0, 1, 0, 1 }, { 1, 0, 1, 0, 1, 0, 1, 0 }, { 0, 1, 0, 1, 0, 1, 0, 1 }, { 1, 0, 1, 0, 1, 0, 1, 0 }, { 0, 1, 0, 1, 0, 1, 0, 1 }, { 1, 0, 1, 0, 1, 0, 1, 0 }, { 0, 1, 0, 1, 0, 1, 0, 1 } };

        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (arr[i,j] == 0)
                    { Instantiate(objects[0], new Vector2(i, j), new Quaternion(0, 0, 0, 0)); }
                    else if (arr[i,j] == 1)
                    { Instantiate(objects[1], new Vector2(i, j), new Quaternion(0, 0, 0, 0)); }
                }
            }
        }
    } 
}
