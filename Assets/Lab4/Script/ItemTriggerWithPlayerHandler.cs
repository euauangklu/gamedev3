using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Euaungkul.GameDev3.Chapter1
{
    public class ItemTriggerWithPlayerHandler : MonoBehaviour
    {
        // Start is called before the first frame update
        protected virtual void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (gameObject.CompareTag("Diamond"))
                {
                    ProcessTriggerWithDiamond();
                }
                else if (gameObject.CompareTag("Coin"))
                {
                    ProcessTriggerWithCoin();
                }
                else if (gameObject.CompareTag("PowerUp"))
                {
                    ProcessTriggerWithPowerUp();
                }
                else if (gameObject.CompareTag("PowerDown"))
                {
                    ProcessTriggerWithPowerDown();
                }

                //Get the Inventory component from the player
                var inventory = other.GetComponent<Inventory>();
                //Add the collected item’s tag name to the inventory
                inventory.AddItem(gameObject.tag, 1);

                //Destroy itself
                Destroy(gameObject);
            }
        }

        protected virtual void ProcessTriggerWithDiamond()
        {

        }

        protected virtual void ProcessTriggerWithCoin()
        {

        }
        protected virtual void ProcessTriggerWithPowerUp()
        {

        }
        protected virtual void ProcessTriggerWithPowerDown()
        {

        }

    }
}
