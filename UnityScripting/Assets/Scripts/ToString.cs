using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//----------------------------------------------
// ���� �� ����� Ŭ����

public class ToString : MonoBehaviour
{
    public enum AttackType { PUNCH, MAGIC, SWORD, SPEAR };

    // ���� ���Ǵ� ���� ����
    public AttackType CurrentAttack = AttackType.PUNCH;

    // ����
    public int Health = 100;

    // ȸ�� �����ð� (���� ��)
    public float RecoveryTime = 1.0f;

    // ������� �̵� �ӵ� - m/s
    public float Speed = 1.0f;

    // ������� �̸�
    public string OreName = "Harry";

    //------------------------------------------------------------
    // ToString �޼ҵ� ������
    public override string ToString()
    {
        // Ŭ������ �����ϴ� ���ڿ��� ��ȯ�Ѵ�
        return string.Format("***Class EnemyOgre*** OgreName: {0} | "
            + "Health: {1} | Speed: {2} | "
            + "CurrentAttack: {3} | RecoveryTime: {4}",
            OreName, Health, Speed, CurrentAttack, RecoveryTime);
    }
    void Start()
    {
        // ������Ʈ�� ���ڿ��� ��ȯ�ϴ� �׽�Ʈ �ڵ� �׽�Ʈ �� �����ص� �ȴ�
        Debug.Log(ToString());
    }
    //------------------------------------

}
//-----------------------------------------
