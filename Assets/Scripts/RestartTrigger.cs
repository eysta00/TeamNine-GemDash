using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AGDDPlatformer
{
    public class RestartTrigger : MonoBehaviour
    {
        GameManager gameManager;
        void Awake()
        {
            gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        }
        void OnTriggerExit2D(Collider2D other)
        {
            PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
            if (playerController != null)
            {
                gameManager.ResetGame();
            }
        }
    }
}