using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportOnTouch : MonoBehaviour
{
    public Vector2 teleportTo = new Vector2(0,0);


    void OnCollisionEnter2D(Collision2D collision)
    {
        collision.collider.transform.position = new Vector3(teleportTo.x, teleportTo.y, 0);
        Debug.Log(collision.collider);
    }

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(teleportTo.x, teleportTo.y, 0);
        Debug.Log(other);
    }
}
