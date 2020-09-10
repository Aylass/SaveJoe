using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dia2cena2 : MonoBehaviour {
	public static int pontosjoe;
	public static int ajudoujoe;
	public Text falanpc;
	public Text bttext;
	public GameObject sib;
	public static int momento;
	public Button btsimounao;
	public Button btrespondesib2;
	public Button livrinho;
	public Button A;
	public Button B;
	public Button C;
	public Button D;
	public Button E;
	public static int nlivros;
	public Text stlivros;
	public Button btirsaladeartes;
	public Text textbtirsaladeartes;

	// Use this for initialization
	void Start () {
		nlivros = Dia2cena1.livro;
		stlivros.text = "Numero de livros: " + nlivros.ToString();
		livrinho.gameObject.SetActive (false);
		momento = 1;
		pontosjoe = Dia2cena1.pontosjoe;
		ajudoujoe = Dia2cena1.ajudoujoe;
		btrespondesib2.gameObject.SetActive (false);
		A.gameObject.SetActive(false);
		B.gameObject.SetActive(false);
		C.gameObject.SetActive(false);
		D.gameObject.SetActive(false);
		E.gameObject.SetActive(false);
		btirsaladeartes.gameObject.SetActive (false);
		sib.gameObject.SetActive (true);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (momento == 1) {
			if (ajudoujoe == 1) 
			{
				//falanpc.text = " ";
				bttext.text = "Sim! Eu ja estava indo ajuda-lo.";
			}
			if (ajudoujoe == 0) 
			{
				//falanpc.text = " ";
				bttext.text = "AAA... Ta ne...";
				//btsimounao.gameObject.SetActive(false);
			}

		}

		if (momento == 2) 
		{
			btsimounao.gameObject.SetActive(false);
			falanpc.text = "Que otimo! Apreoveite e revise com ele algumas questoes de matematica! Ele anda bem perdido, mal sabe me responder PERGUNTA DO BD";
			btrespondesib2.gameObject.SetActive (true);
		}

		if (momento == 3) 
		{
			A.gameObject.SetActive(true);
			B.gameObject.SetActive(true);
			C.gameObject.SetActive(true);
			D.gameObject.SetActive(true);
			E.gameObject.SetActive(true);
			btrespondesib2.gameObject.SetActive (false);
		}
		if (momento == 80) 
		{
			falanpc.text = "Corretissimo! Os alunos aprendem rapido!";
			A.gameObject.SetActive(false);
			B.gameObject.SetActive(false);
			C.gameObject.SetActive(false);
			D.gameObject.SetActive(false);
			E.gameObject.SetActive(false);
			textbtirsaladeartes.text = "*Com seu sorrisinho confiante voce fala* Bom vou indo entao. *Voce se vira em direcao a sala de artes*";
			btirsaladeartes.gameObject.SetActive (true);
		}
		if (momento == 79) 
		{
			falanpc.text = "Que educaçao eles estao dando neste pais?";
			textbtirsaladeartes.text = "... Bom vou indo para a sala entao...";
			A.gameObject.SetActive(false);
			B.gameObject.SetActive(false);
			C.gameObject.SetActive(false);
			D.gameObject.SetActive(false);
			E.gameObject.SetActive(false);
			btirsaladeartes.gameObject.SetActive (true);
		}
		if (momento == 4) 
		{
			sib.gameObject.SetActive (false);
			falanpc.text = " ";
			btirsaladeartes.gameObject.SetActive(false);
			livrinho.gameObject.SetActive(true);
		}

	}
	public void simounao()
	{
		Debug.Log ("clico");
		momento = 2;
	}

	public void sib2()
	{
		momento = 3;
	}
	public void irsaladeartes()
	{
		momento = 4;
	}

}
