using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerScript : MonoBehaviour
{
    public float speed;
    public float score;
    public float timeLeft;
    public Text scoreText;
    public Text timeText;
    public AudioSource audioPlayer;
    void FixedUpdate()
    {
        //Movement
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0));
        //Timer
        timeLeft -= Time.deltaTime;
        timeText.text = "Time Left: " + ((int)timeLeft);
        //Lose Condition
        if (timeLeft <= 0)
            SceneManager.LoadScene("GameLose");
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Lose Condition if other GameObject has Enemy tag
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("GameLose");
        }
        //Points Collection
        else if (collision.gameObject.tag == "Point")
        {
            score++;
            scoreText.text = "Points: " + score;
            audioPlayer.Play();
            Destroy(collision.gameObject);
        }
        //Win Condition
        else if (collision.gameObject.tag == "Finish")
        {
            //Checks that no GameObjects tagged "Point" are still in the scene
            if(GameObject.FindGameObjectsWithTag("Point").Length==0)
            {
                SceneManager.LoadScene("GameWin");
            }
        }
    }
}
