using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 몇 개의 메시지가 출력되었느지를 센다
        int NumberOfMessages = 0;
        
        // 다섯 개의 메시지가 콘솔에 출력될 때까지 반복한다
        while(NumberOfMessages < 5)
        {
            // 메시지 출력
            Debug.Log("This is Message: " + NumberOfMessages.ToString());

            // 카운터 증가
            ++NumberOfMessages;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
