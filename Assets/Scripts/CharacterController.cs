using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
	public Vector2 velocity;
	public float speed;
	public float walkAcceleration;
	public float groundDeceleration;
	public float speedMax;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		transform.Translate(velocity * Time.deltaTime);

		float moveInput = Input.GetAxisRaw("Horizontal");
		if (moveInput != 0)
		{
			velocity.x = Mathf.MoveTowards(velocity.x, speed * moveInput, walkAcceleration * Time.deltaTime);
		}
		else
		{
			velocity.x = Mathf.MoveTowards(velocity.x, 0, groundDeceleration * Time.deltaTime);
		}
		if (velocity.x >= speedMax)
		{
			velocity.x = speedMax;
		}
		else { }
	}
}
