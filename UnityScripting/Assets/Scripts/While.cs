using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
