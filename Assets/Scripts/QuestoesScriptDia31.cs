using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestoesScriptDia31 : MonoBehaviour {
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
		livros = Dia3cena1.livro;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void AltCerta ()
	{
		livros = Dia3cena1.livro;
		Dia3cena1.momento = 80;
		livros = livros + 2;
		stlivro.text = "Numero de livros: " + livros.ToString();
	}
	public void Alterradas ()
	{   
		Dia3cena1.momento = 79;
	}
	public void clicalivro()
	{
		Application.LoadLevel ("");
		livros = livros - 1;
	}
}
