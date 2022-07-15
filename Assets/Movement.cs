using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Movement : MonoBehaviour
{
    public TMP_Text text;
    public float speed = .01f;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 BottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
        Vector2 BottomRight = Camera.main.ScreenToWorldPoint(new Vector2 (Camera.main.pixelWidth, Camera.main.pixelHeight));
        print(BottomLeft);
        if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.position = new Vector2(transform.position.x-speed*Time.deltaTime, transform.position.y);
            if(BottomLeft.x >= transform.position.x) {
                transform.position = new Vector2(BottomLeft.x+.1f, transform.position.y);
            }
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            transform.position = new Vector2(transform.position.x+speed*Time.deltaTime, transform.position.y);
            if(BottomRight.x <= transform.position.x) {
                transform.position = new Vector2(BottomRight.x-.1f, transform.position.y);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision) {
        Destroy(collision.gameObject);
        score++;
        text.text = "Score: "+score;
    }
}
