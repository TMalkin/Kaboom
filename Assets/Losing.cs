using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Losing : MonoBehaviour
{
    private int loss = 0;
    private BombManager bm;
    // Start is called before the first frame update
    void Start()
    {
        bm = GameObject.FindWithTag("Manager of Bombs").GetComponent<BombManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 BottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
        if(transform.position.y <= BottomLeft.y) {
            bm.loss++;
            Destroy(gameObject);
        }
        if(bm.loss == 3) {
            SceneManager.LoadScene("LosingScreen");
        }
    }
}
