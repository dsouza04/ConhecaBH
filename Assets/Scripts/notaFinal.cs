using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notaFinal : MonoBehaviour {

	private int idDesafio;

	public Text txtNota;
	public Text txtInfoDesafio;

	public GameObject estrela1;
	public GameObject estrela2;
	public GameObject estrela3;

	private int notaF;
	private int acertos;


	// Use this for initialization
	void Start () {

		idDesafio = PlayerPrefs.GetInt ("idDesafio");

		//Iniciar inativo
		estrela1.SetActive (false);
		estrela2.SetActive (false);
		estrela3.SetActive (false);

		notaF = PlayerPrefs.GetInt ("notaFinalTemp" + idDesafio.ToString ());
		acertos = PlayerPrefs.GetInt ("acertosTemp" + idDesafio.ToString ());

		txtNota.text = notaF.ToString ();
		txtInfoDesafio.text = "Você acertou " + acertos.ToString () + " de 5 perguntas";

		if (notaF == 10) {

			estrela1.SetActive (true);
			estrela2.SetActive (true);
			estrela3.SetActive (true);
		} else if (notaF >= 7) {

			estrela1.SetActive (true);
			estrela2.SetActive (true);
			estrela3.SetActive (false);
		} else if (notaF >= 5) {
			estrela1.SetActive (true);
			estrela2.SetActive (false);
			estrela3.SetActive (false);
		}
			
	}
		public void jogarNovamente(){

		Application.LoadLevel ("D" + idDesafio.ToString());
	}
	

}
