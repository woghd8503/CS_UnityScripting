using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMessage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �� ������Ʈ�� �پ��ִ� ��� ������Ʈ/��ũ��Ʈ���� MyFunction �Լ��� �θ���
        SendMessage("MyFunction", SendMessageOptions.DontRequireReceiver);
    }

    // SendMessage�� ȣ��� �� ����ȴ�.
    void MyFunction()
    {
        Debug.Log("hello");
    }
}
