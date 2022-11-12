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

    // Start is called before the first frame update
    void Start()
    {
        this.playerRigidbody = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // 달리기
        transform.Translate(Vector3.right * runSpeed * Time.deltaTime);

        // 점프
        if (Input.GetButtonDown("Jump") && this.jumpCount < 2)
        {
            this.jumpCount++;
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            //this.playerRigidbody.AddForce(transform.up * this.jumpForce);
            if (this.jumpCount > 1)
            {
                this.isDoubleJump = true;
            }
        }



    }

    // Update is called once per frame
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
                }


            }
        }
    }

}
