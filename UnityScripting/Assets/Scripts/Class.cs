using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour
{
    // ��ũ�� Ʈ������ ������Ʈ (��ġ, ȸ��, ũ��)�� ���� ����������
    private Transform ThisTransform = null;

    // ��ũ ������ ������
    public enum OrcStates { NETURAL, ATTACK_MELEE, ATTACK_RANGE }

    // ��ũ�� ���� ����
    public OrcStates CurrentState = OrcStates.NETURAL;

    // ��ũ�� �ʴ� �̵� �ӵ�(m/s)
    public float OrcSpeed = 10.0f;

    // ��ũ�� Ŭ���̾�� ȣ��������
    public bool isFriendly = false;

    // ----------------------------------------------------------------------
    // ���⿡�� �ʱ�ȭ�Ѵ�
    void Start()
    {
        // ��ũ�� Ʈ�������� ��´�
        ThisTransform = transform;
    }
    // ----------------------------------------------------------------------
    // Update�� �� �����Ӹ��� �� ���� ȣ��ȴ�
    void Update()
    {
        
    }
    // ----------------------------------------------------------------------
    // ��ũ�� ���º� ���۵�
    public void AttackMelee()
    {
        // ���⿡�� ���� ������ �Ѵ�
    }
    // ----------------------------------------------------------------------
    public void AttackRange()
    {
        // ���⿡�� ���Ÿ� ������ �Ѵ�

    }
}
