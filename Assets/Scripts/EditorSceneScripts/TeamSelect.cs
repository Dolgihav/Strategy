using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamSelect : MonoBehaviour
{
    public int t = 1;
    public void Select()
    {
        if (t == 1) 
        {
            t = 2; 
        }
        else if (t == 2)
        {
            t = 1;
        }
    }
}
