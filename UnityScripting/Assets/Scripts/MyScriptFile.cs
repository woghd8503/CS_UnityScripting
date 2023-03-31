using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScriptFile : MonoBehaviour
{
    // 열거형을 사용해 가능한 상태를 정의한다
    public enum EnemyState { CHASE, FLEE, FIGHT, HIDE };

    // 적의 현재 상태
    public EnemyState ActiveState = EnemyState.CHASE;

    // 여기에서 초기화한다

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
