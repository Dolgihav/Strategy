﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Load : MonoBehaviour
{
    EditorMain Main;
    public InputField Field;
    ChangeTypeUnit Unit;
    string text;
    string a;
    int x;
    int y;
    int xl;
    int yl;
    public void load()
    {
        var objs = GameObject.FindGameObjectsWithTag("Cell");
        for (int i = 0; i < objs.Length; i++) 
        {
            Destroy(objs[i]);
        }
        var objs2 = GameObject.FindGameObjectsWithTag("Unit");
        for (int i = 0; i < objs2.Length; i++)
        {
            Destroy(objs2[i]);
        }
        StreamReader streamReader = new StreamReader("name.txt");
        while (!streamReader.EndOfStream)
        {
            text += streamReader.ReadLine();
        }
        streamReader.Close();
        Main = GameObject.FindObjectOfType(typeof(EditorMain)) as EditorMain;
        xl = int.Parse(text.Substring(0, 1));
        text = text.Substring(1);
        yl = int.Parse(text.Substring(0, 1));
        text = text.Substring(1);
        x = int.Parse(text.Substring(0, xl));
        text = text.Substring(xl);
        y = int.Parse(text.Substring(0, yl));
        text = text.Substring(yl);
        for (int i = 0; i < 128; i++)
        {
            for (int j = 0; j < 128; j++)
            {
                a = text.Substring(0, 1);   
                Main.arr[i, j, 0] = int.Parse(a);
                text = text.Substring(1);
                a = text.Substring(0, 1);
                Main.arr[i, j, 1] = int.Parse(a);
                text = text.Substring(1);
            }
        }
        Main.EditorGen2(x,y);
        var objs3 = GameObject.FindGameObjectsWithTag("Unit");
        for (int i = 0; i < 128; i++)
        {
            for (int j = 0; j < 128; j++)
            {
                if (Main.arr[i, j, 1] != 0)
                {
                    for (int l = 0; l < objs3.Length; l++)
                    {
                        if (Mathf.FloorToInt(objs3[l].transform.position.x) == i && Mathf.FloorToInt(objs3[l].transform.position.y) == j && Main.arr[i, j, 1] != 0)
                        {
                            Unit = objs3[l].GetComponent("ChangeTypeUnit") as ChangeTypeUnit;
                            Unit.team = int.Parse(text.Substring(0, 1));
                            text = text.Substring(1);
                        }
                    }
                }
            }
        }
    }
}