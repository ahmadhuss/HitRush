using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BackButtonHighScoreController : MonoBehaviour {

   

    [SerializeField]
	private Text scoreText;

    [SerializeField]
    private Text CommentText;

  
  
    void Start(){
        SetBasedScore ();
	}



void SetScore(int score,string texer){

		scoreText.text = score.ToString();//setted our text
        if (score==0) {
            CommentText.text = "None";
        }
        else
        {
            CommentText.text = texer;
        }
    }

    //basiclly yeh method nested hai aur yeh KEYS ley ga HighScore , Comment ki
	void SetBasedScore(){
		SetScore (GamePrefrences.GetHighScore(),GamePrefrences.GetComment());
	}

  
   public void GoBack(){
        
		if (GameManager.instance != null) {
			SceneFader.instance.FadeIn ("MainMenu");
		}

	}


	public void Reset(){
		
		if (GameManager.instance != null) {
			PlayerPrefs.DeleteAll();
			SceneFader.instance.FadeIn ("MainMenu");
		}


		
	}



}