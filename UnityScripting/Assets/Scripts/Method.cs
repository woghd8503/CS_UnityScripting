using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Method : MonoBehaviour
{
    // ���� ������ ���Ǵ� private ����
    // �� Ŭ���� �ȿ����� ������ �����ϴ�
    private int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        // ���� ������Ʈ�� ȣ���Ѵ�
        UpdateScore(5, false); // 5���� �߰��Ѵ�
        UpdateScore(10, false); // 10���� �߰��Ѵ�
        int CurrentScore = UpdateScore(15, false); // 15���� �߰��ϰ� ����� �����Ѵ�

        // ������ �� ��� �����
        UpdateScore(CurrentScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int UpdateScore(int AmountToAdd, bool PrintToConsole = true)
    {
        // ������ ����Ʈ�� �߰��Ѵ�
        Score += AmountToAdd;

        // �ݼֿ� ����� �ʿ��Ѱ�
        if(PrintToConsole) { Debug.Log("Score is: " + Score.ToString()); }

        // ���� ������ ����ϰ� �Լ��� �����Ѵ�
        return Score;
    }
}
