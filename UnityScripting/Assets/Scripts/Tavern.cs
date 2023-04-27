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
        Characters[0] = new ManCharacter();
        Characters[1] = new WomanCharacter();
        Characters[2] = new OrcCharacter();
        Characters[3] = new ManCharacter();
        Characters[4] = new WomanCharacter();

        // ������ ���� ����� �����Ѵ�
        EnterTavern();
    }

    //-------------------------------------
    // �÷��̾ ������ ���� �� �Ҹ��� �Լ�
    public void EnterTavern()
    {
        // ��ΰ� �λ縦 �ǳٴ�
        foreach(MyCharacter C in Characters)
        {
            // �Ļ� Ŭ������ SayGreeting �Լ��� ȣ���Ѵ�.
            // �������� �̿��ϸ� �⺻ Ŭ������ �Լ� ȣ��� �Ļ� Ŭ������ �Լ� ������ ����������
            C.SayGreeting();
        }
    }

    //---------------------------------


}
