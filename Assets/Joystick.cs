using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    public Transform innercircle;
    public Transform Outercircle;
    private bool touchstart = false;
    private Vector2 pointA;
    private Vector2 pointB;
    public Transform player;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }
    void MovePlayer(Vector2 direction)
    {
        player.Translate(direction * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        if (Input.GetMouseButtonDown(0))
        {
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            innercircle.transform.position = pointA * -1;
            Outercircle.transform.position = pointA * -1;
            innercircle.GetComponent<SpriteRenderer>().enabled = true;
            Outercircle.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (Input.GetMouseButton(0))
        {
            touchstart = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        else
        {
            touchstart = false;
        }
    }
    void FixedUpdate()
    {
        if (touchstart)
        {
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            MovePlayer(direction * -1);
            innercircle.transform.position = new Vector2(pointA.x + direction.x, pointA.y = direction.y) * -1;
        }
        else
        {
            innercircle.GetComponent<SpriteRenderer>().enabled = false;
            Outercircle.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
