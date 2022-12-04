using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followCube;

    void FixedUpdate()
    {
        this.transform.position = new Vector3 (followCube.position.x, followCube.position.y, -10);
    }
}
