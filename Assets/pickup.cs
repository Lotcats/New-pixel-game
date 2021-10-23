using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pickup : MonoBehaviour
{
    public int Coins = 0;
    public Text Amount;

private void OnTriggerEnter2D(Collider2D collision)
    {
     if (collision.gameObject.CompareTag("Coin"))   
     {
         Coins+=1;
         Destroy(collision.gameObject);
     }
    }
    void Update()
    {
        Amount.text = Coins.ToString();
        Debug.Log(Amount.text);

    }
}
