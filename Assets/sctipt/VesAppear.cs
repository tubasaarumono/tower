using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;


public class VesAppear : MonoBehaviour
{
    public GameObject acorn;
    public GameObject apple;
    public GameObject banana;
    public GameObject carrot;
    public GameObject cherry;
    public GameObject egg;
    public GameObject garlic;
    public GameObject kiwi;
    public GameObject lemon;
    public GameObject mushroom;
    public GameObject onion;
    public GameObject pumpkin;
    public Vector3 Pos01;
    public Vector3 Pos02;
    public Vector3 Pos03;
    public Vector3 Pos04;
    public Vector3 Pos05;
    public Vector3 Pos06;
    public Vector3 Pos07;
    public Vector3 Pos08;
    public Vector3 Pos09;
    public Vector3 Pos10;
    public Vector3 Pos11;
    public Vector3 Pos12;

    void Start()
    {
        // Prefabの元の位置を取得する
        Vector3 Pos01 = transform.GetComponent<Transform>().Find("acorn").position;
        Vector3 Pos02 = transform.GetComponent<Transform>().Find("apple").position;
        Vector3 Pos03 = transform.GetComponent<Transform>().Find("banana").position;
        Vector3 Pos04 = transform.GetComponent<Transform>().Find("carrot").position;
        Vector3 Pos05 = transform.GetComponent<Transform>().Find("cherry").position;
        Vector3 Pos06 = transform.GetComponent<Transform>().Find("egg").position;
        Vector3 Pos07 = transform.GetComponent<Transform>().Find("garlic").position;
        Vector3 Pos08 = transform.GetComponent<Transform>().Find("kiwi").position;
        Vector3 Pos09 = transform.GetComponent<Transform>().Find("lemon").position;
        Vector3 Pos10 = transform.GetComponent<Transform>().Find("mushroom").position;
        Vector3 Pos11 = transform.GetComponent<Transform>().Find("onion").position;
        Vector3 Pos12 = transform.GetComponent<Transform>().Find("pumpkin").position;
    }

    void OnMouseUp()
    {
        // クリックされたGameObjectを取得する
        GameObject clickedObject = GameObject.FindWithTag("Ves01");

        // クリックされたGameObjectのタグが「Ves01」かつ座標が「Pos01」と等しくない場合
        if (clickedObject != null && clickedObject.tag == "Ves01" && clickedObject.transform.position != Pos01)
        {
            // Prefab「acorn」を座標「Pos01」に生成する
            GameObject newAcorn = Instantiate(acorn, Pos01, Quaternion.identity);
        }
        
        // クリックされたGameObjectのタグが「Ves02」かつ座標が「Pos02」と等しくない場合
        if (clickedObject != null && clickedObject.tag == "Ves02" && clickedObject.transform.position != Pos02)
        {
            // Prefab「apple」を座標「Pos02」に生成する
            GameObject newApple = Instantiate(apple, Pos02, Quaternion.identity);
        }

        // クリックされたGameObjectのタグが「Ves03」かつ座標が「Pos03」と等しくない場合
        if (clickedObject != null && clickedObject.tag == "Ves03" && clickedObject.transform.position != Pos03)
        {
            // Prefab「banana」を座標「Pos03」に生成する
            GameObject newBanana = Instantiate(banana, Pos03, Quaternion.identity);
        }

        // クリックされたGameObjectのタグが「Ves04」かつ座標が「Pos04」と等しくない場合
        if (clickedObject != null && clickedObject.tag == "Ves04" && clickedObject.transform.position != Pos04)
        {
            // Prefab「carrot」を座標「Pos04」に生成する
            GameObject newCarrot = Instantiate(carrot, Pos04, Quaternion.identity);
        }

        // クリックされたGameObjectのタグが「Ves05」かつ座標が「Pos05」と等しくない場合
        if (clickedObject != null && clickedObject.tag == "Ves05" && clickedObject.transform.position != Pos05)
        {
            // Prefab「cherry」を座標「Pos05」に生成する
            GameObject newCherry = Instantiate(cherry, Pos05, Quaternion.identity);
        }

        // クリックされたGameObjectのタグが「Ves06」かつ座標が「Pos06」と等しくない場合
        if (clickedObject != null && clickedObject.tag == "Ves06" && clickedObject.transform.position != Pos06)
        {
            // Prefab「egg」を座標「Pos06」に生成する
            GameObject newEgg = Instantiate(egg, Pos06, Quaternion.identity);
        }

        // クリックされたGameObjectのタグが「Ves07」かつ座標が「Pos07」と等しくない場合
        if (clickedObject != null && clickedObject.tag == "Ves07" && clickedObject.transform.position != Pos07)
        {
            // Prefab「garlic」を座標「Pos07」に生成する
            GameObject newGarlic = Instantiate(garlic, Pos07, Quaternion.identity);
        }

        // クリックされたGameObjectのタグが「Ves08」かつ座標が「Pos08」と等しくない場合
        if (clickedObject != null && clickedObject.tag == "Ves08" && clickedObject.transform.position != Pos08)
        {
            // Prefab「kiwi」を座標「Pos08」に生成する
            GameObject newKiwi = Instantiate(kiwi, Pos08, Quaternion.identity);
        }

        // クリックされたGameObjectのタグが「Ves09」かつ座標が「Pos09」と等しくない場合
        if (clickedObject != null && clickedObject.tag == "Ves09" && clickedObject.transform.position != Pos09)
        {
            // Prefab「lemon」を座標「Pos09」に生成する
            GameObject newLemon = Instantiate(lemon, Pos09, Quaternion.identity);
        }

        // クリックされたGameObjectのタグが「Ves10」かつ座標が「Pos10」と等しくない場合
        if (clickedObject != null && clickedObject.tag == "Ves10" && clickedObject.transform.position != Pos10)
        {
            // Prefab「mushroom」を座標「Pos10」に生成する
            GameObject newMushroom = Instantiate(mushroom, Pos10, Quaternion.identity);
        }

        // クリックされたGameObjectのタグが「Ves11」かつ座標が「Pos11」と等しくない場合
        if (clickedObject != null && clickedObject.tag == "Ves11" && clickedObject.transform.position != Pos11)
        {
            // Prefab「onion」を座標「Pos11」に生成する
            GameObject newOnion = Instantiate(onion, Pos11, Quaternion.identity);
        }

        // クリックされたGameObjectのタグが「Ves12」かつ座標が「Pos12」と等しくない場合
        if (clickedObject != null && clickedObject.tag == "Ves12" && clickedObject.transform.position != Pos12)
        {
            // Prefab「pumpkin」を座標「Pos10」に生成する
            GameObject newPumpkin = Instantiate(pumpkin, Pos12, Quaternion.identity);
        }
    }
}