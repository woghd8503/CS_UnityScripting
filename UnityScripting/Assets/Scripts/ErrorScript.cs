using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorScript : MonoBehaviour
{
    int MyNumber = 5;

    // ���⿡�� �ʱ�ȭ�Ѵ�
    void Start()
    {
        Debug.Log("Object created in scene at position: " + transform.position.ToString());
        MyNumber = 7;
    }

    // Update is called once per frame
    void Update()
    {
        // ���� �߻�
        //Mynumber = 10;
    }
}
