using UnityEngine;
using System.Collections;

public class GeneradorMonedas : MonoBehaviour {
	public GameObject Monedas; 
	private GameObject monedaNueva;
	private Transform posSalida;


	// Use this for initialization
	void Start () {
		posSalida = transform.Find ("posSalida").transform;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D objeto){
		if(objeto.tag == "Player" && monedaNueva == null){
			monedaNueva = (GameObject)Instantiate (Monedas,posSalida.position, transform.rotation);
}
	}
}
