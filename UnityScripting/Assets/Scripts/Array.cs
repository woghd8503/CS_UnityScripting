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

        // GameObjec.Find �Լ��� ����� ���� ������Ʈ�� �̸����� ã�´�
        MyObjects[1] = GameObject.Find("Cube");
        MyObjects[2] = GameObject.Find("Cylinder");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
