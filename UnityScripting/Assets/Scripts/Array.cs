using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public GameObject[] MyObjects;

    // Start is called before the first frame update
    void Start()
    {
        // �迭�� ������ �ڵ�� ä���
        MyObjects = new GameObject[3];
        // ���� MainCamera �±׷� ������ ī�޶� �־�� �Ѵ�
        MyObjects[0] = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
