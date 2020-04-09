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
    int pathx;
    int pathy;
    public int[,] arr = new int[128, 128];
    PVEMain Main;
    private void Start() 
    {
        CoordUpd();
    }
    private void OnMouseDown()
    {
        selected = 1;
        CoordUpd();
    }
    private void CoordUpd() 
    {
        x = Mathf.FloorToInt(transform.position.x);
        y = Mathf.FloorToInt(transform.position.y);
        Main = GameObject.FindObjectOfType(typeof(PVEMain)) as PVEMain;
        Main.selectedx = x;
        Main.selectedy = y;
    }
    void pathfind() 
    {
        for (int i = x-move; i < (move * 2 + 1); i++)
        {
            for (int j = y-move; j < (move * 2 + 1); j++)
            {
                for (int l = move; l > 0; l--)
                {
                    if ((x >= y)||(x==y))
                    {

                    }
                    else 
                    {

                    }
                }
            }
        }
    }
}
