using System.Timers;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerSpeed;

    public Rigidbody2D LeftFoot;
    public Rigidbody2D RightFoot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            LeftFoot.angularVelocity = -playerSpeed;
            Debug.Log("Pressed A");
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            LeftFoot.angularVelocity = playerSpeed;
            Debug.Log("Pressed D");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            RightFoot.angularVelocity = -playerSpeed;
            Debug.Log("Pressed <-");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            RightFoot.angularVelocity = playerSpeed;
            Debug.Log("Pressed ->");
        }
    }
}
