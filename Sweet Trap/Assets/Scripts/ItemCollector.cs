using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private int coins = 0;
    private int Food = 0;
    private int Water = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coins++;
        }

        if(collision.gameObject.CompareTag("Food"))
        {
            Destroy(collision.gameObject);
            Food++;
        }

        if (collision.gameObject.CompareTag("Water"))
        {
            Destroy(collision.gameObject);
            Water++;
        }
    }
}
