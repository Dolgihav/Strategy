using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MapEditTest : MonoBehaviour
{
    public int x;
    public int y;
    public int[,,] arr = new int[128,128,2];
    public GameObject[] objects;
    void Start()
    {
        x = 10;
        y = 10;
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                arr[i, j, 0] = 0;
            }
        }
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                arr[i, j, 1] = 0;
            }
        }
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Instantiate(objects[arr[i,j,0]], new Vector2(i, j), new Quaternion(0, 0, 0, 0));
            }
        }
    }
    public void ArrayUpdate(int x,int y,int type) 
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                if (type != 2) { arr[i, j, 0] = type + 1; }
                else { arr[i, j, 0] = 0; }
            }
        }
    }
}
