﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeTypeUnit : MonoBehaviour, IPointerClickHandler
{
    public GameObject Object;
    EditorMain Main;
    TeamSelect Select;
    public int type;
    public int team;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerId == -2)
        {
            Main = GameObject.FindObjectOfType(typeof(EditorMain)) as EditorMain;
            if (type != 1)
            {
                Instantiate(Object, new Vector2(transform.position.x, transform.position.y), new Quaternion(0, 0, 0, 0));
                Main.ArrayUpdate2(Mathf.FloorToInt(transform.position.x), Mathf.FloorToInt(transform.position.y), type);
                Destroy(gameObject);
            }
            else if(type == 1) 
            {
                Main.ArrayUpdate2(Mathf.FloorToInt(transform.position.x), Mathf.FloorToInt(transform.position.y), type);
                Destroy(gameObject);
            }
        }
    }
    void Start() 
    {
        if (team == 0) 
        {
            Select = GameObject.FindObjectOfType(typeof(TeamSelect)) as TeamSelect;
            if (Select.t == 1) { team = 1; }
            else if (Select.t == 2) { team = 2; }
        }
    }
}
