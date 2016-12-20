using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float power = 1f;
	public float velocidad = 5f;
	public float salto = 400;
	private Rigidbody2D rb;
	private bool tocando_suelo = true;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("right")) {
			rb.velocity = new Vector2 (velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (1, 1, 1);
		}
		if (Input.GetKey ("left")) {
			rb.velocity = new Vector2 (-velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3 (-1, 1, 1);
	
		}
		if (Input.GetKeyDown (KeyCode.Space) && tocando_suelo) {
			rb.AddForce (new Vector2 (0, salto));
		}
	}
	void OnTriggerExit2D (Collider2D objeto){
		if (objeto.tag == "Suelo") {
			tocando_suelo = false;
		}
	}
		void OnTriggerStay2D (Collider2D objeto){
			if(objeto.tag == "Suelo"){
			tocando_suelo = true;	
			}
		}

}
