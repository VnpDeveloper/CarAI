using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speedPlayer = 5;
    private float acceleration;
    void Start()
    {
        acceleration = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetKeyInput();

        MovementControl();
    }

    private void GetKeyInput()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            if (acceleration != speedPlayer)
            {
                acceleration++;
                if (acceleration > speedPlayer)
                {
                    acceleration = speedPlayer;
                }
            }
            transform.position += transform.forward * acceleration * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            if (acceleration != 0)
            {
                acceleration--;
                if (acceleration < 0)
                {
                    acceleration = 0;
                }
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Debug.Log("Left");
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Debug.Log("Right");
        }

        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
        {
            acceleration = 0;
        }
    }

    private void MovementControl()
    {

    }
}
