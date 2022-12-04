using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public enum Gamemodes{cube = 0, ship = 1};
    public Movement.Gamemodes Gamemode;
    public int State;

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Transform Sprite;

    Rigidbody2D rb;

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }

    void OnTriggerEnter2D (Collider2D collision)
    {
        try
        {
            Movement movement = collision.gameObject.GetComponent<Movement>();
            movement.ThroughPortal(Gamemode, State);
            ChangeSprite();
        } 
        catch {}

        if (State == 1)
        {
            // Changer gravité
            rb.velocity = Vector2.zero;
            rb.gravityScale = 0f;
            
            Debug.Log("YoPortal");

            // Reset rotate
            Vector3 Rotation = Sprite.rotation.eulerAngles;
            Rotation.z = 0;
            Sprite.rotation = Quaternion.Euler(Rotation);

            if (Input.GetKey(KeyCode.Space))    // Mouvement du ship
            {                   
                Debug.Log("YoMovementP");
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.up * 26.6581f, ForceMode2D.Impulse);
            }
        } else
        {

        }
    }
}
