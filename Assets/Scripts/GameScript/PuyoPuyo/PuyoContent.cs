using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuyoContent : MonoBehaviour
{
    
    public void Init(int type)
    {

    }

    // �~�̔��a��ݒ肵�܂��B
    public float radius = 10f;

    // �����ʒu���擾���A������ێ����܂��B
    Vector3 initPos;

    void Start()
    {
        // �����ʒu��ێ����܂��B
        initPos = gameObject.transform.localPosition;
    }

    void Update()
    {
        CalcPosition();
    }

    /// <Summary>
    /// �I�u�W�F�N�g�̈ʒu���v�Z���郁�\�b�h�ł��B
    /// </Summary>
    void CalcPosition()
    {
        // �ʑ����v�Z���܂��B
        float phaseX = Time.time * 1 * Mathf.PI;
        float phaseY = Time.time * 2 * Mathf.PI;

        // ���݂̈ʒu���v�Z���܂��B
        float xPos = radius * Mathf.Cos(phaseX);
        float yPos = radius * Mathf.Sin(phaseY);


        // �Q�[���I�u�W�F�N�g�̈ʒu��ݒ肵�܂��B
        Vector3 pos = new Vector3(xPos, -yPos, 0);
        gameObject.transform.localPosition = pos;
    }
}
