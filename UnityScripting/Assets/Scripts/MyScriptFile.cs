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
        // ActiveState ������ �˻��Ѵ�
        switch(ActiveState)
        {
            case EnemyState.FIGHT:
                {
                    // ELIGHT �ڵ带 ���⼭ �����Ѵ�
                    Debug.Log("Entered fight state");
                }
                break;
            case EnemyState.FLEE:
            case EnemyState.HIDE:
                {
                    // FLEE�� HIDE�� ���� ������ �Ѵ�.
                    Debug.Log("Entered flee or hide state");
                }
                break;
        }

        
    }
}
