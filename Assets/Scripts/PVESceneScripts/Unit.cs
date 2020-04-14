using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public int team;
    public int hp;
    public int move;
    public int turn;
    public int selected;
    public int type;
    public int x;
    public int y;
    public GameObject[] objects;
    PVEMain Main;
    int pathx;
    int pathy;
    public int[,] arr = new int[128, 128];
    private void OnMouseDown()
    {
        selected = 1;
        pathfind();
    }
    void pathfind() 
    {
        var objs = GameObject.FindGameObjectsWithTag("Cell");
        Main = GameObject.FindObjectOfType(typeof(PVEMain)) as PVEMain;
        x = Mathf.FloorToInt(transform.position.x);
        y = Mathf.FloorToInt(transform.position.y);
        for (int i = x-move; i < (x+move+1); i++)
        {
            for (int j = y-move; j < (y+move+1); j++)
            {
                pathx = x;
                pathy = y;
                for (int l = move; l > 0; l--)
                {
                    if (pathx < i && Main.arr[pathx + 1, pathy, 0] == 0 && pathx + 1 >-1 && pathx + 1 < 128) 
                    {
                        pathx++;
                        Instantiate(objects[0], new Vector2(pathx, pathy), new Quaternion(0, 0, 0, 0));
                    }
                    else if (pathx > i && Main.arr[pathx - 1, pathy, 0] == 0 && pathx - 1 > -1 && pathx - 1 < 128)
                    {
                        pathx--;
                        Instantiate(objects[0], new Vector2(pathx, pathy), new Quaternion(0, 0, 0, 0));
                    }
                    else if (pathy < j && Main.arr[pathx, pathy + 1, 0] == 0 && pathy + 1 > -1 && pathy + 1 < 128)
                    {
                        pathy++;
                        Instantiate(objects[0], new Vector2(pathx, pathy), new Quaternion(0, 0, 0, 0));
                    }
                    else if (pathy > j && Main.arr[pathx, pathy - 1, 0] == 0 && pathy - 1 > -1 && pathy - 1 < 128)
                    {
                        pathy--;
                        Instantiate(objects[0], new Vector2(pathx, pathy), new Quaternion(0, 0, 0, 0));
                    }
                }
            }
        }
    }
}
