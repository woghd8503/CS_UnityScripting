using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyClass : MonoBehaviour
{
    // �׻� ǥ�õȴ�.
    public int PublicVar1;


    // �׻� ǥ�õȴ�.
    [SerializeField]
    private int PrivateVar1;

    // ����� ��忡���� ǥ�õȴ�
    private int PrivateVar2;

    // ����� ��忡���� ǥ�õȴ�
    private int PrivateVar3;

    // HideInInspector Ư������ ���������� �ν����Ϳ��� ���� ���� �ִ�. 
}
