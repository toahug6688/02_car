using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Car : MonoBehaviour
{
    float speed = 0;
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { //�I���ƹ���
            speed = 0.2f; //�]�w��l�t��
        }
        transform.Translate(speed, 0, 0); //����
        speed *= 0.98f; //��t
    }
}
