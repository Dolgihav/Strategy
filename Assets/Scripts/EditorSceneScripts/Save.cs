using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Save : MonoBehaviour
{
    EditorMain Main;
    public InputField Field;
    string arrtext;
    string x;
    string y;
    int x2;
    int y2;
    public void save()
    {
        Main = GameObject.FindObjectOfType(typeof(EditorMain)) as EditorMain;
        x = (Main.x).ToString();
        y = (Main.y).ToString();
        x2 = x.Length;
        y2 = y.Length;
        arrtext = arrtext + x2;
        arrtext = arrtext + y2;
        arrtext = arrtext + Main.x;
        arrtext = arrtext + Main.y;
        for (int i = 0; i < 128; i++)
        {
            for (int j = 0; j < 128; j++)
            {
                arrtext = arrtext + Main.arr[i, j, 0];
                arrtext = arrtext + Main.arr[i, j, 1];
            }
        }
        Field.text = "";
        Field.text = arrtext;
        StreamWriter sw = new StreamWriter("name.txt");
        sw.WriteLine(arrtext);
        sw.Close();
        arrtext = "";
    }
}
