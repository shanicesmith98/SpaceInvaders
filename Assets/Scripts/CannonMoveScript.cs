using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMoveScript : MonoBehaviour
{
    public GameObject player;
    public GameObject missile;
    public GameObject missileClone;

    void Start()
    {
        
    }

    void Update()
    {
        PlayerMovement();
        FireBullet();
    }

    void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x -= 0.1f;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x += 0.1f;
            this.transform.position = position;
        }
    }

    void FireBullet()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            missileClone = Instantiate(missile, new Vector3(player.transform.position.x, player.transform.position.y + 0.8f, 0), player.transform.rotation) as GameObject;
        }
    }
}
