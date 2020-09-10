using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dia3cena62 : MonoBehaviour {

	public Text falanpc;
	public static int pontosjoe;
	public static int livro;
	public static int momento;
	public Text stlivros;
	public GameObject livrinho;
	public GameObject btjoe;
	public GameObject btvocenaotemqueseculpar;
	public GameObject bttemalgumacoisa;
	public GameObject btespera;
	public GameObject bttrespontinhos;
	public GameObject btvousim;
	public GameObject joe;


	// Use this for initialization
	void Start () {

		livro = Dia3cena6.livro;
		stlivros.text = "Numero de livros: " + livro.ToString();
		momento = 0;
		livrinho.gameObject.SetActive (false);
		btvocenaotemqueseculpar.gameObject.SetActive (false);
		bttemalgumacoisa.gameObject.SetActive (false);
		btespera.gameObject.SetActive (false);
		bttrespontinhos.gameObject.SetActive (false);
		btvousim.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (momento == 0) 
		{
			falanpc.text = "";
		}

		if (momento == 1) 
		{
			falanpc.text = "Se você não se importa, eu gostaria de ficar sozinho agora. *Você percebe que a voz dele está cheia de raiva*";
			btjoe.gameObject.SetActive(false);
			btvocenaotemqueseculpar.gameObject.SetActive(true);
		}

		if (momento == 2) 
		{
			falanpc.text = "Eu sei! Mas isso não importa para eles! O problema deles sempre sou eu!";
			btvocenaotemqueseculpar.gameObject.SetActive(false);
			bttemalgumacoisa.gameObject.SetActive(true);
		}

		if (momento == 3) 
		{
			falanpc.text = "Obrigado, mas não. *ele responde de maneira meio ríspida e começa a ir embora.*";
			bttemalgumacoisa.gameObject.SetActive(false);
			btespera.gameObject.SetActive(true);
		}
	
		if (momento == 4) 
		{
			falanpc.text = "Não vai nada! Você já me trouxe muitos problemas por hoje!";
			btespera.gameObject.SetActive(false);
			btvousim.gameObject.SetActive(true);
		}

		if (momento == 5) 
		{
			falanpc.text = "*Joe está escondendo alguma coisa, com certeza. Você estranhou um pouco ele ter ficado agressivo de repente, mas acha que essa vai ser uma noite muito esclarecedora.*";
			bttrespontinhos.gameObject.SetActive(true);
			btvousim.gameObject.SetActive(false);
			joe.gameObject.SetActive(false);
		}

		if (momento == 6) 
		{
			falanpc.text = "";
			bttrespontinhos.gameObject.SetActive(false);
			livrinho.gameObject.SetActive(true);
		}
	}

	public void funcaojoe()
	{
		momento = 1;
	}

	public void vocenaotemqueseculpar()
	{
		momento = 2;
	}

	public void temalgumacoisa()
	{
		momento = 3;
	}

	public void espera()
	{
		momento = 4;
	}
	public void vousim()
	{
		momento = 5;
	}

	public void trespontinhos()
	{
		momento = 6;
	}

	public void livrinhos()
	{
		livro = livro - 1;
		Application.LoadLevel("Dia3-cena7");
	}
}
