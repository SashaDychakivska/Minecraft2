using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollWumend : MonoBehaviour

{
    public Rigidbody ball_rigidbody;
    public int move_speed;
    public float horozontal;
    public float vertical;


// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horozontal = Input.GetAxis("Horozontal");
        vertical = Input.GetAxis("Vertical");
        var direction_and_speed = new Vector3(horozontal, 0, vertical) * move_speed;
        ball_rigidbody.AddForce( direction_and_speed);
    }
}
