using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 이 오브젝트에 붙어있는 모든 컴포넌트/스크립트에서 MyFunction 함수를 부른다
        SendMessage("MyFunction", SendMessageOptions.DontRequireReceiver);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
