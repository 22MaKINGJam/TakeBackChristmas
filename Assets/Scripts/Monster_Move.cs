using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Move : MonoBehaviour
{
    Vector2 pos;

    public float Max; //좌우 이동 가능한 범위

    public float speed; // 이동 속도

    void Start()
    {
        pos = transform.position;
    }


    void Update()
    {

        Vector3 v = pos;

        v.x += Max * Mathf.Sin(Time.time * speed);

        transform.position = v;

    }
}
