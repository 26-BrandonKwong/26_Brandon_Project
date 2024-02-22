using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float speed;
    void FixedUpdate()
    {
        //Left to Right movement
        transform.position += new Vector3(speed,0,0);
    }
    //For reversing enemy movement between walls
    private void OnCollisionEnter(Collision collision)
    {
        speed = -speed;
    }
}
