using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
using UnityEditor.ShaderGraph.Internal;

/*  
 *  [학습 제목]
 *  힘을 이용하여 물체 움직여보기
 *  
 *  [학습 일자]
 *  파일 생성 일자 : 26.01.05 오후 17:34
 *  마지막 수정 일자 : 26.01.05 오후 18:14
 *  
 *  [학습 내용]
 *  1. GetComponent<T> : 자신의 T타입 컴포넌트를 가져옴.
 *  
 *  2. RigidBody
 *    1-1. velocity : 현재 이동속도
 *         - Unity 6 이후에는 linearVelocity(선형 속도)라는 명칭으로 대체
 *           → 역할은 동일하다
 *           https://www.reddit.com/r/Unity3D/comments/1fk45kg/rigidbodyvelocity_is_obsolete_for_unity_6_preview/
 *         - angularVelocity(각 속도)
 *    1-2. RigidBody 관련 코드는 FixedUpdate에 작성하는 것이 권장 사항
 *    1-3. AddForce : Vector3의 방향과 크기로 힘을 줌
 *         - AddForce(Vector3 force)
 *         - AddForce(Vector3 force, ForceMode.Force)
 *    1-4. AddTorque : 회전력
 *         - AddTorque(Vector3)
 *         - 물체가 축(Vector3)을 중심으로 회전하게 만드는 것
 *  
 *  [학습 출처]
 *  1. https://youtu.be/h_MA36TGFsc?si=GN5ivJHgcjQJxGtN
 *  2. https://docs.unity3d.com/6000.3/Documentation/ScriptReference/Rigidbody.AddForce.html
 *  3. https://docs.unity3d.com/6000.3/Documentation/ScriptReference/Rigidbody-linearVelocity.html
 */

public class MyBall : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    Rigidbody rigid;
    Vector2 moveValue;
    InputAction moveAction;
    InputAction jumpAction;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");

        //rigid.linearVelocity = Vector3.left;
        
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        moveValue = moveAction.ReadValue<Vector2>();
        rigid.AddForce(new Vector3(moveValue.x * speed, 0, moveValue.y * speed), ForceMode.Impulse);

        if (jumpAction.IsPressed())
        {
            rigid.AddForce(Vector3.up * 30, ForceMode.Impulse);
        }
    }
}
