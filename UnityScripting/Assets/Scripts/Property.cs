using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // --------------------------------------------
    // 오브젝트에 컴포넌트로 붙일 수 있는 예제 클래스
public class Property : MonoBehaviour
{
    // --------------------------------------------
    // private 변수인 iMyNumber를 위해 만든 public 프로퍼티
    // iMyNumber 변수에 접근하는 public 프로퍼티다
    public int MyNumber
    {
        // 값을 가져올 때 호출된다
        get
        {
            return iMyNumber; // iMyNumber를 출력한다
        }
        // 값을 설정할 때 호출된다

        set
        {
            // 범위가 1-10 사이일 때 값을 변경하고, 아닌 경우는 무시한다.
            if(value >= 1 && value <= 10)
            {
                // private 변수를 업데이트한다
                iMyNumber = value;

                // 이벤트를 호출한다
                NumberChanged();
            }
        }
    }

    // --------------------------------------------
    // 1-10 사이의 숫자를 담기 위한 내부 변수
    private int iMyNumber = 0;
    // --------------------------------------------
    // 초기화에 사용한다
    void Start()
    {
        // MyNumber 값 설정
        MyNumber = 11; // 값이 10보다 크므로 실패한다

        // MyNumber 값 설정
        MyNumber = 7; // 값이 1-10 사이이므로 성공한다
    }
    // --------------------------------------------
    // iMyNumber가 변경될 때 불리는 이벤트
    void NumberChanged()
    {
        Debug.Log("Variable iMyNumber changed to : " + iMyNumber.ToString());
    }
    // --------------------------------------------
}
// --------------------------------------------


