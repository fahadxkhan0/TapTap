using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{ 
	public static UiManager instance; 
	public Text scoreText;
	public GameObject gameOverPanel;
	public Text HighScoreText;

	void Awake(){
		if(instance == null){
		instance = this;
		}
	}
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		scoreText.text = scoreManager.instance.Score.ToString();
    }

	public void GameOverPanel(){
		//HighScoreText.text = scoreManager.instance.HighScore.ToString();
		HighScoreText.text = "HIGH SCORE : " + PlayerPrefs.GetInt("HighScore");
		gameOverPanel.SetActive (true);
	}
	public void Again(){
		SceneManager.LoadScene("Level1");
	}

	public void Menu(){
		SceneManager.LoadScene("Menu");
	}
}
