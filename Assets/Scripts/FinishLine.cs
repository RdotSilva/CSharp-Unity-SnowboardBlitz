using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) 
   {
      if (other.tag == "Player")
      {
           Debug.Log("You have finished!");
       // TODO: Add logic for when a player crosses finish line
      }
   }
}
