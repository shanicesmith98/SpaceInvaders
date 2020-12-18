using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject missile;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(new Vector3(0, 2 * Time.deltaTime, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(missile);
            Score.scoreValue++;
        }

        if (collision.gameObject.tag == "Finish")
        {
            Destroy(missile);
        }
    }
}
