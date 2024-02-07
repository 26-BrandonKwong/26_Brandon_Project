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
    public void Nextlevel()
    {
        SceneManager.LoadScene("Level2");
    }
    public void ERT()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
