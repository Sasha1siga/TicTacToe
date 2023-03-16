using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cross, zero;
    public enum cell {CROSS, ZERO };
    public cell turn;
    //public int i = 0;

    public void SpawnNew(GameObject obj)
    {
        if (turn == cell.CROSS)
        {
            Instantiate(cross, obj.transform.position, Quaternion.identity);
            turn = cell.ZERO;
            //i++;
        }
        else
        {
            Instantiate(zero, obj.transform.position, Quaternion.identity);
            turn = cell.CROSS;
            //i++;
        }

        Destroy(obj.gameObject);
    }


}
