using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameplayController : MonoBehaviour {
	
	public static GameplayController variable;


	public Text scoreText,gameoverText,beatitScore;


	public Text LifeText;

	[SerializeField]
	private GameObject pausePanel;


	[SerializeField]
	private GameObject gameOverPanel;

	public bool pushButton;


	void Awake () {

		MakeVariable ();
		LifeText.text = ""+1;

		scoreText.text =""+0;

        beatitScore.text = GamePrefrences.GetHighScore().ToString();

	}



	void MakeVariable(){
		if (variable == null) {

			variable = this;
		}

	}

    //basically yeh method gameover score text display karey ga
	public void GameOverShowPanel(int finalScore){

		gameOverPanel.SetActive (true);
		gameoverText.text = finalScore.ToString();
	}


public void StoptheGame(){
		Time.timeScale = 0f;
		pushButton = true;
		pausePanel.SetActive (true);

	}

	public void ResumeGame(){
		Time.timeScale = 1f;
		pushButton = false;
		pausePanel.SetActive (false);


	}

	public void MenuAgain(){
		Time.timeScale = 1f;
		GameManager.instance.gamestaretedFromMainMenu = false;
		SceneFader.instance.FadeIn("MainMenu");

	}

	public void SetScore(int score){
		scoreText.text =""+score;

	}

	public void SetLifeScore(int lifescore){
		if (lifescore == 0) {
			LifeText.color = Color.red;
			LifeText.text = "" + lifescore;
		} 

		else if (lifescore==1){
			LifeText.text = "" + lifescore;

		}

	}



}