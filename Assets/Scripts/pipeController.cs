using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeController : MonoBehaviour
{

    public float upDownSpeed;
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        MovePipe();
        InvokeRepeating("SwithchUpDown",0.1f,1f);
    }
    void MovePipe(){
        rb.velocity=new Vector2(-speed,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void SwithchUpDown(){
          upDownSpeed = -upDownSpeed;
          rb.velocity = new Vector2(-speed,upDownSpeed);
    }

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "pipeRemover"){
			Destroy(gameObject);
		}
	}


}
