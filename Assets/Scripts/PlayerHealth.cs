using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{

    public int Health = 1;
    public GameObject Player;
    public CharacterController2D controller;
    public PlayerMovement movement;
    public Rigidbody2D RB;
    public GameObject YouDied;
    public GameObject YouWin;
    public SpriteRenderer Mage;

    void OnTriggerEnter2D(Collider2D SpikeCol)
    {

        if (SpikeCol.tag == "Spike")
        {
            Health -= 1;
            Destroy(SpikeCol.gameObject); //Remove the spike after touching it, should also do the same for player
        }
        if (SpikeCol.tag == "Crown")
        {
            Destroy(SpikeCol.gameObject);
            YouWin.SetActive(true);
            RB.velocity = Vector3.zero;
            controller.enabled = false;
            movement.enabled = false;
        }

        if (Health < 1)
        {  // If the health is below 1, (only has 1 health) the player dies
           // Fix camera bug...
           // Remove the sprite of the player as well
            controller.enabled = false;
            movement.enabled = false;
            RB.velocity = Vector3.zero;
            YouDied.SetActive(true);
            Mage.enabled = false;
        }
    }
}
