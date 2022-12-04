using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    private int Coins = 0;
    // public TMP_Text CoinText;

    [SerializeField] private Text CoinsText;

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SecretCoin"))
        {
            Destroy(collision.gameObject);
            Coins++;

            // GetComponent<TMP_Text>();
            // CoinsText.SetText("Coins: " + (string)Coins);
        }
    }
}
