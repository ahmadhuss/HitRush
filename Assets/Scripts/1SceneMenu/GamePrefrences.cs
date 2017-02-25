using UnityEngine;
using System.Collections;

public static class GamePrefrences  {


	public static string Score = "Score";

    public static string Comment = "Comment";



	public static void SetHighScore(int state){
		//                     key               value parameter
		PlayerPrefs.SetInt (GamePrefrences.Score,state);


	}

    public static void SetComment(string state)
    {

        PlayerPrefs.SetString(GamePrefrences.Comment, state);


    }
    public static int GetHighScore(){
		  //                          key
		return PlayerPrefs.GetInt (GamePrefrences.Score);

	}

    public static string GetComment()
    {
        //                          key
        return PlayerPrefs.GetString(GamePrefrences.Comment);

    }

}