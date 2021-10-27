using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
  [SerializeField] float sceneReloadDelay = 0.5f; 
  [SerializeField] ParticleSystem crashEffect;
  private void OnTriggerEnter2D(Collider2D other)
  {
      if (other.tag == "Ground")
      {
        // Play effect if users crashes on ground
        crashEffect.Play();
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
