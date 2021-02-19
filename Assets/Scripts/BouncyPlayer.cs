using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AGDDPlatformer
{
    public class BouncyPlayer : MonoBehaviour
    {
    //void OnCollisionEnter2D(Collision2D other)
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
        if (playerController != null)
            {
                playerController.velocity.y = (float)Mathf.Sqrt(Mathf.Pow(playerController.velocity.y,2)) * (float)0.95;
            }
        }
    }
}
