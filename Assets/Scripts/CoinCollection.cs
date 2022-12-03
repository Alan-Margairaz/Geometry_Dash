// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class CoinCollection : MonoBehaviour
// {
//     private int Coins = 0; 

//     [SerializeField] private Text StarText;

//     private void OnTriggerEnter2D (Collider2D collision)
//     {
//         if (collision.gameObject.CompareTag("Coin"))
//         {
//             Destroy(collision.gameObject);
//             Coins++;
//             StarText.text = ": " + Coins;
//         }
//     }
// }
