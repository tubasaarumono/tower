using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateVes01 : MonoBehaviour
{
    public GameObject prefab01;
    public Vector3 Pos01;
    public Vector3 Rot01;

    void Start()
    {
        // Prefabの元の位置を取得する
        // Pos01 = transform.GetComponent<Transform>().Find("prefab01").position;

        // Prefabの元の回転を取得する
        // Rot01 = prefab01.transform.rotation.eulerAngles;
    }

    void OnMouseUp()
    {
        // クリックされたGameObjectを取得する
        GameObject clickedObject = GameObject.FindWithTag("Ves01");

        // クリックされたGameObjectのタグが「Ves01」かつ座標が「Pos01」と等しくない場合
        if (clickedObject != null && clickedObject.tag == "Ves01" && clickedObject.transform.position != Pos01)
        {
            // Prefab「prehab01」を座標「Pos01」に生成する
            GameObject newPrefab01 = Instantiate(prefab01, Pos01, Quaternion.Euler(Rot01));
        }
    }
}