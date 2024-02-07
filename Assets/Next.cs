using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Next : MonoBehaviour
{
    public void Nextlevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
