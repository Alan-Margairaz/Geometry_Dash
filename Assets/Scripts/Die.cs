using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{    
    public int Coins;
    public bool PlayerIsDead = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {

        } else
        {
            Coins = 0;
            PlayerIsDead = true;
            SceneManager.LoadScene("Scene");
        }
    } 
}
