using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeType : MonoBehaviour, IPointerClickHandler
{
    public GameObject Object;
    public GameObject Object2;
    EditorMain Main;
    public int type;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerId == -1)
        {
            Instantiate(Object, new Vector2(transform.position.x, transform.position.y), new Quaternion(0, 0, 0, 0));
            Main = GameObject.FindObjectOfType(typeof(EditorMain)) as EditorMain;
            Main.ArrayUpdate(Mathf.FloorToInt(transform.position.x), Mathf.FloorToInt(transform.position.y), type);
            Destroy(gameObject);
        }
        else if (eventData.pointerId == -2) 
        {
            Main = GameObject.FindObjectOfType(typeof(EditorMain)) as EditorMain;
            if (Main.arr[Mathf.FloorToInt(transform.position.x),Mathf.FloorToInt(transform.position.y),1] == 0) 
            {
                Instantiate(Object2, new Vector2(transform.position.x, transform.position.y), new Quaternion(0, 0, 0, 0));
                Main.ArrayUpdate2(Mathf.FloorToInt(transform.position.x), Mathf.FloorToInt(transform.position.y), 0);
            }
        }
    }
}
