using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOpreation : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    private int upArrowCount = 0;
    private int downArrowCount = 0;
    private int rightArrowCount = 0;
    private int leftArrowCount = 0;

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
             if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            upArrowCount++;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            downArrowCount++;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightArrowCount++;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftArrowCount++;
        }

        // スペースキーで上下回転
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(Vector3.right, 1f);
        }

        // シフトキーで左右回転
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            transform.Rotate(Vector3.up, 1f);
        }

        Vector3 newPos = GetMouseWorldPos() + mOffset + new Vector3(rightArrowCount - leftArrowCount, 0, upArrowCount - downArrowCount) * 0.1f;

        // オブジェクトの位置を更新
        gameObject.transform.position = newPos;
    }

    void Update()
    {
        // Y座標が-5以下になった場合、オブジェクトを削除する
        if (gameObject.transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
}