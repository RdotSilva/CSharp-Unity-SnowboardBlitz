using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D other)
  {
      if (other.tag == "Ground")
      {
          // Reload the scene when user bumps head
        SceneManager.LoadScene(0);
      }
  }
}
