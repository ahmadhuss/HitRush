using UnityEngine;
using System.Collections;

public class InstructionBack : MonoBehaviour
{

	public void GoNormal ()
	{
		if (GameManager.instance != null) {

			SceneFader.instance.FadeIn ("MainMenu");
		}

	}

}