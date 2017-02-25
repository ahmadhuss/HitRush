using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

 
	public bool gamestaretedFromMainMenu;




    void Awake()
    {
        MakeSingleton();
       


    }

   

	 void OnLevelWasLoaded(){

		if (SceneManager.GetActiveScene().name == "_Level") {


			if (gamestaretedFromMainMenu) {

				Paddle.Score = 0;
				LifeCount.LifeM = 1;

				GameplayController.variable.SetScore (0);
				GameplayController.variable.SetLifeScore (1);
			}

		}

	}


	public void MakeSingleton(){

		if(instance!=null){
			Destroy(gameObject);

		}
		else{

			instance = this;
			DontDestroyOnLoad(gameObject);

		}


	}





    public void checkGameStatus(int scoreMeter,int life,string comment){

    
     
            if (life < 0)
            {



                int highScore = GamePrefrences.GetHighScore();


                if (highScore < scoreMeter)
                {
                    GamePrefrences.SetHighScore(scoreMeter);
                    GamePrefrences.SetComment(comment);
                }


                gamestaretedFromMainMenu = false;
 


                GameplayController.variable.GameOverShowPanel(scoreMeter);


            
        }
		

	}


}