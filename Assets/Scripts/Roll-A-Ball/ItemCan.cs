using UnityEngine;

/*  
 *  [학습 제목]
 *  기초만 꾹꾹 눌러담은 3D 게임 만들기
 *  
 *  [학습 일자]
 *  파일 생성 일자 : 26.01.06 오후 16:59
 *  마지막 수정 일자 : 26.01.06 오후 18:07
 *  
 *  [학습 내용]
 *  1. 오버로딩
 *    1-1. 필드 직렬화를 사용하는 방법
 *         - 접근자가 public 이거나, SerializeField 속성이 있어야 함.
 *         - static(정적), const(상수), readonly(읽기 전용)가 아니어야 함
 *         - 직렬화 가능한 필드 타입이 있어야 함
 *           - 기본 데이터 형식(int, float, double, bool, string 등)
 *           - 상세 정보 : https://docs.unity3d.com/kr/2023.2/Manual/script-Serialization.html
 *    1-2. 데이터 구조 또는 게임 오브젝트 상태를 Unity가 보관하고 나중에 다시 복구할 수 있는 포맷으로 변환하는 자동 프로세스
 *    1-3. 어떤 데이터를 일고, 쓰고, 고치기 쉽게 파일 형식을 변환한 것
 *    1-4. 인스펙터 창에 직렬화된 필드만 노출됨
 *    
 *  2. 오버라이딩
 *    1-1. CompareTag 사용하기
 *         - Tag는 변수가 아닌 프로퍼티이기에 string을 복사, 생성 후 메모리에 할당됨
 *    
 *  [학습 출처]
 *  1. https://youtu.be/pTc1dakebow?si=YOi0arsM84eivHSL
 *  2. https://yen-world.tistory.com/16
 */

/*  
 *  1. 
 *    - ���� �̸��� �޼��带 ���� �� �����ϴ� ��� (������, �����ڿ��� ���� ����)
 *    - �̸��� ������ �Ű������� �ٸ� �Լ��� ȣ���� �� ����
 *    - ��, �Լ� �̸��� ������ �� �־� �ڵ��� �������� ������������ ������
 *    1-1. ����
 *         - ���� �ٸ� �Ű����� �ñ״�ó(�޼����� �Ű����� Ÿ��, ��, ���� ��)�� ������ ��
 *         - ��ȯ Ÿ�԰��� ������
 *         - ������ Ÿ�� �������� ����
 *         
 *  2. �������̵�
 *     - �θ� Ŭ�������� ���ǵ� �޼��带 �ڽ� Ŭ�������� �������Ͽ� ����ϴ� ���
 *     - ������ ����
 *     - ��� ���迡�� ��� Ȯ��
 *     - �ڵ� ����
 *     1-1. ����
 *          - ������ �ñ״�ó�� ����� ��
 *          - �θ� Ŭ�������� �ش� �޼��尡 virtual�� ���ǵǾ�� ��
 *          - �ڽ� Ŭ������ override Ű���带 ���
 *          - �ڽ� Ŭ�������� �������̵��� �޼��带 �� �̻� �ٸ� Ŭ�������� �������̵� ���ϵ��� �� �� sealed Ű���� ���
 *          - ��Ÿ�� �������� ����
 *          
 *  3. AudioSource
 *     - ���� ��� ������Ʈ
 *     - ��� �� AudioClip �ʿ�
 *  
 *  [�н� ��ó]
 *  1. https://youtu.be/pTc1dakebow?si=YOi0arsM84eivHSL
 *  2. https://unity-programming-study.tistory.com/41
 */

public class ItemCan : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 1f;

    private void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime, Space.World);
    }
}
