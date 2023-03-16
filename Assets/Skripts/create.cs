using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{

    public GameObject GameManager;
    public GameManager Script;

    void Awake()
    {
        Script = GameManager.GetComponent<GameManager>();
    }

    void OnMouseDown()
    {
        Script.SpawnNew(this.gameObject);
    }
}
