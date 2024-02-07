using System.Collections;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float speed;
    public AudioSource audioPlayer;
    public Text timerText;
    private float timer = 0f;
    private bool isGameOver = false;
    public Text scoreText;
    int score = 0;
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if (!isGameOver)
        {
            timer += Time.deltaTime;

            UpdateTimerTextOnPlayer();

            if (timer >= 25f)
            {
                GameOver();
            }
        }
    }

    void UpdateTimerTextOnPlayer()
    {
        // Format the timer value as minutes and seconds
        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");

        // Update the UI text on the player's GameObject with the formatted timer value
        if (timerText != null)
        {
            timerText.text = "Time: " + minutes + ":" + seconds;
        }
    }

    void GameOver()
    {
        isGameOver = true;
        SceneManager.LoadScene("LoseScene");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectible")
        {
            Destroy(collision.gameObject);
            audioPlayer.Play();
            score++;
            scoreText.text = "Score: " + score.ToString();
            if (score == 5)
            {
                Debug.Log("You win!");
                //SceneManager.LoadScene("Level2");
            }
        }
            if (collision.gameObject.tag == "Bomb")
            {
                Destroy(collision.gameObject);
                SceneManager.LoadScene("LoseScene");
            }
        }
    }
