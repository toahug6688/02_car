using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 使用 UI 物件，必須增加此處理程序
public class GameManager : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<Text>().text = "距離目標還有 " + length.ToString("F2") + "m";
    }
}

