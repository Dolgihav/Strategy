using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_Text_Script_2 : MonoBehaviour
{
    public Slider TestSliderPerem;
    public Text TestTextPerem2;
    float ban;
    void Start()
    {
        
    }
    public void TestSliderFunc() 
    {
        ban = TestSliderPerem.value;
        TestTextPerem2.text = ban.ToString();
    }
    void Update()
    {
        
    }
}
