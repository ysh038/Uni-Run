using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAct : MonoBehaviour
{
    private Rigidbody2D monsterRigidbody; // 사용할 리지드바디 컴포넌트

    private int JumpCount = 0;
    private float jumpForce = 500f;
    private bool isGrounded = false;
    private void Awake()
    {
        monsterRigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && JumpCount < 1 && isGrounded == true)
        {
            monsterRigidbody.velocity = Vector2.zero;
            monsterRigidbody.AddForce(new Vector2(0, jumpForce));
            JumpCount++;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 바닥에 닿았음을 감지하는 처리
        if (collision.contacts[0].normal.y > 0.7f)
        {
            isGrounded = true;
            JumpCount = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        // 바닥에서 벗어났음을 감지하는 처리
        isGrounded = false;
    }
}
