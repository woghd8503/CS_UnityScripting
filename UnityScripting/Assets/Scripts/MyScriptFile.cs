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
        // ActiveState 변수를 검사한다
        switch(ActiveState)
        {
            case EnemyState.FIGHT:
                {
                    // ELIGHT 코드를 여기서 실행한다
                    Debug.Log("Entered fight state");
                }
                break;
            case EnemyState.FLEE:
            case EnemyState.HIDE:
                {
                    // FLEE와 HIDE는 같은 동작을 한다.
                    Debug.Log("Entered flee or hide state");
                }
                break;
        }

        
    }
}
