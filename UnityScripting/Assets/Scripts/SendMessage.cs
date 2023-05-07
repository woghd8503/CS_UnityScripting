using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMessage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 이 오브젝트에 붙어있는 모든 컴포넌트/스크립트에서 MyFunction 함수를 부른다
        SendMessage("MyFunction", SendMessageOptions.DontRequireReceiver);
    }

    // SendMessage가 호출될 때 실행된다.
    void MyFunction()
    {
        Debug.Log("hello");
    }
}
