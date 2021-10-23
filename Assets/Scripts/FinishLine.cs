using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) 
   {
      if (other.tag == "Player")
      {
           // Reload the scene when user crosses the finish line
           SceneManager.LoadScene(0);
      }
   }
}
