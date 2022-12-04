using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public Movement.Gamemodes Gamemode;
    public int State;

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Transform Sprite;

    public Movement ShipMovement;

    Rigidbody2D rb;

    //public float Gravity;

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
            Physics2D.gravity = new Vector2(0, -9.8f);
    
            // reset rotate
            Vector3 Rotation = Sprite.rotation.eulerAngles;
            Rotation.z = 0;
            Sprite.rotation = Quaternion.Euler(Rotation);

        } else
        {

        }
    }
}
