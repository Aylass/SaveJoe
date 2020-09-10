using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestoesScriptDia21 : MonoBehaviour {
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
		livros = Dia1cena3.livros;
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	public void AltCerta ()
	{   
		livros = Dia1cena3.livros;
		livros = livros + 2;
		stlivro.text = "Numero de livros: " + livros.ToString();
		Dia2cena1.momento = 80;



	}
	public void Alterradas ()
	{   
		Dia2cena1.momento = 79;
	}
	public void clicalivro()
	{
		//Application.LoadLevel ("Dia2-cena1");
		//livros = livros - 1;
	}

}
