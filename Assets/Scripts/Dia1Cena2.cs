using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dia1Cena2 : MonoBehaviour {

	public static int momento;
	public Button resp1;
	public Text tresp1;
	public Button livrinho;
	public Button resp2;
	public Text tresp2;
	public Button naoprecisamecontar;
	public Button serioeutambem;
	public Button voceestabem;
	public Text falajoe;
	public Text eleselembrara;
	public static int livro;
	public Text nrolivros;
	public static int pontosjoe;
	public GameObject joe;
	public GameObject btrespontos;
	public GameObject cxtexto;

		// Use this for initialization
	void Start () 
	{
		pontosjoe = GeralzaoController.pontosjoe;
		livro = QuestoesScript.livros;
		nrolivros.text = "Numero de livros: " + livro.ToString();
		eleselembrara.gameObject.SetActive (false);
		voceestabem.gameObject.SetActive (false);
		naoprecisamecontar.gameObject.SetActive (false);
		serioeutambem.gameObject.SetActive (false);
		livrinho.gameObject.SetActive (false);
		btrespontos.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{	//Debug.Log (momento);
		Debug.Log (livro);
		if (momento == 1) 
		{
			resp1.gameObject.SetActive (false);
			resp2.gameObject.SetActive (false);
			//perde um ponto com o joe
			falajoe.text = "";
			eleselembrara.gameObject.SetActive(true);
			livrinho.gameObject.SetActive(true);
			joe.gameObject.SetActive(false);
			
		}

		if (momento == 2) 
		{
			falajoe.text = "";
			voceestabem.gameObject.SetActive(true);
			resp2.gameObject.SetActive(false);
			resp1.gameObject.SetActive (false);
		}
		if (momento == 3) 
		{
			falajoe.text = "Estou sim, obrigado por se preocupar. * Enquanto isso, uma lagrima singela cai de seu rosto.*";
			voceestabem.gameObject.SetActive(false);
			naoprecisamecontar.gameObject.SetActive(true);	
		}
		if (momento == 4) 
		{
			falajoe.text = "Alfa 03, e voce?";
			naoprecisamecontar.gameObject.SetActive(false);
			serioeutambem.gameObject.SetActive(true);
		}
		if (momento == 5) 
		{
			falajoe.text = "E... Vamos sim.";
			btrespontos.gameObject.SetActive (true);
			serioeutambem.gameObject.SetActive(false);
			//livrinho.gameObject.SetActive(true);
		}
		if (momento == 6) 
		{
			btrespontos.gameObject.SetActive (false);
			falajoe.text = " ";
			cxtexto.gameObject.SetActive(false);
			livrinho.gameObject.SetActive(true);
			joe.gameObject.SetActive(false);
		}

	}
	
	public void IrAula()
	{
	   momento = 1;
	}
	public void FalarJoe()
	{
	   momento = 2;
		pontosjoe = pontosjoe + 1; // valor 1 pq foi legal, valor2 pq foi massa, valor -1 pq foi chato, -2 pq foi cuzao
	}
	public void sentarjoe()
	{
		momento = 3;
	}
	public void desnecessauro()
	{
		momento = 4;
	}
	public void iraulajoe()
	{
		momento = 5;
	}

	public void trespontinhos()
	{
		momento = 6;
	}
	public void livrinhosair()
	{   
		livro = livro - 1;
		Application.LoadLevel ("Dia1-cena3");

	}
}



