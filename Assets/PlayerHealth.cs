//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerHealth : MonoBehaviour
//{
//#pragma strict
//    var Health : int = 1;
//    var Player : GameObject;
//    var SpikeTag : String;
     
//    function Start()
//    {

//    }

//    function OnTriggerEnter(Trigger : Trigger )
//    {

//        if (collision.gameObject.tag == SpikeTag) //Write in the string what the tag of your bullet is.
//        {
//            Health--; //Subtracts health from the character.
//            Destroy(collision.gameObject); //This destroys the colliding object.

//        }

//        if (Health < 1)
//        {  // if the health of the character is below 1 then destroy the character.
//            Destroy(Player;
//        }
//    }

//}
