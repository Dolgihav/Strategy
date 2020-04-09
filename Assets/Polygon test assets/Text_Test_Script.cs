using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Test_Script : MonoBehaviour
{
    public Text TestTextPerem;
    int a=0;
    void Start()
    {
        string ban = "5";
        TestTextPerem.text = ban;
    }
    public void TestTextFunction() 
    {
        a = a + 1;
        TestTextPerem.text = a.ToString();
    }
        
    void Update()
    {
    }
}