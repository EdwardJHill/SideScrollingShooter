using UnityEngine;
using System.Collections;
using UnityEngine.UIElements;

public class ButterflyMover : MonoBehaviour 
{
	public float hSpeed;
	public float maxYOffset;
	protected float origYPos;
	
	void Start()
	{
		origYPos = transform.position.y;
	}
		
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector2(transform.position.x - (hSpeed * Time.deltaTime), origYPos + maxYOffset * Mathf.Sin(Time.time));
		if (transform.position.x < (GameObject.Find("Main Camera").transform.position.x - 20) && transform.position.x >-40)
		{
			Destroy(gameObject);
		}
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<HealthComponent>()!= null)
		{
			other.GetComponent<HealthComponent>().TakeDamage(20);
		}
	}
}
