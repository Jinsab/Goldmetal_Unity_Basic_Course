using UnityEngine;

/*  
 *  [학습 제목]
 *  물리 충돌 이벤트
 *  
 *  [학습 일자]
 *  파일 생성 일자 : 26.01.06 오전 11:40
 *  마지막 수정 일자 : 26.01.06 오후 12:07
 *  
 *  [학습 내용]
 *  1. 오브젝트의 재질 접근은 MeshRenderer를 통해서 가능함
 *  
 *  2. Collision : 충돌 정보 클래스
 *    1-1. OnCollisionEnter : 물리적 충돌이 시작할 때 호출되는 함수
 *    1-2. OnCollisionStay : 물리적 충돌이 유지될 때 호출되는 함수
 *    1-3. OnCollisionExit : 물리적 충돌이 끝났을 때 호출되는 함수
 *    
 *  3. Material : 오브젝트의 표면 재질을 결정하는 컴포넌트
 *    1-1. Color : 기본 색상 클래스
 *    1-2. Color32 : 255 색상 클래스
 *    
 *  [학습 출처]
 *  1. https://youtu.be/salZ7t98xi8?si=6asvx1FZOq4aTDFG
 */

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "DoroBall")
        {
            mat.color = new Color(0, 0, 0);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "DoroBall")
        {
            mat.color = new Color(1, 1, 1);
        }
    }
}
