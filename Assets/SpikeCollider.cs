//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class SpikeCollider : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {
//        //This script is designed to be attached to your spike gameobject

//        //This function will be called every time we touch another collider
//        //If you are using a collider with the "IsTrigger" option selected, use OnTriggerEnter2D instead
//        void OnTriggerEnter2D(Collider2D col)
//        {
//            //When this is called, it will give us the collider we touched as a parameter
//            //We can touch lots of different colliders, so before we try to deal damage lets check what we are colliding with
//            //This assumes that the player gameobject has been given a tag called "Player"
//            if (col.CompareTag("Player"))
//            {
//                //If we are colliding with the player, then you can now deal damage.
//                //Do this however you want. Usually you will want to access some component on the player gameobject, then call a function that deals damage.
//                col.GetComponent<PlayerHealth>().DealDamage(100);
//            }
//        }
//    }


//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}
