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
        FireMissile();
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

    void FireMissile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            missileClone = Instantiate(missile, new Vector3(this.transform.position.x, this.transform.position.y + 0.8f, 0), this.transform.rotation) as GameObject;
        }
    }
}
