using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleLoop : MonoBehaviour
{
    float speed = 10f;
    private float width; // 배경의 가로 길이

    private void Awake()
    {
        // 가로 길이를 측정하는 처리
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width = backgroundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (transform.position.x <= -width)
        {
            Reposition();
        }
    }
    private void Reposition()
    {
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position + offset;
    }

}
