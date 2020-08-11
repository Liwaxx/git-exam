using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	//Rigibody 2D Bola
	private Rigidbody2D rigidbody2D;

	//Besarnya gaya awal yang diberikan untuk mendorong bola
	public float xInitialForce;
	public float yInitialForse;

	void ResetBall()
	{
		//reset posisi menjadi (0,0)
		transform.position = Vector2.zero;


	}

	// Use this for initialization
	void Start () {
	
	}
}
