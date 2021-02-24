using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventiory : MonoBehaviour
{
    // Start is called before the first frame update

    public static int Collums = 6;
    public static int Rows = 3;

    public int[,] InventoryArray = new int[Rows,Collums];

    void Start()
    {
        
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Collums; j++)
            {
                InventoryArray[i, j] = 0;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Collums; j++)
                {
                    InventoryArray[i, j] = 1;
                }
            }
        }
    }
}
