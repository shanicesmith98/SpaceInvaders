using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.5f;

    public GameObject missile;
    public GameObject missileClone;

    void Start()
    {

    }

    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeToMove)
        {
            transform.Translate(new Vector3(0.1f, 0f, 0));
            timer = 0;
        }
    }
}
