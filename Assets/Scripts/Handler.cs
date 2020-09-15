using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Handler : MonoBehaviour
{
    /*This Script was made for Main menu when changing scenes*/
   public void SceneChange()
    {
        SceneManager.LoadScene(1);
    }
  
}
