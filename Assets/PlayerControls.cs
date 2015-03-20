using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	public KeyCode moveUp;
	public KeyCode moveDown;

	public static float speed = 1;

	private static Vector2 forceUp = new Vector2(0, speed);
	private static Vector2 forceDown = new Vector2(0, -speed);
	private int maxSpeedUp = 10;
	private int maxSpeedDown = -10;

	private static Rigidbody2D rb;

	void Start(){


	}

	// Update is called once per frame
	void Update () {

		rb = GetComponent<Rigidbody2D> ();

		rb.drag = 0;
		if (Input.GetKey (moveUp)) {
			if (!(rb.velocity.y > maxSpeedUp)) {
				rb.AddForce (forceUp, ForceMode2D.Impulse);
				rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + speed);
			}


		} else if (Input.GetKey (moveDown)) {
			if (!(rb.velocity.y < maxSpeedDown)) {
				rb.AddForce (forceDown, ForceMode2D.Impulse);
				rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y - speed);

			}

		} else {
			rb.drag = 50;
		}

		rb.velocity = new Vector2 (0f, rb.velocity.y);

	}
}
