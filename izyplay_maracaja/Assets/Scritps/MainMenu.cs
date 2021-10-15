using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    

    public void LoadScene(string scene_name)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scene_name);
    }
}
