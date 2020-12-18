using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.5f;
    int numOfMovements = 0;
    float speed = 0.1f;

    public GameObject enemyMissile;
    public GameObject missileClone;
    public GameObject Player;
    //private bool playerFound = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        timer += Time.deltaTime;
        

        // fire missile if player is directly below
        
        /*RaycastHit2D playerCheck = Physics2D.Raycast(transform.position, Vector2.down, 15f, LayerMask.GetMask("Player"));

        if (playerCheck)
        {
            playerFound = true;
        }

        if (playerFound)*/

        if (PlayerHealth.playerHealthValue > 0)
        {
            XYMovement();
            fireMissile();
        }
           
    }

    void XYMovement()
    {
        // move down y axis after 20 movements on x axis 
        if (numOfMovements == 20)
        {
            Vector3 position = this.transform.position;
            position.y -= 0.5f;
            this.transform.position = position;
            numOfMovements = -1;
            speed = -speed;
        }

        // move across x axis on timed interval
        if (timer > timeToMove && numOfMovements < 20)
        {
            Vector3 position = this.transform.position;
            position.x += speed;
            this.transform.position = position;
            timer = 0;
            numOfMovements++;
        }

    }

    void fireMissile()
    {
        if (Random.Range(0f, 10000f) < 1)
        {
            missileClone = Instantiate(enemyMissile, new Vector3(this.transform.position.x, this.transform.position.y - 0.4f, 0), this.transform.rotation) as GameObject;
        }
    }
}
