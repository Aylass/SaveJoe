using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dia1cena3 : MonoBehaviour {

	public Text falanpc;
	public static int momento;
	public static int pontosjoe;
	public Button btentrar;
	public Button btsilencio;
	public Button btfalarporjoe;
	public Button btnaofalarporjoe;
	public GameObject joe;
	public GameObject andrea;
	public Button A;
	public Button B;
	public Button C;
	public Button D;
	public Button E;
	public Text tbtentrar;
	public Button btaulacontinua;
	public Text tbtaulacontinua;
	public static int livros;
	public Button btsometudo;
	public GameObject cxtexto;
	public Button livrinho;
	public Text livrotela;
	// Use this for initialization
	void Start () 
	{
		livros = Dia1Cena2.livro;
		livrotela.text = "Numero de livros: " + livros.ToString();
		livrinho.gameObject.SetActive(false);
		momento = 0;
		btsometudo.gameObject.SetActive (false);
		pontosjoe = Dia1Cena2.pontosjoe;
		btsilencio.gameObject.SetActive(false);
		btaulacontinua.gameObject.SetActive(false);
		btfalarporjoe.gameObject.SetActive(false);
		btnaofalarporjoe.gameObject.SetActive(false);
		joe.gameObject.SetActive (false);  
		A.gameObject.SetActive(false);
		B.gameObject.SetActive(false);
		C.gameObject.SetActive(false);
		D.gameObject.SetActive(false);
		E.gameObject.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (momento);
		if (pontosjoe == 1) 
		{
			btentrar.gameObject.SetActive (true);
			falanpc.text = "Joe! Voce esta atrasado de novo! E voce... atrasado no primeiro dia, hein!"; // cara de nojo
		}
		if (pontosjoe == 0) 
		{
			btentrar.gameObject.SetActive (true);
			falanpc.text = "Bom dia! Classe, deem as boas vindas ao nosso novo aluno!* Todos dizem um 'oi' timido*";
		}
		if (momento == 1) 
		{
			btentrar.gameObject.SetActive (false);
			btsilencio.gameObject.SetActive(true);
			falanpc.text = "Bem, Criaturas da Noite, hoje vamos dar continuidade ao assunto da aula passada. Alguem sabe me responder pergunta do db.";

		}
		if (momento == 2) 
		{
			btsilencio.gameObject.SetActive(false);
			btentrar.gameObject.SetActive (false);
			falanpc.text = "Joe!Voce sabe!*Joe fica envergonhado e ao fundo da sala começa uma risada maliciosa. Todos encaram Joe, inclusive voce.*";
			btfalarporjoe.gameObject.SetActive(true);
			//joe.gameObject.SetActive (true);
			btnaofalarporjoe.gameObject.SetActive(true);
		}
		if (momento == 3) 
		{
			falanpc.text = "PERGUNTA DO BD CHEGA NA MAIOR ALEGRIA";
			btfalarporjoe.gameObject.SetActive(false);
			btnaofalarporjoe.gameObject.SetActive(false);
		    A.gameObject.SetActive(true);
			B.gameObject.SetActive(true);
			C.gameObject.SetActive(true);
			D.gameObject.SetActive(true);
			E.gameObject.SetActive(true);
			btentrar.gameObject.SetActive(false);
		}
		if (momento == 4) 
		{
			falanpc.text = " Ahnnn... eu... eu acho que... eu nao sei.";
			btfalarporjoe.gameObject.SetActive(false);
			btnaofalarporjoe.gameObject.SetActive(false);
			btentrar.gameObject.SetActive(true);
			andrea.gameObject.SetActive(false);
			joe.gameObject.SetActive(true);
		}
		if (momento == 20) 
		{ 
			joe.gameObject.SetActive(false);
			andrea.gameObject.SetActive(true);
			falanpc.text = "E voce? *Andrea aponta para voce* Sabe me responder?";
			tbtentrar.text= "Talvez...";
			//momento=21;
		}
		if (momento == 80)
		{ 
		A.gameObject.SetActive (false);
		B.gameObject.SetActive (false);
		C.gameObject.SetActive (false);
		D.gameObject.SetActive (false);
		E.gameObject.SetActive (false);
		btentrar.gameObject.SetActive (false);
		btaulacontinua.gameObject.SetActive(true);
		tbtaulacontinua.text= ":(";
			if (pontosjoe>1) 
			{
			falanpc.text = "Se voce ja sabia, por que nao falou antes? *faz uma cara de nojo*";
			}
			if (pontosjoe< 2) 
			{
				falanpc.text = "Muito bem.";
				btentrar.gameObject.SetActive(false);
				tbtaulacontinua.text= ":)";
			}
		
		}
		if (momento == 7) 
		{
			falanpc.text = "";
			andrea.gameObject.SetActive(false);
			btsometudo.gameObject.SetActive(false);
			joe.gameObject.SetActive(false);
			cxtexto.gameObject.SetActive(false);
			livrinho.gameObject.SetActive(true);
			btentrar.gameObject.SetActive(false);


		}

		if (momento == 79)
		{ 
			A.gameObject.SetActive (false);
			B.gameObject.SetActive (false);
			C.gameObject.SetActive (false);
			D.gameObject.SetActive (false);
			E.gameObject.SetActive (false);
			btentrar.gameObject.SetActive (false);
			btaulacontinua.gameObject.SetActive(true);
			tbtaulacontinua.text= ":(";
			if (pontosjoe>1) 
			{
				falanpc.text = "Eu perguntei pro Joe! Nao responda se voce nao sabe!";
			}
			if (pontosjoe< 2) 
			{
				falanpc.text = "Nao. Isso nao esta certo. Voce precisa estudar mais, de maneira muito significativa.";
			}
		}

		if (momento == 5) 
		{
			falanpc.text = "*A aula de historia continuou sem maiores acontecimentos. Voce conversou com alguns outros alunos e se sentiu animado. Talvez nao seja tao ruim assim estudar nesse tal de CETEC...*";
			btaulacontinua.gameObject.SetActive(false);
			btsometudo.gameObject.SetActive(true);
			btentrar.gameObject.SetActive(false);
			tbtentrar.text = " ";

		}
		if (momento == 6) 
		{
			falanpc.text = " ";
			btaulacontinua.gameObject.SetActive(false);
			tbtaulacontinua.text = " ";
			joe.gameObject.SetActive (false); 
			andrea.gameObject.SetActive(false); 
		}

	}
	public void entrar()
	{
		if (momento == 4)
		{
			momento = 20;
		}
		if (tbtentrar.text=="Talvez...")
		{
		momento = 3;
		}
		if (momento == 0)
		{
		 momento = 1;
		}

	}
	public void silencio()
	{
		momento = 2;
	}
	public void responderjoe()
	{
		momento = 3;
		pontosjoe = pontosjoe + 2;
	}
	public void ficarnasua()
	{
		momento = 4;
	}
	public void continuaaula()
	{
		momento = 5;
	}
	public void sometudo()
	{
		momento = 7;
	}

	public void funlivrinho()
	{
		livros = QuestoesScript3.livros;
		Application.LoadLevel ("TransicaoDia1para2");
		livros = livros - 1;
	}
}


