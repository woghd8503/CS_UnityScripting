using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyClass : MonoBehaviour
{
    // 항상 표시된다.
    public int PublicVar1;


    // 항상 표시된다.
    [SerializeField]
    private int PrivateVar1;

    // 디버그 모드에서만 표시된다
    private int PrivateVar2;

    // 디버그 모드에서만 표시된다
    private int PrivateVar3;

    // HideInInspector 특성으로 전역변수를 인스텍터에서 감출 수도 있다. 
}
