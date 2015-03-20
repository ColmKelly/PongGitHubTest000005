using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {

	public Camera mainCam;
	public BoxCollider2D topWall;
	public BoxCollider2D bottomWall;
	public BoxCollider2D leftWall;
	public BoxCollider2D rightWall;

	public Transform player1;
	public Transform player2;

	public float playerPos;

	// Use this for initialization
	void Start () {
		//Move each wall to its edge location
		Vector3 screenDimensions = new Vector3 (Screen.width, Screen.height, 0f);
		Vector3 wordDimensions = mainCam.ScreenToWorldPoint (screenDimensions);

		Vector2 screenWidthSize = new Vector2 (wordDimensions.x * 2, 1f);
		Vector2 screenHeightSize = new Vector2 (1f, wordDimensions.y * 2);

		float screenHalfWay = Screen.height/2;

		topWall.size = screenWidthSize;
		topWall.offset = new Vector2 (0f, wordDimensions.y + 0.5f);

		bottomWall.size = screenWidthSize;
		bottomWall.offset = new Vector2 (0f, -wordDimensions.y - 0.5f);
	
		leftWall.size = screenHeightSize;
		leftWall.offset = new Vector2 (-wordDimensions.x -1f, 0f );

		rightWall.size = screenHeightSize;
		rightWall.offset = new Vector2 (wordDimensions.x + 1f, 0);

		//Set player positions
		Vector3 player1ScreenPosition = new Vector3 (playerPos, screenHalfWay, 1f);
		Vector3 player1WorldPositon = mainCam.ScreenToWorldPoint (player1ScreenPosition);

		Vector3 player2ScreenPosition = new Vector3 (Screen.width - playerPos, screenHalfWay, 1f);
		Vector3 player2WorldPositon = mainCam.ScreenToWorldPoint (player2ScreenPosition);

		player1.position = player1WorldPositon;
		player2.position = player2WorldPositon;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
