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
        // PlayerHealth�� �˻��Ѵ�. �� ��¥�� ������ if������ �߰�ȣ�� �ɼ��̴�.
        if(PlayerHealth == 100)
        {
            Debug.Log("Player has full health");
        }
    }
}
