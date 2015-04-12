using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary 
{
	public float xMin, xMax, yMin, yMax; // this allows for player position restriction within the specified ranges decided by the user on the x and y axes
}

public class Controller : MonoBehaviour
{
	public float speed; // speed for the camera's motion

	public Boundary boundary;


	void FixedUpdate ()
	{ 
		float moveHorizontal = Input.GetAxis ("Horizontal"); // takes the left and right arrow keys and maps them to the horizontal movement
		float moveVertical = Input.GetAxis ("Vertical"); // takes the up and down arrow keys and maps them to the vertical movement

		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f); // restricts movement to the x and y axes.
		rigidbody.velocity = movement * speed;

		rigidbody.position = new Vector3 
			(
				Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax), // x minimum and maximum positions
				Mathf.Clamp (rigidbody.position.y, boundary.yMin, boundary.yMax), // y minimum and maximum positions
				0.0f // no movement along the z axis. at all. 
		);
	}
}
