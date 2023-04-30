using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // --------------------------------------------
    // ������Ʈ�� ������Ʈ�� ���� �� �ִ� ���� Ŭ����
public class Property : MonoBehaviour
{
    // --------------------------------------------
    // private ������ iMyNumber�� ���� ���� public ������Ƽ
    // iMyNumber ������ �����ϴ� public ������Ƽ��
    public int MyNumber
    {
        // ���� ������ �� ȣ��ȴ�
        get
        {
            return iMyNumber; // iMyNumber�� ����Ѵ�
        }
        // ���� ������ �� ȣ��ȴ�

        set
        {
            // ������ 1-10 ������ �� ���� �����ϰ�, �ƴ� ���� �����Ѵ�.
            if(value >= 1 && value <= 10)
            {
                // private ������ ������Ʈ�Ѵ�
                iMyNumber = value;

                // �̺�Ʈ�� ȣ���Ѵ�
                NumberChanged();
            }
        }
    }

    // --------------------------------------------
    // 1-10 ������ ���ڸ� ��� ���� ���� ����
    private int iMyNumber = 0;
    // --------------------------------------------
    // �ʱ�ȭ�� ����Ѵ�
    void Start()
    {
        // MyNumber �� ����
        MyNumber = 11; // ���� 10���� ũ�Ƿ� �����Ѵ�

        // MyNumber �� ����
        MyNumber = 7; // ���� 1-10 �����̹Ƿ� �����Ѵ�
    }
    // --------------------------------------------
    // iMyNumber�� ����� �� �Ҹ��� �̺�Ʈ
    void NumberChanged()
    {
        Debug.Log("Variable iMyNumber changed to : " + iMyNumber.ToString());
    }
    // --------------------------------------------
}
// --------------------------------------------


