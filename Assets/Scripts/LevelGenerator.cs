using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    private void OnFinishLevel() 
    {
        // Reload the scene when user crosses the finish line
        SceneManager.LoadScene(0);
    }
}
