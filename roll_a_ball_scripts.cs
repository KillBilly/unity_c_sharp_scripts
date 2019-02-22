/* the below codes create a Player Controller that would take users input as force to move */
// Rigidbody Class: .AddForce()
// Input Class: .GetAxis()
// Vector3 struct
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>(); // add physics to the player
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }
}


// the below code create a Camera Controller that force Camera to move with Player
// GameObject Class: .transform.position
// Transform Class: .position
using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

    void Start ()
    {
        offset = transform.position - player.transform.position; // camera's position - player's position
    }
    
    void LateUpdate ()
    {
        transform.position = player.transform.position + offset; // transform is the position attributes
    }
}


// the below code create a Rotator to rotate object
// Transform Class: .Rotate()
using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    void Update () 
    {
        transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
    }
}

