using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YText : MonoBehaviour
{
    public Slider SliderY;
    public Text TextY;
    float y;
    public void SliderUpdate()
    {
        y = SliderY.value;
        TextY.text = y.ToString();
    }
}
