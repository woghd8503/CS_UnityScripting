using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    void Start()
    {
        // �� ���� �޽����� ��µǾ������� ����
        int NumberOfMessages = 0;
        
        // �ټ� ���� �޽����� �ֿܼ� ��µ� ������ �ݺ��Ѵ�
        while(NumberOfMessages < 5)
        {
            // �޽��� ���
            Debug.Log("This is Message: " + NumberOfMessages.ToString());

            // ī���� ����
            ++NumberOfMessages;
        }
    }
}
