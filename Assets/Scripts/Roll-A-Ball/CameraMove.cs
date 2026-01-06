using System;
using UnityEngine;

/*  
 *  [학습 제목]
 *  기초만 꾹꾹 눌러담은 3D 게임 만들기
 *  
 *  [학습 일자]
 *  파일 생성 일자 : 26.01.06 오후 18:49
 *  마지막 수정 일자 : 26.01.06 오후 18:49
 *  
 *  [학습 내용]
 *  1. 
 *    
 *  [학습 출처]
 *  1. https://youtu.be/pTc1dakebow?si=YOi0arsM84eivHSL
 */

public class CameraMove : MonoBehaviour
{
    Transform playerTransform;
    Vector3 offSet;

    private void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        offSet = transform.position - playerTransform.position;
    }

    private void LateUpdate()
    {
        transform.position = playerTransform.position + offSet;
    }
}
