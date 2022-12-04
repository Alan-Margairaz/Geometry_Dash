using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public float Speed = 10.4f;
    public float RotationSpeed;
    public int State;

    private bool TouchingGround;
    public Transform CheckGround;
    public float CheckGroundRadius;
    public LayerMask GroundMask;

    public Transform Sprite; 

    public enum Gamemodes{cube = 0, ship = 1};
    public Gamemodes CurrentGamemode;
 
    // [SerializeField] private AudioSource DeathSoundEffect;
    //Add death animation & death process 

    Rigidbody2D rb; 

    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update ()
    {
        transform.position += Vector3.right * Speed * Time.deltaTime;   // Mouvement du cube

        if (State == 0)
        {
            TouchingGround = Physics2D.OverlapCircle(CheckGround.position, CheckGroundRadius, GroundMask);

            if (TouchingGround)
            {
                Vector3 Rotation = Sprite.rotation.eulerAngles;     // Rotation
                Rotation.z = Mathf.Round(Rotation.z/90) * 90;
                Sprite.rotation = Quaternion.Euler(Rotation);

                if (Input.GetKey(KeyCode.Space))                // Saut
                {
                    rb.velocity = Vector2.zero;                 // Ajout d'une force pour équilibrer le saut
                    rb.AddForce(Vector2.up * 26.6581f, ForceMode2D.Impulse);
                }      
            } else 
            {
                Sprite.Rotate(Vector3.back * RotationSpeed);
            } 
        } else
        {
            if (Input.GetKey(KeyCode.Space))    // Ajoute du mouvement du ship
            {
                transform.position += Vector3.right * Speed * Time.deltaTime;

            }
        }
    }

    public void ThroughPortal(Gamemodes Gamemode, int State)
    {
        switch(State)
        {
            case 0:
                CurrentGamemode = Gamemode;
                break;
        }
    }
}
