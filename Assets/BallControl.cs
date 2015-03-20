using UnityEngine;
using System.Collections;


public class BallControl : MonoBehaviour {

	public AudioSource audioClick;
	public AudioSource ballSpawn;
	// Use this for initialization
	public void Start () {

		this.body = GetComponent<Rigidbody2D>();
		//transform = GetComponent<Transform> (); //transform seems to be a Component property of the current Transform.
												  //No need to get it, it's already available. 
												  //Wonder if there's a simillar thing for the RigidBody?
		resetBall ();
	}
	
	// Update is called once per frame
	public void Update () {
		
	}

	public void OnCollisionEnter2D(Collision2D info){
		if (info.collider.tag == "Player") {

			float velY = info.collider.attachedRigidbody.velocity.y/65 + Random.Range (0,50)/20;
			this.body.AddForce(new Vector2(0,velY), ForceMode2D.Impulse );
			this.audioClick.pitch = Random.Range(0.8f, 1.2f);
			this.audioClick.Play();


		}
	}

	public void resetBall(){
		this.body.velocity = new Vector2 (0, 0);
		transform.position = new Vector3 (0,0,0);
		this.ballSpawn.Play ();
		StartCoroutine (waitAndBeginBallMoving(1));
	}

	//Private
	private static bool lastFiredSwitch = true;
	private Rigidbody2D body;

	private IEnumerator waitAndBeginBallMoving(float waitTime){
		yield return new WaitForSeconds (waitTime);

		float randomNumber = Random.Range (30,70);
		Debug.Log (lastFiredSwitch);
		if (lastFiredSwitch) {
			randomNumber = -randomNumber;
		}
		lastFiredSwitch = !lastFiredSwitch;//Fires the ball in the oppisite direction to the last time
		
		this.body.AddForce (new Vector2(randomNumber, 10));
	}
	
}
