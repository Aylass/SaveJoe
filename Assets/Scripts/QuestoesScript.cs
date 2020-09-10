using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestoesScript : MonoBehaviour {
	public Text enunciado;
   public static int livros;
	public Text livrotela;
	string slivro;
	public GameObject saio;
	public Button A;
	public Button B;
	public Button C;
	public Button D;
	public Button E;
	public Button valeu;
	public Text tvaleu;
	public Button livro;
	// Use this for initialization

	void Start () {
	valeu.gameObject.SetActive (false);
	livro.gameObject.SetActive (false);
	livros = GeralzaoController.livro;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void AltCerta ()
	{

		A.gameObject.SetActive (false);
		B.gameObject.SetActive (false);
		C.gameObject.SetActive (false);
		D.gameObject.SetActive (false);
		E.gameObject.SetActive (false);

		enunciado.text = "Parabens, voce acertou! Tome aqui dois livros";
		Dia1Cena1.momento = 80;
		livros = livros + 2;
		slivro = "Numero de livros: " + livros.ToString();
		livrotela.text = slivro;
		tvaleu.text = "Valeu!";
		valeu.gameObject.SetActive (true);

	}

	public void Alterradas ()
	{   
		A.gameObject.SetActive (false);
		B.gameObject.SetActive (false);
		C.gameObject.SetActive (false);
		D.gameObject.SetActive (false);
		E.gameObject.SetActive (false);
		enunciado.text = "E isso que da nao ir nos estruturados :(";
		Dia1Cena1.momento = 80;
		tvaleu.text = ":(";
		valeu.gameObject.SetActive (true);
	}

	public void valeus ()
	{
		saio.gameObject.SetActive (false);
		valeu.gameObject.SetActive (false);
		enunciado.text = "Clique no livro que aparece no canto inferior direito de sua tela para mudar de cena.";
		livro.gameObject.SetActive (true);

	}

	public void clicalivro()
	{
		Application.LoadLevel ("Dia1-cena2");
		livros = livros - 1;
	}

}
