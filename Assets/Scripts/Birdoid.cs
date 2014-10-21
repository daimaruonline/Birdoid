using UnityEngine;
using System.Collections;

public class Birdoid : MonoBehaviour {

	public Vector2 direction;
	public float speed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		var x = transform.position.x + direction.x * speed * Time.deltaTime;
		var y = transform.position.y + direction.y * speed * Time.deltaTime;
		transform.Translate(x, y, 0);
	}
}
