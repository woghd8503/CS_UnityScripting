using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tavern : MonoBehaviour
{
    // ������ �ִ� NPC���� �迭
    public MyCharacter[] Characters = null;
    // ------------------------------------
    // ���⿡�� �ʱ�ȭ�Ѵ�

    private void Start()
    {

        // ���ο� �迭 - ������ �ټ� NPC�� �ִ�
        Characters = new MyCharacter[5];

        // MyCharacter ������ �迭�� �ٸ� ������ ���� ĳ���͸� �߰��Ѵ�.

    }
}
