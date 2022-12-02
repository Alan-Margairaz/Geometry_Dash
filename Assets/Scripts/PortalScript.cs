using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public Movement.Gamemodes Gamemode;
    public int State;

    void OnCollisionEnter2D (Collision2D collision)
    {
        try
        {
            Movement movement = collision.gameObject.GetComponent<Movement>();

            movement.ThroughPortal(Gamemode, State);
        } catch 
        {}
    }
}
