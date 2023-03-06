using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuyoContent : MonoBehaviour
{
    
    public void Init(int type)
    {

    }

    // 円の半径を設定します。
    public float radius = 10f;

    // 初期位置を取得し、高さを保持します。
    Vector3 initPos;

    void Start()
    {
        // 初期位置を保持します。
        initPos = gameObject.transform.localPosition;
    }

    void Update()
    {
        CalcPosition();
    }

    /// <Summary>
    /// オブジェクトの位置を計算するメソッドです。
    /// </Summary>
    void CalcPosition()
    {
        // 位相を計算します。
        float phaseX = Time.time * 1 * Mathf.PI;
        float phaseY = Time.time * 2 * Mathf.PI;

        // 現在の位置を計算します。
        float xPos = radius * Mathf.Cos(phaseX);
        float yPos = radius * Mathf.Sin(phaseY);


        // ゲームオブジェクトの位置を設定します。
        Vector3 pos = new Vector3(xPos, -yPos, 0);
        gameObject.transform.localPosition = pos;
    }
}
