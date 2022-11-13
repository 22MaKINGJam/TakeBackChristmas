using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 7f;
    public float jumpForce2 = 7f;
    public float runSpeed = 2.0f;
    public float runSpeedWhileJump = 2.0f;
    private int jumpCount = 0;
    private bool isJumping = false;
    private bool isDoubleJump = false;
    private Rigidbody2D playerRigidbody;
    Animator anim;

    public int life;
    public GameObject[] heart;

    void Start()
    {
        anim = GetComponent<Animator>();
        this.playerRigidbody = this.GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        // 달리기
        transform.Translate(Vector3.right * runSpeed * Time.deltaTime);

        // 점프
        if (Input.GetButtonDown("Jump") && this.jumpCount < 1)
        {
            transform.Translate(Vector3.right * runSpeedWhileJump * Time.deltaTime);
            transform.GetComponent<PlayerSound>().PlaySound("jump");
            this.jumpCount++;
            playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            //this.playerRigidbody.AddForce(transform.up * this.jumpForce);
            //if (this.jumpCount > 1)
            //{
            //    this.isDoubleJump = true;
            //    transform.GetComponent<PlayerSound>().PlaySound("jumpTwice");
            //}
            anim.SetBool("isJumping", true);
        }
        else if (Input.GetButtonDown("Jump") && this.jumpCount < 2)
        {
            transform.Translate(Vector3.right * runSpeedWhileJump * Time.deltaTime);
            transform.GetComponent<PlayerSound>().PlaySound("jumpTwice");
            this.isDoubleJump = true;
            this.jumpCount++;
            playerRigidbody.AddForce(Vector3.up * jumpForce2, ForceMode2D.Impulse);
            //this.playerRigidbody.AddForce(transform.up * this.jumpForce);
            //if (this.jumpCount > 1)
            //{
            //    this.isDoubleJump = true;
            //    transform.GetComponent<PlayerSound>().PlaySound("jumpTwice");
            //}
            anim.SetBool("isJumping", true);
        }
        else
            transform.Translate(Vector3.right * runSpeed * Time.deltaTime);

        // y축 속도가 0이면 바닥인 것으로 판단
        if (playerRigidbody.velocity.y == 0.0)
        {
            this.isJumping = false;
            this.jumpCount = 0;
            anim.SetBool("isJumping", false);

        }



    }

    void OnTriggerEnter2D(Collider2D o)
    {
        if (o.gameObject.CompareTag("Monster"))
        {
            life--;
            Debug.Log("충돌");
            for (int index = 0; index < 3; index++)
            {
                heart[index].gameObject.SetActive(false);
            }
            for (int index = 0; index < life; index++){
                heart[index].gameObject.SetActive(true);
            }
        }
    }

}