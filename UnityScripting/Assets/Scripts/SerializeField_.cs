using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerializeField_ : MonoBehaviour
{
    // 항상 표시된다
    public int publicVar1;

    // 항상 표시된다
    [SerializeField]
    private int privateVal1;

    // 전역변수를 인스팩터에서 감출 수 있다
    [HideInInspector]
    public int publicVar2;

    // 디버그 모드에서만 표시된다
    private int privateVal2;

    // 디버그 모드에서만 표시된다
    private int privateVar3;
}
