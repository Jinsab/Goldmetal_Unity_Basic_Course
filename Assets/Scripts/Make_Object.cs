using UnityEngine;

/*  
 *  [학습 제목]
 *  실제와 같은 물체 만들기
 *  
 *  [학습 일자]
 *  파일 생성 일자 : 26.01.05 오후 16:26
 *  마지막 수정 일자 : 26.01.05 오후 17:21
 *  
 *  [학습 내용]
 *  1. RigidBody : 물리효과를 받기 위한 컴포넌트
 *    1-1. Mass : 게임 오브젝트의 질량
 *         - 중력에는 영향을 주지 않음
 *         - 수치가 높을수록 충돌이 무거워짐
 *    1-2. is Kinematic
 *         - 활성화 할 경우, transform을 통해서만 게임 오브젝트를 움직이고 회전할 수 있음
 *         - 움직이는 장애물들을 만들 때 사용 가능
 *         
 *  2. Collider : 물리효과를 받기 위한 컴포넌트
 *     - 충돌 기준은 보이는 것이 아닌 Collider에 따름
 *    
 *  3. Material : 오브젝트의 표면 재질을 결정하는 컴포넌트
 *    1-1. 재질
 *         - Metalic (금속 재질 수치) 
 *         - Smoothness (빛 반사 수치)
 *         - Texture : 재질에 들어가는 이미지
 *    1-2. Tiling : 텍스쳐 반복 타일 개수
 *    1-3. Emission : 텍스쳐 발광(밝기) 조절
 *    
 *  4. Physics Material : 탄성과 마찰을 다루는 물리적인 재질
 *    1-1. Bounciness : 탄성력, 높을수록 많이 튀어오름
 *         - Bounciness Combine : 다음 탄성을 계산하는 방식
 *    1-3. Friction : 마찰력, 낮을수록 많이 미끄러짐
 *         - Dynamic Friction : 움직일 때
 *         - Static Friction : 정지했을 때
 *         - Friction Combine : 다음 마찰력을 계산하는 방식
 *         
 *  5. 물체 필수 요소 : Mesh, Material, Collider, RigidBody
 *  
 *  [학습 출처]
 *  1. https://youtu.be/kYmYCMAiOUk?si=y8mfa2rrRyEr4p3H
 */

public class Make_Object : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
