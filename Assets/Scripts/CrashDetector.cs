using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
  [SerializeField] float sceneReloadDelay = 0.5f; 
  private void OnTriggerEnter2D(Collider2D other)
  {
      if (other.tag == "Ground")
      {
          // Reload the scene when user bumps head
        Invoke("ReloadScene", sceneReloadDelay);
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
