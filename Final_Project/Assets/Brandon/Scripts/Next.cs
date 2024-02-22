using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Next : MonoBehaviour
{
    public void Nextlevel2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Nextlevel3()
    {
        SceneManager.LoadScene("Level 3");
    }
}
