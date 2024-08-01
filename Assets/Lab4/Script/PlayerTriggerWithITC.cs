using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

namespace Euaungkul.GameDev3.Chapter1
{
    public class PlayerTriggerWithITC : MonoBehaviour
    {
        // Start is called before the first frame update
        private void OnTriggerEnter(Collider other)
        { 
            //Get components from item object
             //Get the ItemTypeComponent component from the triggered object
             ItemTypeComponent itc = other.GetComponent <ItemTypeComponent >();
            
             //Get components from the player
             //Inventory
             var inventory = GetComponent <Inventory >();
             //SimpleHealthPointComponent
             var simpleHP = GetComponent <SimpleHealthPointComponent >();
             var CapsulePlayer = GetComponent<CapsulePlayerController>();
            
             if (itc !=null)
                 {
                 switch (itc.Type)
                 {
                     case ItemType.COIN:
                     inventory.AddItem("COIN",1);
                     break;
                     case ItemType.BIGCOIN:
                     inventory.AddItem("BIGCOIN",1);
                     break;
                     case ItemType.POWERUP:
                     if(simpleHP != null)
                         simpleHP.HealthPoint = simpleHP.HealthPoint + 10;
                     break;
                     case ItemType.POWERDOWN:
                     if(simpleHP != null)
                         simpleHP.HealthPoint = simpleHP.HealthPoint - 10;
                     break;
                     case ItemType.SPEEDUP:
                         if (CapsulePlayer != null)
                         {
                             CapsulePlayer.m_DirectionalSpeed = CapsulePlayer.m_DirectionalSpeed + 1;
                             CapsulePlayer.m_DirectionalSprintSpeed = CapsulePlayer.m_DirectionalSprintSpeed + 1;
                         }
                         break;
                     case ItemType.SPEEEDDOWN:
                     {
                         CapsulePlayer.m_DirectionalSpeed = CapsulePlayer.m_DirectionalSpeed - 1;
                         CapsulePlayer.m_DirectionalSprintSpeed = CapsulePlayer.m_DirectionalSprintSpeed - 1;
                     }
                         break;
                     }
                 }
            
            
             Destroy(other.gameObject ,0);
             }
     }
 }

