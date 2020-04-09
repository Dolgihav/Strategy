using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XText : MonoBehaviour
{
    public Slider SliderX;
    public Text TextX;
    float x;
    public void SliderUpdate()
    {
        x = SliderX.value;
        TextX.text = x.ToString();
    }
}
