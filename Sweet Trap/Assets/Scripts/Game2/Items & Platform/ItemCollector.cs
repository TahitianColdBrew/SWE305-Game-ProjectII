using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
<<<<<<< Updated upstream:Sweet Trap/Assets/Scripts/ItemCollector.cs
    private int coins = 0;
    private int Food = 0;
    private int Water = 0;
=======
    private int coins;
    [SerializeField] private TextMeshProUGUI coinsText;

    public void Start()
    {
        coins = 0;
        coinsText.text = "" + coins;
    }
>>>>>>> Stashed changes:Sweet Trap/Assets/Scripts/Game2/Items & Platform/ItemCollector.cs

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            coinsText.text = "" + coins;
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
