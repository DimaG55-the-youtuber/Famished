using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{   [Header("Base setup")]
    public float health = 100.0f;
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Sword")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            print("Do something here");
            health = health - 20
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (health >= 0)
        {
            print("IM DEAD");
        }
        
    }
}
