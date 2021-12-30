using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

	public float movementSpeed = 10f;

	Rigidbody2D rb;
	public Renderer playerRenderer;
	public bool playerCanLose = false;
	float movement = 0f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		StartCoroutine(StartGame());
	}
	
	// Update is called once per frame
	void Update () {
		movement = Input.GetAxis("Horizontal") * movementSpeed;
		if(playerCanLose) {
			if(!playerRenderer.isVisible) 
			{
				Debug.Log("GAME OVER ");
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			}
		}
	}
	IEnumerator StartGame() {
		yield return new WaitForSeconds(1f);
		playerCanLose = true;
	}

	void FixedUpdate()
	{
		Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;
	}
}
