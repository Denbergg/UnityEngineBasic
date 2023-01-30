using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 전투기 이동 제어
/// todo -> 상하좌우 키를 통해 전투기를 상하좌우로 이동시킬 수 있는 스크립트 작성
/// </summary>
public class FighterMove : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    private float _h;
    private float _v;

    void Update()
    {
        _h = Input.GetAxisRaw("Horizontal");
        _v = Input.GetAxisRaw("Vertical");
        Debug.Log($"(DeltaMove : {_h}, {0}, {_v})");
    }


    //==================================================================
    //                        priavte Methods
    //==================================================================

    private void FixedUpdate()
    {
        transform.Translate(new Vector3(_h, 0.0f, _v).normalized * _speed * Time.fixedDeltaTime);
    }  

}
