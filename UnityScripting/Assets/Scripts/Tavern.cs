using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tavern : MonoBehaviour
{
    // 술집에 있는 NPC들의 배열
    public MyCharacter[] Characters = null;
    // ------------------------------------
    // 여기에서 초기화한다

    private void Start()
    {

        // 새로운 배열 - 술집에 다섯 NPC가 있다
        Characters = new MyCharacter[5];

        // MyCharacter 형식의 배열에 다른 형식을 가진 캐릭터를 추가한다.
        Characters[0] = new ManCharacter();
        Characters[1] = new WomanCharacter();
        Characters[2] = new OrcCharacter();
        Characters[3] = new ManCharacter();
        Characters[4] = new WomanCharacter();

        // 술집에 들어가는 기능을 실행한다
        EnterTavern();
    }

    //-------------------------------------
    // 플레이어가 술집에 들어갔을 때 불리는 함수
    public void EnterTavern()
    {
        // 모두가 인사를 건넨다
        foreach(MyCharacter C in Characters)
        {
            // 파생 클래스의 SayGreeting 함수를 호출한다.
            // 다형성을 이용하면 기본 클래스의 함수 호출로 파생 클래스의 함수 접근이 가능해진다
            C.SayGreeting();
        }
    }

    //---------------------------------


}
