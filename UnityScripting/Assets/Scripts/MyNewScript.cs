using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNewScript : MonoBehaviour
{
    public string PlayerName = "";
    public int PlayerHealth = 100;
    public Vector3 Position = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // PlayerHealth를 검사한다. 한 줄짜리 내용의 if문에서 중괄호는 옵션이다.
        if(PlayerHealth == 100)
        {
            Debug.Log("Player has full health");
        }
    }
}
