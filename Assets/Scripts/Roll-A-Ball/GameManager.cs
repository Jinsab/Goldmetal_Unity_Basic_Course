using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

/*  
 *  [학습 제목]
 *  기초만 꾹꾹 눌러담은 3D 게임 만들기
 *  
 *  [학습 일자]
 *  파일 생성 일자 : 26.01.06 오후 19:12
 *  마지막 수정 일자 : 26.01.06 오후 19:12
 *  
 *  [학습 내용]
 *  1. Canvas > TextMeshPro(TMP)를 인스펙터에 할당하는 방법
      - TextMeshPro는 UI용과 3D용 컴포넌트 타입이 다르기 때문에, 타입이 맞지 않으면 할당할 수 없음
      - TMP_Text를 사용하면 두 경우를 모두 대응할 수 있음
 *    
 *  [학습 출처]
 *  1. https://youtu.be/pTc1dakebow?si=YOi0arsM84eivHSL
 */

public class GameManager : MonoBehaviour
{
    public int totalItemCount;
    public int stage;
    public TextMeshProUGUI stageCountText;
    public TextMeshProUGUI playerCountText;

    private void Awake()
    {
        stageCountText.text = $"/ {totalItemCount}";    
    }

    public void GetItem(int count)
    {
        playerCountText.text = count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene($"03_DoroBall_{stage}");
        }
    }
}
