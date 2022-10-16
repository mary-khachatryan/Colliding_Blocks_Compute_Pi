using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{   
   public static int version;
   
    public void ResScene()
    {
       
       
        SceneManager.LoadScene("menu");
       
    }
   /*public void OnMouseDown()
    {
        version = gameObject.name;
        Debug.Log("ver" + version);
        SceneManager.LoadScene("GameScene");

    }*/
    public void PlayGame()
    {
        version =int.Parse(gameObject.name);
        Debug.Log("ver" + version);
        SceneManager.LoadScene("GameScene");
    }
}
