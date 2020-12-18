using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static int playerHealthValue = 10;
    Text healthText;

    void Start()
    {
        healthText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + playerHealthValue;
    }
}
