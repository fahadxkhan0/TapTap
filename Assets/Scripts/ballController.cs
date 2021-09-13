using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour{

  public float speedUp;
  Rigidbody2D rb;
  bool started;
  bool gameOver;
  public GameObject readyText;
	public float Rotation;
	//public GameObject Ball;
 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        started = false;
		gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!started){
          if (Input.GetMouseButtonDown(0)){
            started = true;
			      readyText.GetComponent<Animator>().Play ("getready");
            rb.isKinematic = false;
			      GameManager.instance.GameStart();
          }
        }
		else if (started && !gameOver)
        {

			  transform.Rotate(0,0,Rotation);

            if(Input.GetMouseButtonDown(0) ){
              rb.velocity = Vector2.zero;
              rb.AddForce(new Vector2(0,speedUp));

            }
        }
    }

	void OnCollisionEnter2D(Collision2D col){
		gameOver = true;
		GetComponent<Animator>().Play ("ball");
		GameManager.instance.GameOver();
	}

	void OnTriggerEnter2D(Collider2D col){

		if(col.gameObject.tag == "scoreChecker" && !gameOver)
    {
			scoreManager.instance.incrementScore();
		}
		
		if(col.gameObject.tag == "Pipe"  && !gameOver){
			gameOver = true;
			GetComponent<Animator>().Play ("ball");
			GameManager.instance.GameOver();
		}

	}
}