using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PVEMain : MonoBehaviour
{
    public int x;
    public int y;
    public int[,,] arr = new int[128, 128, 2];
    public GameObject[] objects;
    public GameObject[] objects2;
    public void Start()
    {
        for (int i = 0; i < 128; i++)
        {
            for (int j = 0; j < 128; j++)
            {
                arr[i, j, 0] = 0;
            }
        }
        for (int i = 0; i < 128; i++)
        {
            for (int j = 0; j < 128; j++)
            {
                arr[i, j, 1] = 0;
            }
        }
    }
    public void PVELevelLoad(int x2,int y2) 
    {
        for (int i = 0; i < x2; i++)
        {
            for (int j = 0; j < y2; j++)
            {
                Instantiate(objects[arr[i, j, 0]], new Vector2(i, j), new Quaternion(0, 0, 0, 0));
                if (arr[i, j, 1] != 0) { Instantiate(objects2[arr[i, j, 1]], new Vector2(i, j), new Quaternion(0, 0, 0, 0)); }
            }
        }
    }
}
