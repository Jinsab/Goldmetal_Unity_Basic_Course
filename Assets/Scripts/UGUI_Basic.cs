using UnityEngine;

/*  
 *  [학습 제목]
 *  UGUI 기초
 *  
 *  [학습 일자]
 *  파일 생성 일자 : 26.01.06 오후 12:28
 *  마지막 수정 일자 : 26.01.06 오후 12:28
 *  
 *  [학습 내용]
 *  1. 캔버스
 *    1-1. UI가 그려지는 도화지 역할인 컴포넌트
 *    1-2. 텍스트 UI 
 *      1-1. TextMeshPro
 *           - Window > TextMeshPro > Font Asset Cretaor
 *           - Font 설정해주고, Generate 해주기.
 *           - https://java-coding.tistory.com/100
 *    1-3. 이미지 UI
 *      1-1. 원본 이미지의 비율과, 사용할 이미지 UI의 비율을 맞춰야 깨져보이지 않음
 *      1-2. 이미지 타입을 변경하여 추가로 설정 가능 (Simple, Sliced, Tiled, Filed)
 *    1-4. Hierarchy 상 하위에 있을수록 위에(나중에) 그려지게 되기에 순서 고려가 필요함
 *    1-5. 버튼 UI
 *      1-1. On Click()에 스크립트를 연결하여 기능 구현이 가능하다.
 *    1-6. 앵커
 *         - 앵커-빨간점 : 캔버스에서의 기준점.
 *         - 앵커-파란점 : 컴포넌트에서의 기준점. [Shift]
 *         - 앵커-중앙네모 : 컴포넌트의 위치. [Alt]
 *    
 *  2. 좌표계
 *    1-1. 월드 좌표
 *         - 좌표로 표현할 수 있는 월드에서 어느 한 점을 원점(0, 0, 0)으로 보고 그 원점을 기준으로 x, y, z로 표현할 수 있는 좌표(위치)
 *         - 월드 내에 모든 객체는 월드 좌표를 가지고 있음
 *         - 세계에 Cube 객체를 생성하고 Position을 변경하면 해당 위치로 이동됨
 *         - Cube 또한 월드의 자식이기 때문에, 월드의 로컬 좌표계에 따라 움직인 것
 *    1-2. 로컬 좌표
 *         - 특정 개체를 기준으로 보는 좌표계
 *         - 예시로 큐브 밑에 자식으로 구슬을 생성하고 Position을 원점(0, 0, 0)으로 두면 큐브와 동일한 위치에 존재하게 됨
 *    1-3. 스크린
 *      1-1. 게임이 표시되는 화면, 해상도로 크기 결정
 *      1-2. 스크린 좌표계
 *           - 왼쪽 하단을 원점으로 하고, 화면 해상도에 따른 픽셀 위치를 단위로 하는 2D 직교 좌표계
 *    1-4. 뷰포트 좌표
 *         - 스크린 좌표를 정규화한 좌표계
 *         - 왼쪽 하단은 (0, 0), 오른쪽 상단은 (1, 1)로 되어있음
 *         - 정규화되어 있기에 화면 해상도에 상관없이 동일한 좌표를 얻을 수 있음
 *         - 화면 안에 특정 객체가 있는지 없는지를 구분할 때 사용하면 좋음
 *  
 *    
 *  [학습 출처]
 *  1. https://youtu.be/k4YUJy-otDs?si=m6oiQYLykaYsepwl
 *  2. https://leekangw.github.io/posts/45/
 */

public class UGUI_Basic : MonoBehaviour
{
    public GameObject GameObject;
    private Rigidbody rigid;

    private void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
        Debug.Log("점프!");
    }
}
