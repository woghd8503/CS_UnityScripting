using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �����Ӹ��� ������Ʈ�� Y�� �߽����� 2���� ȸ����Ų��
        transform.Rotate(new Vector3(0.0f, 2.0f, 0.0f));
    }
}
