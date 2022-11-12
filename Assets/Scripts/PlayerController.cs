using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 700f;
    public float runSpeed = 2.0f;
    private int jumpCount = 0;
    private bool isGrounded = false;
    private bool isJumping = false;
    private bool isDoubleJump = false;
    private Rigidbody2D playerRigidbody;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        this.playerRigidbody = this.GetComponent<Rigidbody2D>();

    }
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

        // Update is called once per frame
        void Update()
    {
        // 달리기
        transform.Translate(Vector3.right * runSpeed * Time.deltaTime);

        // 점프
        if (Input.GetButtonDown("Jump") && this.jumpCount < 2)
        {
            anim.SetBool("isJumping", true);
            this.jumpCount++;
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            //this.playerRigidbody.AddForce(transform.up * this.jumpForce);
            if (this.jumpCount > 1)
            {
                this.isDoubleJump = true;
            }
        }



    }

    //Update is called once per frame
    void FixedUpdate()
    {

        //Landing Paltform
        Debug.DrawRay(playerRigidbody.position, Vector3.down, new Color(0, 1, 0));

        RaycastHit2D rayHit = Physics2D.Raycast(playerRigidbody.position, Vector3.down, 1, LayerMask.GetMask("Platform"));



        if (playerRigidbody.velocity.y < 0)
        { // 뛰어올랐다가 아래로 떨어질 때만 빔을 쏨 
            if (rayHit.collider != null)
            { //빔을 맞은 오브젝트가 있을때  -> 맞지않으면 collider도 생성되지않음 
                if (rayHit.distance < 2.0f)
                {
                    jumpCount = 0; //거리가 0.5보다 작아지면 jumpCount 초기화
                    isJumping = false;
                    anim.SetBool("isJumping", false);
                    Debug.Log("jumping false");
                }


            }
        }
    }
    //private void FixedUpdate()
    //{
    //    Debug.Log(playerRigidbody.velocity.y);
    //    //Landing Platform

    //    Debug.DrawRay(playerRigidbody.position, Vector3.down, new Color(0, 1, 0));
    //    RaycastHit2D rayHit = Physics2D.Raycast(playerRigidbody.position, Vector3.down, 1, LayerMask.GetMask("Platform"));

    //    if (playerRigidbody.velocity.y < 0)
    //    {
    //        Debug.Log("hitinfo" + rayHit);
    //        if (rayHit.collider != null)
    //        {
    //            Debug.Log("collider name" + rayHit.collider);
    //            if (rayHit.distance < 2.0f)
    //            {
    //                Debug.Log("distance" + rayHit.distance);
    //                //Debug.Log(rayHit.distance);
    //                jumpCount = 0; //거리가 0.5보다 작아지면 jumpCount 초기화
    //                isJumping = false;
    //                anim.SetBool("isJumping", false);
    //            }
    //        }
    //    }
    //}
    //void FixedUpdate() //지속적인 키 입력
    //{
    //    float h = Input.GetAxisRaw("Horizontal");
    //    rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

    //    최대속도
    //    if (rigid.velocity.x > maxSpeed)//오른쪽
    //    {
    //        rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);//y값을 0으로 잡으면 공중에서 멈춰버림
    //    }
    //    else if (rigid.velocity.x < maxSpeed * (-1))//왼쪽
    //    {
    //        rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
    //    }

    //    Landing Platform
    //    if (rigid.velocity.y < 0)
    //    {
    //        Debug.DrawRay(rigid.position, Vector3.down, new Color(0, 1, 0));
    //        시작,방향 색깔

    //        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Platform"));

    //        시작,방향,빔 길이, 레이어
    //        raycasthit 레이어에 해당하는 애만 구별하겠다는거
    //        빔에 맞았는지
    //        if (rayHit.collider != null)
    //        {

    //            if (rayHit.distance < 0.5f)
    //            {

    //                anim.SetBool("isJumping", false);
    //                플레이어의 절반크기만큼이여야 바닥에 닿은거
    //                Debug.Log(rayHit.collider.name);
    //            }

    //        }
    //    }

}
