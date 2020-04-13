using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGetComp : MonoBehaviour
{
    void Start()
    {
        Unit test;
        var obj = GameObject.FindGameObjectsWithTag("Unit");
        test = obj[0].GetComponent("Unit") as Unit;
        test.team = 2;
    }
}
