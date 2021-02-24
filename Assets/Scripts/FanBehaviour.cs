using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AGDDPlatformer
{
    public class FanBehaviour : MonoBehaviour
    {
        public int direction = 0;
        public float power = 1;
        void OnTriggerStay2D(Collider2D other)
        {
            PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
            if (playerController != null)
            {
                switch (direction){
                    case 0:
                        playerController.velocity.y += power;
                        break;
                    case 1:
                        playerController.isInFan = true;
                        playerController.fanPower = power;
                        break;
                    case 2:
                        playerController.velocity.y -= power;
                        break;
                    case 3:
                        playerController.isInFan = true;
                        playerController.fanPower = -power;
                        break;
                }
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.isInFan = false;
            }
        }
    }
}
