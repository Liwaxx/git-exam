using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	//Tombol untuk menggerakkan ke atas
	public KeyCode upButton = KeyCode.W;

	//Tombol untuk menggerakkan ke bawah
	public KeyCode downButton = KeyCode.S;

	// KEcepatan gerak
	public float speed = 5.0f;

	//Batas atas dan bawah scene (Batas bawah menggunakan minus (-))
	public float yBoundary = 9.0f;

	//Rigibody 2D raket ini
	private Rigidbody2D rigidbody2D;

	//SCore pemain
	private int score;

	// Use this for initialization
	void Start () {
		rigidbody2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		//Dapatakan kecepatan raket sekarang.
		Vector2 velocity = rigidbody2D.velocity;

		//menekan tombol ke atas
		if(Input.GetKey(upButton))
		{
			velocity.y = speed;
		}

		//menekan tombol ke bawah
		else if (Input.GetKey(downButton))
		{
			velocity.y = -speed;
		}
		//tidak menekan apa"
		else
		{
			velocity.y = 0.0f;
		}

		//masukkan kembali kecepatannya ke rigiBody2D
		rigidbody2D.velocity = velocity;

		//mendapatkan posisi raket sekarang
		Vector3 position = transform.position;
		//jika raket melebihi batas atas (yBoundary)
		if(position.y > yBoundary)
		{
			position.y = yBoundary;
		}
		//jika raket melebihi batas bawah (-yBoundary)
		else if (position.y < yBoundary)
		{
			position.y = -yBoundary;
		}

		//masukkan kembali posisinya ke transform
		transform.position = position;

	}

	//menaikkan score sebanyak 1 poin
	public void IncrementScore()
	{
		score++;
	}

	//mengembalikan score menjadi 0
	public void ResetScore()
	{
		score = 0;
	}
	//mendapatkan nilai score
	public int Score
	{
		get { return score; }
	}

}
