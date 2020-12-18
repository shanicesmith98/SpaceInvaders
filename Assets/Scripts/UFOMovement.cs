using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOMovement : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.5f;
    int numOfMovements = 0;
    float speed = 0.1f;

    void Start()
    {
        
    }

    
    void Update()
    {
        timer += Time.deltaTime;
        XYMovement();
    }

    void XYMovement()
    {
        if (numOfMovements == 60)
        {
            Vector3 position = this.transform.position;
            position.x += speed;
            this.transform.position = position;
            numOfMovements = -1;
            speed = -speed;
        }

        if (timer > timeToMove && numOfMovements < 60)
        {
            Vector3 position = this.transform.position;
            position.x -= speed;
            this.transform.position = position;
            timer = 0;
            numOfMovements++;
        }
    }
}
