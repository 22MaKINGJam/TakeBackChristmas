using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Move : MonoBehaviour
{
    Vector2 pos;

    public float Max; //좌우 이동 가능한 범위

    public float speed; // 이동 속도
    private SpriteRenderer spriteR;
    public Sprite[] sprites;

    void Start()
    {
        pos = transform.position;
        spriteR = gameObject.GetComponent<SpriteRenderer>();

    }


    void Update()
    {

        Vector3 v = pos;
        var a = Mathf.Sin(Time.time * speed);
        if (gameObject.name == "쿠키")
        {
            if (a < 0)
                spriteR.sprite = sprites[1];
            else
                spriteR.sprite = sprites[0];

        }

        v.x += Max * a;

        transform.position = v;

    }
}
