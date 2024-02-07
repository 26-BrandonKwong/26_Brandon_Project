using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start1 : MonoBehaviour
{
  public void Nextlevel()
    {
        SceneManager.LoadScene("Level2");
    }
}
