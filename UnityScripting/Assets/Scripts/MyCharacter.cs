using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacter : MonoBehaviour
{
    public string CharName = "";
    public int Health = 100;
    public int Strength = 100;
    public float Speed = 10.0f;
    public bool isAwake = true;

    // �÷��̾ ��ȭ�� ������ �� �λ縻�� ����ϴ� �Լ�
    public virtual void SayGreeting()
    {
        Debug.Log("Hello, my friend");
    }
}
