using UnityEngine;

/*  
 *  [학습 제목]
 *  목표 지점으로 이동시키기
 *  
 *  [학습 일자]
 *  파일 생성 일자 : 26.01.05 오후 15:01
 *  마지막 수정 일자 : 26.01.05 오후 16:15
 *  
 *  [학습 내용]
 *  1. MoveTowards
 *    1-1. 동일한 속도로 이동함
 *    1-2. 매개변수 MoveTowards(현재위치, 목표위치, 속도)
 *    
 *  2. SmoothDamp
 *    1-1. 점차 감속하여 이동
 *    1-2. 매개변수 SmoothDamp(현재위치, 목표위치, 참조 속도, 속도)
 *    
 *  3. Lerp
 *    1-1. 선형 보간, SmoothDamp보다 감속시간이 김
 *    1.2 매개변수 Lerp(현재위치, 목표위치, 속도)
 *    
 *  4. SLerp
 *    1-1. 구면 선형 보간, 호를 그리며 이동
 *    1-2. 매개변수 SLerp(현재위치, 목표위치, 속도)
 *    
 *  5. 시간 및 프레임 속도 관리
 *    1-1. Time.DeltaTime
 *         - 이전 프레임의 완료까지 걸린 시간 :: 마지막 프레임부터 현재 프레임까지의 간격(초)
 *         - 프레임이 적으면 커지고, 프레임이 많으면 작아짐
 *         - Translate의 경우 벡터에 곱하기, Vector 함수는 시간 매개변수에 곱하기하여 사용
 *         - transform.Translate(Vec * Time.deltaTime);
 *         - Vector3.Lerp(Vec1, Vec2, T * Time.deltaTime);
 *    
 *  [학습 출처]
 *  1. https://youtu.be/gnO1GVRuKxk?si=dxLqjIn1MMkalOyK
 *  2. https://docs.unity3d.com/6000.3/Documentation/ScriptReference/Vector3.html
 *  3. https://docs.unity3d.com/6000.3/Documentation/Manual/managing-time-and-frame-rate.html
 */

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    Vector3 velo = Vector3.zero;

    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, target, 1f);
        //transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);
        //transform.position = Vector3.Lerp(transform.position, target, 1f);
        transform.position = Vector3.Slerp(transform.position, target, 0.05f);
    }
}
