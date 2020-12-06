using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.5f;
    int numOfMovements = 0;
    float speed = 0.1f;

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
            Vector3 position = this.transform.position;
            position.x += speed;
            this.transform.position = position;
            timer = 0;
            numOfMovements++;
        }

        if (numOfMovements == 20)
        {
            Vector3 position = this.transform.position;
            position.y -= 0.5f;
            this.transform.position = position;
            numOfMovements = 0;
            speed = -speed;
        }
    }
}
