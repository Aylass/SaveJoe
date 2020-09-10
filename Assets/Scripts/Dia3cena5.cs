using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dia3cena5 : MonoBehaviour {

	public Text falanpc;
	public static int pontosjoe;
	public static int livro;
	public static int momento;
	public Text stlivros;
	public GameObject livrinho;
	public GameObject bttudobemjoe;
	public GameObject btnaoseinada;
	public GameObject btvoucomvoce;
	public GameObject joe;

	// Use this for initialization
	void Start () {

		livro = Dia3cena4.livro;
		stlivros.text = "Numero de livros: " + livro.ToString();
		momento = 0;
		livrinho.gameObject.SetActive (false);
		btnaoseinada.gameObject.SetActive (false);
		btvoucomvoce.gameObject.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (momento == 0) 
		{
			falanpc.text = "*Você fica intrigado com o que acabou de acontecer*";
		
		}
		if (momento == 1) 
		{
			falanpc.text = "Sim, tudo bem... *ele fala calmamente, mas há certa inquetação em sua voz* Por quê? Você soube de alguma coisa sobre ele?";
			bttudobemjoe.gameObject.SetActive(false);
			btnaoseinada.gameObject.SetActive(true);
			
		}
		if (momento == 2) 
		{
			btnaoseinada.gameObject.SetActive(false);
			falanpc.text = "Não! Está tudo bem mesmo. Não se preocupe com isso. *ele logo troca de assunto* A apresentação já vai começar. É melhor eu ir organizar o cenário.";
			btvoucomvoce.gameObject.SetActive(true);	
		}
		if (momento == 3) 
		{
			falanpc.text = "";
			btvoucomvoce.gameObject.SetActive(false);
			livrinho.gameObject.SetActive(true);
			joe.gameObject.SetActive(false);
		}

	
	}

	public void tudobemjoe()
	{
		momento = 1;
	}

	public void naoseinada()
	{
		momento = 2;
	}

	public void voucomvoce()
	{
		momento = 3;
	}

	public void livrinhos()
	{
		livro = livro - 1;
		Application.LoadLevel("Dia3-cena6");
	}
}
