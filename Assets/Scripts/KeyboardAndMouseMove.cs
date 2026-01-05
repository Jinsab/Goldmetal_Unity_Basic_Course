using UnityEngine;
using UnityEngine.InputSystem;

/*  
 *  [학습 제목]
 *  키보드 마우스로 이동시켜보자!
 *  
 *  [학습 일자]
 *  파일 생성 일자 : 26.01.04 오후 16:34
 *  마지막 수정 일자 : 26.01.05 오후 14:40
 *  
 *  [학습 내용]
 *  1. Input : 게임 내 입력을 관리하는 클래스
 *    1-1. Input.anyKey : Return은 Bool 값으로 반환
 *         아무 입력을 받으면 반응
 *         - anyKeyDown - 아무 입력을 최초로 받을 때 반응
 *    2-1. GetKey : 키보드 버튼 입력을 받는 것
 *         - KeyDown - 누를 때
 *         - Key [Stay] - 누르고 있을 때
 *         - KeyUp - 누르고 있다 땔 때
 *    3-1. GetMouse : 마우스 버튼 입력을 받는 것
 *         - GetMouseDown
 *         - GetMouse
 *         - GetMouseUp
 *         - 왼쪽 버튼 0, 오른쪽 버튼 1, 가운데 버튼 2
 *    4-1. Input Manager에서 Button 설정 가능
 *    
 *  2. Input System : Input Manager의 최신 시스템
 *    1-1. Action을 커스텀하여 원하는 기능으로 사용 가능
 *  
 *  3. 오브젝트는 변수 transform을 항상 가지고 있음
 *    1-1. transform : 오브젝트 형태에 대한 기본 컴포넌트
 *  
 *  4. 오브젝트를 움직이는 방법
 *    1-1. Translate
 *         - transform.Translate(Vector3)
 *         - 매개 변수로 주어진 x, y, z 값 만큼 x, y, z 축을 따라 이동함
 *         * 벡터 : 방향과 그에 대한 크기 값
 *    2-1. trasnform.position
 *  
 *  [학습 출처]
 *  1. https://youtu.be/wqRwsW03JR4?si=N6mp6ylNHvt_s6ti
 *  2. https://docs.unity3d.com/Packages/com.unity.inputsystem@1.17/manual/Workflow-Actions.html
 */

public class KeyboardAndMouseMove : MonoBehaviour
{
    InputAction moveAction;
    InputAction jumpAction;
    Vector2 moveValue;

    private void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    private void Update()
    {
        /*
        // Input Manager(구)를 사용한 방법
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다");

        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하셨습니다.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");

        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");
        
        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");
        */

        // Input system package를 사용한 방법

    }

    private void FixedUpdate()
    {
        // Move action은 2D vector로 읽히고
        // Jump action은 boolean value로 읽힘.
        moveValue = moveAction.ReadValue<Vector2>();
        Debug.Log("x의 값: " + moveValue.x + "z의 값: " + moveValue.y);
        transform.position += new Vector3(moveValue.x * 0.01f, 0, moveValue.y * 0.01f);

        if (jumpAction.IsPressed())
        {
            Debug.Log("내용");
            transform.position += new Vector3(0, 1f, 0);
        }
    }
}
