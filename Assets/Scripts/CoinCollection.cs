using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public int Coins = 0;

    [SerializeField] private Text CoinsText;

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SecretCoin"))
        {
            Destroy(collision.gameObject);
            Coins++;
        }
    }
}
