using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dia3cena7 : MonoBehaviour {

	public Text falanpc;
	public static int pontosjoe;
	public static int livro;
	public static int momento;
	public Text stlivros;
	public GameObject livrinho;
	public GameObject btmeuspaisnoslevam;
	public GameObject btporque;
	public GameObject btvousim;
	public GameObject bttrespontinhos;
	public GameObject joe;

	// Use this for initialization
	void Start () {

		livro = Dia3cena62.livro;
		stlivros.text = "Numero de livros: " + livro.ToString();
		pontosjoe = Dia3cena1.pontosjoe;
		momento = 0;
		livrinho.gameObject.SetActive (false);
		btporque.gameObject.SetActive (false);
		btvousim.gameObject.SetActive (false);
		bttrespontinhos.gameObject.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (momento == 0) 
		{
			falanpc.text = "*Após as cortinas se fecharem, o cenário foi recolocado e a peça recomeçou do início. Quando ela acabou, você foi assistir às outras peças com seus colegas, que não paravam de falar mal do Joe e de culpá-lo. Você se sentiu mal durante todo o espetáculo, pensando que precisava falar com Joe. Você o encontra no fundo do teatro quando todos já saíram.*";
		}

		if (momento == 1) 
		{ 
			Debug.Log(pontosjoe);
			falanpc.text = "Não precisa.";
			btmeuspaisnoslevam.gameObject.SetActive(false);
			btporque.gameObject.SetActive (true);
		}

		if (momento == 2) 
		{
			falanpc.text = "Não! É por que você não vai pra minha casa!";
			btporque.gameObject.SetActive (false);
			btvousim.gameObject.SetActive(true);
		}

		if (momento == 3) 
		{
			falanpc.text = "*Joe parece bravo, mas logo relaxa os ombros* Está bem. Vamos logo então.";
			btvousim.gameObject.SetActive(false);
			bttrespontinhos.gameObject.SetActive(true);
		}

		if (momento == 4) 
		{
			falanpc.text = "";
			bttrespontinhos.gameObject.SetActive(false);
			joe.gameObject.SetActive(false);
			livrinho.gameObject.SetActive(true);
		}
	
	}

	public void meuspais()
	{
		momento = 1;
	}

	public void porque()
	{
		momento = 2;
	}

	public void vousim()
	{
		momento = 3;
	}

	public void trespontinhos()
	{
		momento = 4;
	}

	public void livrinhos()
	{
		livro = livro - 1;
		Application.LoadLevel("Dia3-cena8");
	}
}
