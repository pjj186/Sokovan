using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 3f;
    private Rigidbody playerRigidbody; 

    void Start()
    {
        // 현재 게임오브젝트 컴포넌트 내에 <> 안에 들어간 타입의 컴포넌트를 찾는다.
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float InputX = Input.GetAxis("Horizontal");
        float InputZ = Input.GetAxis("Vertical");
        float fallSpeed = playerRigidbody.velocity.y;

        Vector3 velocity = new Vector3(InputX, 0, InputZ);

        velocity = velocity * speed;

        velocity.y = fallSpeed;

        playerRigidbody.velocity = velocity;
    }
}
