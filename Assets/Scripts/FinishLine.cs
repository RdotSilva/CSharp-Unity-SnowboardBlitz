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
           Invoke("ReloadScene", 2f);
           // TODO: Intead of restarting the scene we should load into the next level
      }
   }

   /// <summary>
   ///   Reload the current scene
   /// </summary>
   private void ReloadScene()
   {
      SceneManager.LoadScene(0);
   }
}
