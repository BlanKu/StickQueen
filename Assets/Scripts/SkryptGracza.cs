using System;
using Unity.VisualScripting;
using UnityEngine;

public class SkryptGracza : MonoBehaviour
{
    public GameObject PrawaNoga;
    public GameObject LewaNoga;
    public float playerSpeed;

    private Rigidbody2D _rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            _rb.angularVelocity = -playerSpeed;
            Debug.Log("Player press A");
        }
    }
}
