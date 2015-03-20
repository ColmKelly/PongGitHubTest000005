using UnityEngine;
using System.Collections;

public class PlayerScore : MonoBehaviour {

	public int scoringPlayerNo;
	public BallControl scoringBall;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D hitInfo){
		if (hitInfo.name == "Ball") {
			GameManager.Score(scoringPlayerNo);
			//scoringBall.resetBall();
			hitInfo.gameObject.SendMessage("resetBall");

		}
	}
}
