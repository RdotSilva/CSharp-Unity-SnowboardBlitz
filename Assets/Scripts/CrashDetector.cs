using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
  LevelGenerator levelGenerator;
  private void OnTriggerEnter2D(Collider2D other)
  {
      if (other.tag == "Ground")
      {
          Debug.Log("You bumped your head!");
          // TODO: Add logic to reset game when player bumps head
          // For now just restart the level
          levelGenerator.OnFinishLevel();
      }
  }
}
