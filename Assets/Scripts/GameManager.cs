using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;



	void Awake(){
		DontDestroyOnLoad(this.gameObject);
		if(instance == null){
			instance = this;
		}
		else{
			Destroy(this.gameObject);
		}
	}
    // Start is called before the first frame update
    void Start()
    {
		;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void GameStart(){
		GameObject.Find ("pipeSpawner").GetComponent<pipeSpawner> ().startSpawning();

	}
	public void GameOver(){
		
		GameObject.Find ("pipeSpawner").GetComponent<pipeSpawner> ().stopSpawning();
		scoreManager.instance.StopScore();
		UiManager.instance.GameOverPanel();
	


	}
}
