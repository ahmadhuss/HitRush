using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenuController : MonoBehaviour
{





	public void StartGame ()
	{
        
		GameManager.instance.gamestaretedFromMainMenu = true;
		SceneFader.instance.FadeIn ("_Level");
       

	}


	public void HighScorMenu ()
	{
 

		SceneFader.instance.FadeIn ("Score");

	}

	public void Instrction ()
	{
		SceneFader.instance.FadeIn ("instru");


	}

	public void QuitGame ()
	{

		Application.Quit ();
	}



}