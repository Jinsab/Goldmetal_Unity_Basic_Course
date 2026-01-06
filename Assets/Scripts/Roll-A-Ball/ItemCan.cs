using UnityEngine;

/*  
 *  [학습 제목]
 *  기초만 꾹꾹 눌러담은 3D 게임 만들기
 *  
 *  [학습 일자]
 *  파일 생성 일자 : 26.01.06 오후 16:59
 *  마지막 수정 일자 : 26.01.06 오후 18:16
 *  
 *  [학습 내용]
 *  1. 오버로딩
 *     - 같은 이름의 메서드를 여러 개 정의하는 기법 (생성자, 연산자에도 적용 가능)
 *     - 함수 이름을 재사용 할 수 있으니 코드의 가독성과 유지보수성을 높일 수 있음
 *     - 컴파일 타임 다형성을 제공함 (메서드 호출 시점에 매개변수 타입과 수를 기반으로 선택)
 *     1-1. 조건
 *          - 각자 다른 매개변수 시그니처를 가져야 함(메서드의 매개변수 타입, 수, 순서 등)
 *          - 반환 타입은 오버로딩과 무관함
 *  
 *  2. 오버라이딩
 *     - 부모 클래스에서 정의된 메서드를 자식 클래스에서 재정의하여 사용하는 기법
 *     - 다형성 구현
 *     - 상속 관계에서 기능 확장
 *     - 코드 재사용
 *     - 런타임 다형성을 제공함
 *     1-1. 조건
 *          - 시그니처가 동일해야 함(이름, 매개변수 타입, 수, 순서)
 *          - 부모 클래스에서 해당 메서드가 virtual 키워드로 정의되어 있어야 함
 *          - 자식 클래스에서 override 키워드를 사용해서 재정의 가능
 *          - 자식 클래스에서 오버라이딩된 메서드를 더 이상 다른 클래스에서 오버라이딩하지 못하게 할 땐 sealed 키워드 사용
 *  
 *  3. AudioSource
 *     - 사운드 재생 컴포넌트
 *     - AudioClip
 *  
 *  [학습 출처]
 *  1. https://youtu.be/pTc1dakebow?si=YOi0arsM84eivHSL
 *  2. https://yen-world.tistory.com/16
 */

public class ItemCan : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 1f;

    private void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
    }
}
