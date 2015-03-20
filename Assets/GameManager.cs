using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int player1Score = 0;
	public static int player2Score = 0;

	public GUISkin scoreSkin;

	const int PLAYER_1 = 1;
	const int PLAYER_2 = 2;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void Score(int scoringPlayer){
		if (scoringPlayer == PLAYER_1) {
			player1Score++;
		} else if (scoringPlayer == PLAYER_2) {
			player2Score++;
		}
		Debug.Log ("SCORE");
	}

	public void OnGUI (){
		GUI.skin = scoreSkin;
		GUI.Label (new Rect (Screen.width/2-150 -12,20,100,100),"" + player1Score);
		GUI.Label (new Rect (Screen.width/2+150 -12,20,100,100),"" + player2Score);
	}
}
