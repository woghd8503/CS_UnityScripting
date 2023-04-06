using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public GameObject[] MyObjects;

    // Start is called before the first frame update
    void Start()
    {
        // 배열의 내용을 코드로 채운다
        MyObjects = new GameObject[3];
        // 씬에 MainCamera 태그로 설정된 카메라가 있어야 한다
        MyObjects[0] = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
