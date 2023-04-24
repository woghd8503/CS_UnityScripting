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

    }
}
