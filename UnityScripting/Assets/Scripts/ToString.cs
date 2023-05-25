using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//----------------------------------------------
// 예제 적 오우거 클래스

public class ToString : MonoBehaviour
{
    public enum AttackType { PUNCH, MAGIC, SWORD, SPEAR };

    // 현재 사용되는 공격 형태
    public AttackType CurrentAttack = AttackType.PUNCH;

    // 생명
    public int Health = 100;

    // 회복 지연시간 (공격 후)
    public float RecoveryTime = 1.0f;

    // 오우거의 이동 속도 - m/s
    public float Speed = 1.0f;

    // 오우거의 이름
    public string OreName = "Harry";

    //------------------------------------------------------------
    // ToString 메소드 재정의
    public override string ToString()
    {
        // 클래스를 설명하는 문자열을 반환한다
        return string.Format("***Class EnemyOgre*** OgreName: {0} | "
            + "Health: {1} | Speed: {2} | "
            + "CurrentAttack: {3} | RecoveryTime: {4}",
            OreName, Health, Speed, CurrentAttack, RecoveryTime);
    }
    void Start()
    {
        // 오브젝트를 문자열로 변환하는 테스트 코드 테스트 후 삭제해도 된다
        Debug.Log(ToString());
    }
    //------------------------------------

}
//-----------------------------------------
