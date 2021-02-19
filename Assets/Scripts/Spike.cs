using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AGDDPlatformer
{
public class Spike : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
        {
            PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.ResetPlayer();
            }
        }
}
}

