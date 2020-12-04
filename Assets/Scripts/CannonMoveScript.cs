using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMoveScript : MonoBehaviour
{
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
            missileClone = Instantiate(missile, new Vector3(0, 0, 0), transform.rotation) as GameObject;
        }
    }
}
