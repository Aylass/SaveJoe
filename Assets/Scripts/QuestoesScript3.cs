﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestoesScript3 : MonoBehaviour {

	public Text enunciado;
	string slivro;
	public Button A;
	public Button B;
	public Button C;
	public Button D;
	public Button E;
	public Button livro;
	public static int livros;
	public Text stlivro;
	// Use this for initialization
	
	void Start () {
		livro.gameObject.SetActive (false);
		livros = Dia1Cena2.livro;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void AltCerta ()
	{
		livros = Dia1Cena2.livro;
		Dia1cena3.momento = 80;
		livros = livros + 2;
		stlivro.text = "Numero de livros: " + livros.ToString();
		
	}
	
	public void Alterradas ()
	{   

		Dia1cena3.momento = 79;
	}

	
	public void clicalivro()
	{
		Application.LoadLevel ("Dia2-cena1");
		livros = livros - 1;
	}
	
}
