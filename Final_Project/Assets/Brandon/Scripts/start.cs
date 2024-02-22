using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Restart2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Restart3()
    {
        SceneManager.LoadScene("Level 3");
    }
}
