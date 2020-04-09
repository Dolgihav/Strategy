using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TestCreate : MonoBehaviour
{
    public void TestCreateFile() 
    {
        StreamWriter sw = new StreamWriter("name.txt");
        sw.WriteLine("12345");
        sw.Close();

    }
}
