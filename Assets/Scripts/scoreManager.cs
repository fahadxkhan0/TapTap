using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreManager : MonoBehaviour
{
	public static scoreManager instance;
	public int Score;
	public int HighScore;
	//public int HighScore;

	void Awake(){
		if(instance == null){
			instance = this;
		}}

		// Start is called before the first frame update
		void Start()
		{
			Score = 0;
			PlayerPrefs.SetInt("Score",0);
		}

		// Update is called once per frame
		public void Update()
		{
        	
    	}

		public void incrementScore(){
			Score++;
		}

		 public void StopScore(){
			PlayerPrefs.SetInt("Score",Score);
			if(PlayerPrefs.HasKey("HighScore")){
				if(Score>PlayerPrefs.GetInt("HighScore")){
					PlayerPrefs.SetInt("HighScore",Score);
				}
			}
		else{
				PlayerPrefs.SetInt("HighScore",Score);
			}
		}
	}

