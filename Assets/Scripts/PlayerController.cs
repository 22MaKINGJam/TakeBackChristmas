using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 700f;
    public float runSpeed = 2.0f;
    private int jumpCount = 0;
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

        // y축 속도가 0이면 바닥인 것으로 판단
        if(playerRigidbody.velocity.y == 0.0)
        {
            this.isJumping = false;
            this.jumpCount = 0;
        }



    }



}
