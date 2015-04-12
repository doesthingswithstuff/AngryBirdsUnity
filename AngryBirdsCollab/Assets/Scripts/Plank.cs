using UnityEngine;
using System.Collections;

public class Plank : MonoBehaviour 
{
	public float health;
	public int plankCount = 0;

	void OnCollisionEnter2D(Collision2D collision) 
	{
		// apply collision damage
		if (collision.relativeVelocity.magnitude > 0.5) 
		{
			health -= collision.relativeVelocity.magnitude;
		}
		
		// destroy if health is too low
		if (health <= 0) 
		{
			Destroy(gameObject);
			plankCount = plankCount+1;
			Debug.Log (plankCount);
		}
	}
}