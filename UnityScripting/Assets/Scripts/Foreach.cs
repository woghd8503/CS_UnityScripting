using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour
{
    // ���� ���ӿ�����Ʈ�� ��� �迭�̴�
    public GameObject[] MyObjects;

    // Start is called before the first frame update
    void Start()
    {
        // �ϳ��� �迭�� ��� ������Ʈ�� �ڵ带 �ݺ���Ų��
        foreach(GameObject obj in MyObjects)
        {
            // ������Ʈ�� �ı��Ѵ�
            DestroyImmediate(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
