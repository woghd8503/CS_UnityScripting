using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializeField_ : MonoBehaviour
{
    // �׻� ǥ�õȴ�
    public int publicVar1;

    // �׻� ǥ�õȴ�
    [SerializeField]
    private int privateVal1;

    // ���������� �ν����Ϳ��� ���� �� �ִ�
    [HideInInspector]
    public int publicVar2;

    // ����� ��忡���� ǥ�õȴ�
    private int privateVal2;

    // ����� ��忡���� ǥ�õȴ�
    private int privateVar3;
}
