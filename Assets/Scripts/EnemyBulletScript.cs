using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    public GameObject enemyMissile;
    int playerHealth = 10;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(new Vector3(0, -2 * Time.deltaTime, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && playerHealth == 0)
        {
            Destroy(enemyMissile);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(enemyMissile);
            playerHealth--;
            Debug.Log("Health Status: " + playerHealth);
        }
    }
}
