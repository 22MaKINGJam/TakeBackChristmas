using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMovement : MonoBehaviour
{
    public float maxSpeed;
    public float jumpPower;
    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        this.rigid = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Platform"));


        //빔에 맞았는지 
        if (rayHit.collider != null)
        {
            Debug.Log("update"+rayHit.collider.name);
        }
    }

    void FixedUpdate() //지속적인 키 입력
    {
        ////float h = Input.GetAxisRaw("Horizontal");
        ////rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        ////최대속도 
        //if (rigid.velocity.x > maxSpeed)//오른쪽
        //{
        //    rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);//y값을 0으로 잡으면 공중에서 멈춰버림
        //}
        //else if (rigid.velocity.x < maxSpeed * (-1))//왼쪽
        //{
        //    rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
        //}

        //// Landing Platform

        //Debug.DrawRay(rigid.position, Vector3.down, new Color(0, 1, 0));
        //// 시작,방향 색깔

        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.up, 1, LayerMask.GetMask("Platform"));


        //빔에 맞았는지 
        if (rayHit.collider != null)
        {
            Debug.Log(rayHit.collider.name);
        }
    }


}

