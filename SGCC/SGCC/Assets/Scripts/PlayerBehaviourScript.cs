using UnityEngine;
using System.Collections;

// This will add a Rigidbody2D to your object if this is attached 
// to it and it doesn't exist
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerBehaviourScript : MonoBehaviour 
{
	private Rigidbody2D rigidBody2D;

	public bool canWalk = true;

	[Tooltip("A modifier on how fast the player will be")]
	public float playerSpeed = 2.5f;

	private Animator animator;

	// Use this for initialization
	void Start() 
	{
		rigidBody2D = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update()
	{
		Vector2 currentMovement = new Vector2 (Input.GetAxis ("Horizontal"), 
			Input.GetAxis ("Vertical"));

		if (currentMovement.magnitude != 0 && canWalk) 
		{
			animator.SetFloat ("xMove", currentMovement.x);
			animator.SetFloat ("yMove", currentMovement.y);
			animator.SetBool("isMoving", true);
		}
		else
		{
			animator.SetBool("isMoving", false);
		}

		Vector2 desiredPosition = rigidBody2D.position + 
			(currentMovement * playerSpeed * Time.deltaTime);

		rigidBody2D.MovePosition(desiredPosition);
	}
}
