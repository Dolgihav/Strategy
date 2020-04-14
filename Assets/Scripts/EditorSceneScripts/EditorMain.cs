using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EditorMain : MonoBehaviour
{
    public Slider SliderX;
    public Slider SliderY;
    public int x;
    public int y;
    float xFloat;
    float yFloat;
    public int[,,] arr = new int[128, 128, 2];
    public GameObject[] objects;
    public GameObject[] objects2;
    public void EditorGen()
    {
        xFloat = SliderX.value;
        yFloat = SliderY.value;
        x = Mathf.FloorToInt(xFloat);
        y = Mathf.FloorToInt(yFloat);
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
        EditorGen2(x, y);
    }
    public void EditorGen2(int x2, int y2)
    {
        for (int i = 0; i < x2; i++)
        {
            for (int j = 0; j < y2; j++)
            {
                Instantiate(objects[arr[i, j, 0]], new Vector2(i, j), new Quaternion(0, 0, 0, 0));
                if (arr[i, j, 1] != 0){ Instantiate(objects2[arr[i, j, 1]], new Vector2(i, j), new Quaternion(0, 0, 0, 0)); }
            }
        }
    }
    public void ArrayUpdate(int x, int y, int type)
    {

        if (type != 2) { arr[x, y, 0] = type + 1; }
        else { arr[x, y, 0] = 0; }
    }
    public void ArrayUpdate2(int x, int y, int type)
    {

        if (type != 1) { arr[x, y, 1] = type + 1; }
        else { arr[x, y, 1] = 0; }
    }
}
