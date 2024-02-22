using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Colllision : MonoBehaviour
{

    public float speed;
    public float minX;
    public float maxX;
    public Text scoreText;
    public int score;
    public AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 newPosition = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);

        transform.position = newPosition;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has a specific tag
        if (other.CompareTag("Healthy"))
        {
            Destroy(other.gameObject);
            score++;
            audioPlayer.Play();
            scoreText.text = "Score: " + score;
            
            if (score >= 10)
            {
               SceneManager.LoadScene("Win");
            }
        }
        if (other.CompareTag("Unhealthy"))
        {

            SceneManager.LoadScene("Lose");
            Destroy(other.gameObject);
        }
    }
}
