using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class hit : MonoBehaviour
{
    Text display;
    int score = 0;


    void OnTriggerEnter(Collider col)
    {
        //all projectile colliding game objects should be tagged "Enemy" or whatever in inspector but that tag must be reflected in the below if conditional
        if (col.gameObject.tag == "meme")
        {
            
            Destroy(col.gameObject);
            //add an explosion or something
            //destroy the projectile that just caused the trigger collision
            Destroy(gameObject);
            score++;
            display.text = "Score: " + score.ToString();
        }
    }
}