using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type_Change : MonoBehaviour
{
    public GameObject Object;
    MapEditTest Main;
    public int type;
    private void OnMouseDown() 
    {

        Instantiate(Object, new Vector2(transform.position.x, transform.position.y), new Quaternion(0, 0, 0, 0));
        Main = GameObject.FindObjectOfType(typeof(MapEditTest)) as MapEditTest;
        Main.ArrayUpdate(Mathf.FloorToInt(transform.position.x), Mathf.FloorToInt(transform.position.y), type);
        Destroy(gameObject);
    }
}
