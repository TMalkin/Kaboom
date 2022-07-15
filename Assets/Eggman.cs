using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggman : MonoBehaviour
{
    public GameObject bomb;
    private float clock = 0f;
    public float speed = .01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clock = clock + Time.deltaTime;
         if(clock > 2) {
             GameObject newbomb = Instantiate(bomb, transform.position, bomb.transform.rotation);
             Rigidbody2D rb = newbomb.GetComponent<Rigidbody2D>();
             rb.AddForce(new Vector2(0, 1)*500);
             clock = 0f;
         }
        Vector2 BottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
        Vector2 BottomRight = Camera.main.ScreenToWorldPoint(new Vector2 (Camera.main.pixelWidth, Camera.main.pixelHeight));
        if(transform.position.x >= BottomRight.x) {
            speed = -speed;
        }
        if(transform.position.x <= BottomLeft.x) {
            speed = -speed;
        }
        if(Random.Range(1,1000) <= 1) {
            speed = -speed;
        }
        transform.position = new Vector2(transform.position.x+speed*Time.deltaTime, transform.position.y);
        }
        
    }
