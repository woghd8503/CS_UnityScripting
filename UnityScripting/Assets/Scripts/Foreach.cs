using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour
{
    // 씬의 게임오브젝트를 담는 배열이다
    public GameObject[] MyObjects;

    // Start is called before the first frame update
    void Start()
    {
        // 하나씩 배열의 모든 오브젝트에 코드를 반복시킨다
        foreach(GameObject obj in MyObjects)
        {
            // 오브젝트를 파괴한다
            DestroyImmediate(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
