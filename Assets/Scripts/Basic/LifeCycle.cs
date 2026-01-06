using UnityEngine;

/*  
 *  [학습 제목]
 *  유니티 생명주기
 *  
 *  [학습 일자]
 *  파일 생성 일자 : 26.01.04 오후 15:48
 *  마지막 수정 일자 : 26.01.04 오후 16:27
 *  
 *  [학습 내용]
 *  1. 유니티의 흐름
 *    1-1. 초기화
 *         - Awake : 게임 오브젝트 생성할 때, 최초 실행
 *         - Start : 업데이트 시작 직전에 최초 실행
 *    2-1. 물리 연산 [프레임]
 *         - FixedUpdate : 물리 연산 하기 전 업데이트
 *           프레임 속도와 관계없이 고정적된 주기로 호출되기 때문에 타이머로 신뢰할 수 있음
 *           CPU를 많이 사용함
 *    3-1. 게임 로직 [프레임]
 *         - Update : 프레임 당 1회 호출 됨 (게임 로직 업데이트)
 *           환경에 따라 실행 주기가 차이날 수 있음
 *         - LateUpdate : 모든 업데이트가 끝난 후 호출
 *    4-1. 해체
 *         - OnDestroy : 게임 오브젝트가 삭제될 때
 *    5-1. 활성화
 *         - OnEnable : Awake 이후에 호출
 *    6-1. 비활성화
 *         - OnDisable : OnDestory 직전에 호출
 *         
 *  2. 가비지 컬렉터 (GC)
 *    1-1. 가비지 컬렉터의 기능
 *         - 애플리케이션과 Unity에서 더 이상 사용하지 않는 오브젝트로부터 메모리를 회수하는 기능
 *         - 자동으로 작동하지만, 호출 될 때 CPU 시간이 상당히 많이 소요됨.
 *         - 즉, 최적화를 위해선 카비지 컬렉터를 많이 부르지 않도록 하는 것이 좋음.
 *         - 너무 빠르다면 성능에 악 영향을, 너무 늦다면 수천 개를 처리해야 하므로 시간이 많이 소모 될 것
 *    2-1. 최적화 기술
 *         - 오브젝트 풀링 : 발사체를 비활성화하여 필요할 때 활성화하고 소모(파괴) 이후엔 비활성화 하는 기술
 *         - string 연결
 *           - ABCDE를 연결할 때 ABCDE를 한 번에 A, AB, ... ABCDE는 5번의 결과
 *           - 또한 점수 등을 표시 할 땐, 변경될 때만 텍스트가 업데이트 되도록 하면 됨
 *         - 박싱 (boxing)
 *           - 값 타입의 변수가 자동으로 레퍼런스 타입으로 전환될 때 발생
 *         
 *  [학습 출처]
 *  생명 주기
 *  1. 유니티 메뉴얼 : https://docs.unity3d.com/kr/2023.2/Manual/ExecutionOrder.html
 *  2. 골드메탈님 영상 : https://youtu.be/PyN3JkPTpAI?si=pHBYXB1Q0M4fyprz
 *  가비지 컬렉터
 *  1. https://docs.unity3d.com/kr/2023.2/Manual/performance-garbage-collector.html
 *  2. https://docs.unity3d.com/kr/2023.2/Manual/performance-garbage-collection-best-practices.html
 */

public class LifeCycle : MonoBehaviour
{
    // 게임 오브젝트 생성할 때, 최초 실행
    // 인스턴스화 : 정의된 클래스를 변수 초기화로 실체화
    private void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    // 오브젝트가 활성화 될 때
    private void OnEnable()
    {
        
    }

    // 업데이트 시작 직전에 최초로 실행
    // 즉, 첫 번째 프레임 업데이트 전에 호출
    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    // 물리 연산 이전에 주기적으로 호출됨
    // 프레임과 관계없이 고정적이기 때문에 움직임 계산 등에서 사용이 가능
    void FixedUpdate()
    {
        
    }

    // 프레임마다 호출 됨
    void Update()
    {
        
    }

    // 모든 업데이트가 끝난 후 호출 됨
    void LateUpdate()
    {
               
    }

    // 오브젝트가 비활성화 될 때
    private void OnDisable()
    {
        
    }

    // 오브젝트가 삭제 될 때
    void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해체하였습니다.");
    }
}
