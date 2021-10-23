using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int coinCount;

    public void PickupItem()
    {
        coinCount++;
    }
}
