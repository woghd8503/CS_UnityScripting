using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScriptFile : MonoBehaviour
{
    // �������� ����� ������ ���¸� �����Ѵ�
    public enum EnemyState { CHASE, FLEE, FIGHT, HIDE };

    // ���� ���� ����
    public EnemyState ActiveState = EnemyState.CHASE;

    // ���⿡�� �ʱ�ȭ�Ѵ�

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}