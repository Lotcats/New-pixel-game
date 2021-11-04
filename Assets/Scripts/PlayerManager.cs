using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int coinCount;
    //int means integer, aka whole numbers
    public void PickupItem()
    {
        coinCount++;
    }
}
