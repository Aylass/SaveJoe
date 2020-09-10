using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dia4cena1 : MonoBehaviour {
	public Text falanpc;
	public static int pontosjoe;
	public static int livro;
	public static int momento;
	public Text stlivros;
	public GameObject livrinho;
	public GameObject joe;
	public GameObject tres;
	public static int aux;

	// Use this for initialization
	void Start () {
		tres.gameObject.SetActive (false);
		livro = Dia3cena62.livro;
		stlivros.text = "Numero de livros: " + livro.ToString();
		pontosjoe = Dia3cena7.pontosjoe;
		momento = 0;
		aux = Dia3cena8.aux;
		livrinho.gameObject.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (momento == 0) 
		{
			falanpc.text = "*Pela manha, voce chega na aula de quimica e percebe que Joe nao esta na sala. A professora Tatiana entra e fala.* Bom dia gente! *Ela se aproxima de voce* Você sabe aonde está o Joe?";  
		    if (aux ==1)
			{

			}
		}

	
	}
}
