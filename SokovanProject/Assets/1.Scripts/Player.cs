using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float speed = 10f;
    public Rigidbody playerRigidbody; 

    void Start()
    {
        playerRigidbody.AddForce(0, 1000, 0);
    }


    void Update()
    {
        
    }
}
