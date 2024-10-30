using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // �ϥ� UI ����A�����W�[���B�z�{��
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
        this.distance.GetComponent<Text>().text = "�Z���ؼ��٦� " + length.ToString("F2") + "m";
    }
}

