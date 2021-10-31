using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
   [SerializeField] float sceneReloadDelay = 1f; 
   [SerializeField] ParticleSystem finishEffect;
   private void OnTriggerEnter2D(Collider2D other) 
   {
      if (other.tag == "Player")
      {

         // Play particle effect when user crosses finish line
         finishEffect.Play();

         // Play sound effect when user crosses finish
         GetComponent<AudioSource>().Play();

         // Reload the scene when user crosses the finish line
         Invoke("ReloadScene", sceneReloadDelay);
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
