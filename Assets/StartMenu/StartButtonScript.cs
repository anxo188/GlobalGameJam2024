using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
   
   public void loadBar()
   {
      SceneManager.LoadScene("Assets/Scenes/BarScene.unity");
   }

   public void exit()
   {
      Application.Quit();
   }
    
}
