using UnityEngine;

/*  
 *  [학습 제목]
 *  키보드 마우스로 이동시켜보자!
 *  
 *  [학습 일자]
 *  파일 생성 일자 : 26.01.04 오후 16:34
 *  마지막 수정 일자 : 26.01.04 오후 16:34
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
 *  2.
 *  3.
 *  4.
 *  5.
 *  6.
 *  7.
 *  8.
 *  
 *  
 *  [학습 출처]
 *  1. https://youtu.be/wqRwsW03JR4?si=N6mp6ylNHvt_s6ti
 */

public class KeyboardAndMouseMove : MonoBehaviour
{
    void Update()
    {
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

        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 모으는 중...");
        
        if (Input.GetMouseButtonDown(0))
            Debug.Log("슈퍼 미사일 발사!!");
    }
}
