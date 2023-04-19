using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour
{
    // 오크의 트랜스폼 컴포넌트 (위치, 회전, 크기)에 대한 참조변수다
    private Transform ThisTransform = null;

    // 오크 상태의 열거형
    public enum OrcStates { NETURAL, ATTACK_MELEE, ATTACK_RANGE }

    // 오크의 현재 상태
    public OrcStates CurrentState = OrcStates.NETURAL;

    // 오크가 초당 이동 속도(m/s)
    public float OrcSpeed = 10.0f;

    // 오크가 클레이어에게 호의적인지
    public bool isFriendly = false;

    // ----------------------------------------------------------------------
    // 여기에서 초기화한다
    void Start()
    {
        // 오크의 트랜스폼을 얻는다
        ThisTransform = transform;
    }
    // ----------------------------------------------------------------------
    // Update는 매 프레임마다 한 번씩 호출된다
    void Update()
    {
        
    }
    // ----------------------------------------------------------------------
    // 오크의 상태별 동작들
    public void AttackMelee()
    {
        // 여기에서 근접 공격을 한다
    }
    // ----------------------------------------------------------------------
    public void AttackRange()
    {
        // 여기에서 원거리 공격을 한다

    }
}
