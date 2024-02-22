using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{
    //Can modify component values to choose next scene
    public string SceneToLoad;
    public void LoadNewScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
