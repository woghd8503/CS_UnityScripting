using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �� ������Ʈ�� �پ��ִ� ��� ������Ʈ/��ũ��Ʈ���� MyFunction �Լ��� �θ���
        SendMessage("MyFunction", SendMessageOptions.DontRequireReceiver);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
