using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public Rigidbody2D rb;
    //private Animator DeathAnim;

    private void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        //DeathAnim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            Die();
        }
    }
    
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        //DeathAnim.SetTrigger("death")
    }
}
