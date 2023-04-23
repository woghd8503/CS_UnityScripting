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

    // 플레이어가 대화에 진입할 때 인사말을 출력하는 함수
    public virtual void SayGreeting()
    {
        Debug.Log("Hello, my friend");
    }

    // ----------------------------------------------
    public class ManCharacter : MyCharacter
    {
        public override void SayGreeting()
        {
            Debug.Log("Hello, I'm a man");
        }
    }

    // ----------------------------------------------
    public class WomanCharacter : MyCharacter
    {
        public override void SayGreeting()
        {
            Debug.Log("Hello, I'm a woman");
        }
    }

    // ----------------------------------------------
    public class OrCharacter : MyCharacter
    {
        public override void SayGreeting()
        {
            Debug.Log("Hello, I'm an Orc");
        }
    }
}
