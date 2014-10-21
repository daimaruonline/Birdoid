using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour
{

		public GameObject birdoid;

		// Use this for initialization
		void Start ()
		{

				Birdoid _bird = (Birdoid)Instantiate (birdoid, birdoid.transform.position, birdoid.transform.rotation);
				_bird.direction = new Vector2 (-0.1f, 0.1f);
				_bird.speed = 0.05f;
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
