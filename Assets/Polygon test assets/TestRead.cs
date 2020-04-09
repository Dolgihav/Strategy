using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TestRead : MonoBehaviour
{
    public void TestReadFile() 
    {
        StreamReader streamReader = new StreamReader("name.txt");
        string str = "";

        while (!streamReader.EndOfStream)
        {
            str += streamReader.ReadLine();
        }
        streamReader.Close();
        Debug.Log(str);
    }
}
