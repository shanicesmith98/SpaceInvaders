using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    public GameObject enemyMissile;

    void Start()
    {
        
    }
    
    void Update()
    {
        transform.Translate(new Vector3(0, -2 * Time.deltaTime, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && PlayerHealth.playerHealthValue <= 1)
        {
            Destroy(collision.gameObject);
            Destroy(enemyMissile);
        }

        if (collision.gameObject.tag == "Player")
        { 
            Destroy(enemyMissile);
            PlayerHealth.playerHealthValue--;
        }

        if (collision.gameObject.tag == "Finish")
        { 
            Destroy(enemyMissile);
        }
    }
}
