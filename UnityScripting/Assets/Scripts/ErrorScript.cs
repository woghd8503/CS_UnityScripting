using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorScript : MonoBehaviour
{
    int MyNumber = 5;

    // 여기에서 초기화한다
    void Start()
    {
        Debug.Log("Object created in scene at position: " + transform.position.ToString());
        MyNumber = 7;
    }

    // Update is called once per frame
    void Update()
    {
        // 에러 발생
        //Mynumber = 10;
    }
}
