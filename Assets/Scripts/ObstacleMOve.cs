using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMOve : MonoBehaviour
{
    public float leftBound = -12; 
    public  float speed = 8;
    private PlayerControl playerControlScript;
  
    void Start()
    {
        playerControlScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {

        if (playerControlScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
