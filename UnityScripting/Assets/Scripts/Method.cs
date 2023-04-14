using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method : MonoBehaviour
{
    // 범위 내에서 사용되는 private 변수
    // 이 클래스 안에서만 접근이 가능하다
    private int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        // 점수 업데이트를 호출한다
        UpdateScore(5, false); // 5점을 추가한다
        UpdateScore(10, false); // 10점을 추가한다
        int CurrentScore = UpdateScore(15, false); // 15점을 추가하고 결과를 저장한다

        // 점수를 두 배로 만든다
        UpdateScore(CurrentScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int UpdateScore(int AmountToAdd, bool PrintToConsole = true)
    {
        // 점수에 포인트를 추가한다
        Score += AmountToAdd;

        // 콜솔에 출력이 필요한가
        if(PrintToConsole) { Debug.Log("Score is: " + Score.ToString()); }

        // 현재 점수를 출력하고 함수를 종료한다
        return Score;
    }
}
