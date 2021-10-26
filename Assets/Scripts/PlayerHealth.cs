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
    public SpriteRenderer Mage;

    void Start()
    {
    
    }

    void OnTriggerEnter2D(Collider2D SpikeCol)
    {

        if (SpikeCol.tag == "Spike") //Write in the string what the tag of your bullet is.
        {
            Health-=1; //Subtracts health from the character.
            Destroy(SpikeCol.gameObject); //This destroys the colliding object.
        }

        if (Health < 1)
        {  // if the health of the character is below 1 then destroy the character.
        controller.enabled = false;
        movement.enabled = false;
        RB.velocity = Vector3.zero;
        YouDied.SetActive(true);
        Mage.enabled = false;
        }
    }
}
