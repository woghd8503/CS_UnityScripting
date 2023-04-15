using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 프레임마다 오브젝트를 Y축 중심으로 2도씩 회전시킨다
        transform.Rotate(new Vector3(0.0f, 2.0f, 0.0f));
    }
}
