using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(60 * Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime);
        // Time.deltaTime 은 화면이 한번 깜빡이는 시간 = 한 프레임의 시간
        // 화면을 60번 깜박하면 ( 초당 60프레임 ) 1/60
        // 화면을 200번 깜빡이면 ( 초당 200프레임 ) 1/200
        // 60/200 * 200 = 60
    }
}
