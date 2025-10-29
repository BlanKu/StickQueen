using System.Timers;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerSpeed;

    public GameObject Player;
    public GameObject LeftFoot;
    public GameObject RightFoot;

    Rigidbody2D _rbLeftFoot;
    Rigidbody2D _rbRightFoot;

    Collider2D _collider2DPlayer;
    Collider2D _collider2DLeftFoot;
    Collider2D _collider2DRightFoot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rbLeftFoot = LeftFoot.GetComponent<Rigidbody2D>();
        _rbRightFoot = RightFoot.GetComponent<Rigidbody2D>();

        _collider2DPlayer = GetComponent<Collider2D>();
        _collider2DLeftFoot = LeftFoot.GetComponent<Collider2D>();
        _collider2DRightFoot = RightFoot.GetComponent<Collider2D>();

        Physics2D.IgnoreCollision(_collider2DPlayer, _collider2DLeftFoot);
        Physics2D.IgnoreCollision(_collider2DPlayer, _collider2DRightFoot);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rbLeftFoot.angularVelocity = -playerSpeed;
            Debug.Log("Pressed A");

        }
        if (Input.GetKey(KeyCode.D))
        {
            _rbLeftFoot.angularVelocity = playerSpeed;
            Debug.Log("Pressed D");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rbRightFoot.angularVelocity = -playerSpeed;
            Debug.Log("Pressed <-");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rbRightFoot.angularVelocity = playerSpeed;
            Debug.Log("Pressed ->");
        }
    }
}
