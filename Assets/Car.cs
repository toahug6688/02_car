using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Car : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    void Start()
    {
    }
    void Update()
    {
        //(�s�W)���o�ưʪ���
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition; //�N�I���ƹ��ɪ��y�аO���_��
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition; //�N��}�ƹ��ɪ��y�аO���_��
            float swipeLength = endPos.x - startPos.x;
            speed = swipeLength / 500.0f; //��ưʪ����ഫ����l���ʳt��
        }
        transform.Translate(speed, 0, 0);
        speed *= 0.98f;
    }
}
