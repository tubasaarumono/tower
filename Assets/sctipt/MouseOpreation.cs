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
     //    Vector3 newPos = GetMouseWorldPos() + mOffset;

        // 矢印キーの入力を取得
        // float moveSpeed = 0.1f;
        // if (Input.GetKey(KeyCode.UpArrow))
        // {
        //     newPos.z += moveSpeed;
        // }
        // else if (Input.GetKey(KeyCode.DownArrow))
        // {
        //     newPos.z -= moveSpeed;
        // }
        // else if (Input.GetKey(KeyCode.RightArrow))
        // {
        //     newPos.x += moveSpeed;
        // }
        // else if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     newPos.x -= moveSpeed;
        // }

        // 矢印キーの入力を取得
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

        Vector3 newPos = GetMouseWorldPos() + mOffset + new Vector3(rightArrowCount - leftArrowCount, 0, upArrowCount - downArrowCount) * 0.1f;

        // オブジェクトの位置を更新
        gameObject.transform.position = newPos;
    }
}