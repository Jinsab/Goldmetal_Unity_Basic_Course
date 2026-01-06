using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

/*  
 *  [학습 제목]
 *  유니티 C# 기초 문법
 *  
 *  [학습 일자]
 *  파일 생성 일자 : 26.01.04 오후 13:48
 *  마지막 수정 일자 : 26.01.04 오후 15:42
 *  
 *  [학습 내용]
 *  1. 변수 : 데이터를 메모리에 저장하는 장소
 *    1-1. 정수형 숫자 데이터
 *         - int(Integer) : 가장 일반적으로 사용되는 4바이트 정수 (-2,147,483,648 ~ 2,147,483,647‬)
 *         - uint(unsigned int): 부호 없는 int (0 ~ 4,294,967,295)
 *         - long : int보다 큰 정수를 저장하는 8바이트 정수형 (-9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807)
 *         - ulong : 부호 없는 long
 *         - short : 2바이트 정수형 (-32,768 ~ 32,767)
 *         - ushort : 부호 없는 short (0 ~ 65,535)
 *         - byte : 1바이트 정수형 (0 ~ 255)
 *         - sbyte : 1바이트 정수 (-128 ~ 127)
 *    1-2. 정수 리터럴 (소스코드에 고정된 값을 말하는 대표적인 용어)
 *         - decimal : 접두사 없이
 *         - 16진수 : 0x, 0X 접두사
 *         - 이진 : 0b 또는 0B 접두사
 *    2-1. 부동 소수점 숫자 데이터
 *         - float : 4바이트 (6-9자리 숫자), 사용할 때 뒤에 f를 붙여야 함
 *         - double : 8바이트 (15-17자리 숫자), 사용할 때 뒤에 d를 붙일 수 있음
 *         - decimal : 16바이트 (28-29자리 숫자), 사용할 때 뒤에 m을 붙일 수 있음
 *    3-1. 문자형 데이터
 *         - char : 문자 (예시로 char : "A")
 *         - string : 문자열 (예시로 string : "내용")
 *    3-2. 문자 리터럴
 *         - \u : 유니코드
 *         - \x : 이스케이프
 *    4-1. 논리형 데이터
 *         - bool : true, false (기본 값 false)
 *    5-1. 열거형 방식
 *         - enum
 *    6-1. 구조체 형식
 *         - struct
 *    7-1. 튜플 형식
 *         - t : 예시로 (double, int) t1 = (4.5, 3) 같이 가능
 *    8-1. 지역 변수(함수 안에서 선언된 변수), 전역 변수(함수 바깥에 선언된 변수)
 *         - 선언 위치에 따라 달라짐
 *  
 *  2. 그룹형 변수 : 데이터를 묶어 사용할 수 있음
 *    1-1. 배열 : 가장 기본적인 고정형 그룹형 변수
 *         - string[] monsters = { "내용 1", "내용 2", "내용 3" };
 *         - int[] monsterLevel = new int[3] { 1, 6, 20 };
 *    2-1. 리스트 : 기능이 추가된 가변형 그룹형 변수
 *         - List<T> items = new List<T>(); → 제네릭 형식
 *    
 *  3. 프로그래밍의 흐름은 선언 > 초기화 > 호출(사용) 순서로 흘러간다.
 *  
 *  4. 주석
 *    1-1. // : 내용 1줄만
 *    
 *  5. 제네릭 : 코드의 재사용성과 유연성을 향상 해주는 도구
 *    1-1. 여러 데이터 형식에 대해 동일한 로직을 적용해야 할 때
 *    1-2. 컬렉션 타입에서 다양한 데이터 형식을 저장하고 관리해야 할 때
 *    1-3. 데이터 형식에 따라 다른 연산을 수행해야 할 때
 *    2-1. 상당히 많은 제네릭 클래스 들이 있음 (리스트, 딕셔너리, 링크드리스트 등)
 *    상세 내용 : https://learning-e.tistory.com/42
 *    
 *  6. 연산자
 *    1-1. 산술 연산자 : +, -, *, /, % 등
 *    1-2. 비교 연산자 : >, >=, <=, < 등
 *    1-3. 논리형 비교 연산자 : ==, !=, &&(AND), ||(OR) 등
 *      2-1. 삼항 연산자 : 조건 ? True : False 
 *    1-4. 비트 및 시프트 연산자 : <<, >> 등
 *    
 *  7. 조건문
 *    1-1. if문
 *         - if : 조건을 만족할 시 이후 내용을 실행
 *         - else : 조건을 만족하지 않을 시 이후 내용 실행
 *         - else if : 이후 추가로 조건을 주는 것
 *    2-1. switch case문
 *         - case 이후에는 break로 끊어주어야 함
 *         - default : 모든 case를 거친 이후에 실행
 *         
 *   8. 반복문
 *     1-1. while
 *          - 조건을 만족하는 동안 무한정 반복 하기 때문에 잘 사용하거나 break 시점을 정해야 함
 *     2-1. for
 *          - for (연산 될 변수; 조건; 연산) 
 *     3-1. foreach
 *          - for의 그룹형변수 탐색에 특화
 *          
 *   9. 함수
 *     1-1. 기능을 편리하게 사용하기 위해 구성된 영역
 *     1-2. 반환값(자료형) 이름 (매개변수) { return 자료타입 }
 *     
 *   10. 접근자
 *     1-1. public : 외부 클래스에 공개로 설정하는 접근자
 *          - 외부에서 읽을 수 있되 설정은 내부에서만 가능하도록 제어가 가능함
 *          - public int Health { get; private set; }
 *     2-1. protected : 자식 클래스에서 접근이 가능
 *     3-1. private : 외부 클래스에 비공개로 설정하는 접근자
 *          - get, set 키워드를 활용해서 접근할 수 있도록 하기도 함 (Property)
 *     4-1. internal : 같은 어셈블리(프로젝트)에서만 public으로 접근이 가능
 */

public class Unity_Basic_Grammer : MonoBehaviour
{
    int level = 5;
    //float strength = 15.5f;
    //string playerName = "나검사";
    //bool inFullLevel = false;
    int health = 30;

    //string[] monsters = { "슬라임", "사막뱀", "악마" };
    //int[] monsterLevel;
    //List<string> items;

    void Start()
    {
        //Debug.Log("용사의 이름은? " + playerName);
        //Debug.Log("용사의 레벨은? " + level);
        //Debug.Log("용사의 힘은? " + strength);
        //Debug.Log("용사는 만렙인가? " + inFullLevel);

        //Debug.Log("맵에 존재하는 몬스터");
        //Debug.Log(monsters[0]);
        //Debug.Log(monsters[1]);
        //Debug.Log(monsters[2]);

        //monsterLevel = new int[3] { 1, 6, 20 };

        //Debug.Log("맵에 존재하는 몬스터 레벨");
        //Debug.Log(monsterLevel[0]);
        //Debug.Log(monsterLevel[1]);
        //Debug.Log(monsterLevel[2]);

        //items = new List<string>();
        //items.Add("생명물약30");
        //items.Add("마나물약30");
        //items.RemoveAt(0);

        bool isEndTutorial = level < 10;
        Debug.Log(isEndTutorial);

        health = Heal(health);
        Healing();

        // 인스턴스화 : 정의된 클래스를 변수 초기화로 실체화
        Actor player = new Actor();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무지팡이";

        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + " 입니다.");
    }

    int Heal(int health)
    {
        health += 10;
        Debug.Log("힐을 받았습니다. " + health);

        return health;
    }

    void Healing()
    {
        health += 20;
        Debug.Log("힐을 받았습니다. " + health);
    }
}
