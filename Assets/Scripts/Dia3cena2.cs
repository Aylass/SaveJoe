using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dia3cena2 : MonoBehaviour {
	public Text falanpc;
	public static int pontosjoe;
	public static int livro;
	public static int momento;
	public static int ajudoujoe;
	public Text stlivros;
	public GameObject livrinho;
	public GameObject alex;
	public GameObject btc;
	public GameObject btcantes;

	// Use this for initialization
	void Start () 
	{ 
		livro = Dia3cena1.livro;
		stlivros.text = "Numero de livros: " + livro.ToString();
		btc.gameObject.SetActive (false);
		btcantes.gameObject.SetActive (false);
		livrinho.gameObject.SetActive (false);
		pontosjoe = Dia3cena1.pontosjoe;
		momento = 0;
		alex.gameObject.SetActive(true);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (momento == 0) 
		{
			falanpc.text = "Ei, antes de ir, preciso falar com você… *Ele espera Joe se afastar um pouco antes de continuar.* O Joe está com problemas em algumas matérias, o que é muito estranho porque ele é muito inteligente e também nunca tinha ido mal em nada. Até já conseguiu uma bolsa de estudos aqui pela sua dedicação!";
			alex.gameObject.SetActive(true);
			btcantes.gameObject.SetActive(true);
		}
		if (momento == 2) 
		{
			falanpc.text = "Eu… andei falando com algumas pessoas, mas ninguém consegue ajudá-lo e nem descobrir qual é o problema. Veja o que você pode fazer por favor. Conto com você!";
			btc.gameObject.SetActive(true);
			btcantes.gameObject.SetActive(false);
		}
		if (momento == 1) 
		{
			btc.gameObject.SetActive(false);
			alex.gameObject.SetActive(false);
			falanpc.text = "*Alex volta em direcao a sala de aula*";
			livrinho.gameObject.SetActive(true);
		}
	
	}
	public void c()
	{
		momento = 1;
	}
	public void antes()
	{
		momento = 2;
	}
	public void livrinhos()
	{
		livro = livro - 1;
		Application.LoadLevel("Dia3-cena3");
	}

}
