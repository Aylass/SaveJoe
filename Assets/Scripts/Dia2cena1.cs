using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Dia2cena1 : MonoBehaviour {

	public Button livrinho;
	public Text nrolivros;
	public static int livro;	
	public static int momento;
	public static int pontosjoe;
	public static int ajudoujoe;
	public Text falanpc;
	public GameObject carol;
	public GameObject joe;
	public Button btjuliainforma; 
	public Button btjoeinvergonhado;
	public Button btolharjoe;
	public Button btajudarjoe;
	public Button btnaoajudarjoe;
	public Button btajudarounaojoe;
	public Button btcarolchama;
	public Button btninguemresponde;
	public Button A;
	public Button B;
	public Button C;
	public Button D;
	public Button E;

	// Use this for initialization
	void Start () {
		ajudoujoe = 0;
		pontosjoe = Dia1cena3.pontosjoe;
		momento = 0;
		livrinho.gameObject.SetActive (false);
		livro = Dia1cena3.livros;
		nrolivros.text = "Numero de livros: " + livro.ToString();
		joe.gameObject.SetActive (false);
		btjoeinvergonhado.gameObject.SetActive (false);
		btolharjoe.gameObject.SetActive (false);
		btajudarjoe.gameObject.SetActive (false);
		btnaoajudarjoe.gameObject.SetActive (false);
		btcarolchama.gameObject.SetActive (false);
		btninguemresponde.gameObject.SetActive(false);
		A.gameObject.SetActive(false);
		B.gameObject.SetActive(false);
		C.gameObject.SetActive(false);
		D.gameObject.SetActive(false);
		E.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (pontosjoe);
		if (momento == 0) 
		{
			falanpc.text = "*A professora Carol entra na sala de aula* Bom dia gurizada! Voces sabem que amanha e o CETEC Festival de voces, certo?";
		}
		if (momento == 1)
		{
			falanpc.text = "*A colega Juliana se aproxima da professora e a informa algo, que posteriormente a faz olhar feio para Joe.* Como esta andando o cenario Joe?";
			btjuliainforma.gameObject.SetActive(false);
			btjoeinvergonhado.gameObject.SetActive (true);
		}
		if (momento == 2) 
		{
			btjoeinvergonhado.gameObject.SetActive (false);
			carol.gameObject.SetActive (false);
			joe.gameObject.SetActive (true);
			btolharjoe.gameObject.SetActive (true);
			falanpc.text = "T-a-h tu..do bem..*Joe vira-se para voce desesperado*";
		}
		if (momento == 3) 
		{
			btolharjoe.gameObject.SetActive (false);
			falanpc.text = "Voce pode me ajudar a resolver alguns problemas no cenario?";
			btajudarjoe.gameObject.SetActive (true);
			btnaoajudarjoe.gameObject.SetActive (true);
		}
		if (momento == 4) 
		{
			falanpc.text = "Muito obrigado!*Fala Joe contente*";
			btajudarjoe.gameObject.SetActive (false);
			btnaoajudarjoe.gameObject.SetActive (false);
			btcarolchama.gameObject.SetActive (true);

		}
		if (momento == 5) {
			falanpc.text = "Muito obrigado por nada!*Fala Joe emburrado*";
			btajudarjoe.gameObject.SetActive (false);
			btnaoajudarjoe.gameObject.SetActive (false);
			btcarolchama.gameObject.SetActive (true);
		}
		if (momento == 6)
		{
			Debug.Log ("pontosjoe");
			carol.gameObject.SetActive(true);
			falanpc.text = "Bom voltando ao assunto de literatura, estavamos vendo um conteudo que cai muito no ENEM. Alguem sabe me responder?(pergunda do db)";
			btcarolchama.gameObject.SetActive (false);
			joe.gameObject.SetActive(false);
			btninguemresponde.gameObject.SetActive(true);
		}
		if (momento == 7) 
		{
			falanpc.text = "Aluno novo(a), responda a pergunta!(pergunta do db)";
			btninguemresponde.gameObject.SetActive(false);
			A.gameObject.SetActive(true);
			B.gameObject.SetActive(true);
			C.gameObject.SetActive(true);
			D.gameObject.SetActive(true);
			E.gameObject.SetActive(true);
		}
		if (momento == 80)
		{ 
			Debug.Log("entrosaporra");
			falanpc.text = "Isso ai! Muito bem!*Carol se vira para a tura e fala em tonalidade forte* Voces deveriam se dedicar mais, como o nosso aluno(a) novo(a)!*O sinal toca alegremente, e todos os alunos se dirigem para fora da sala.Voce observa Joe saindo apressado.*";
			A.gameObject.SetActive (false);
			B.gameObject.SetActive (false);
			C.gameObject.SetActive (false);
			D.gameObject.SetActive (false);
			E.gameObject.SetActive (false);
			livrinho.gameObject.SetActive (true);
		}
		if (momento == 79) 
		{ 
			falanpc.text = "Essa nao era a resposta correta, mas voce vai acabar se adaptando a escola, nao se preocupe!*O sinal toca alegremente, e todos os alunos se dirigem para fora da sala.Voce observa Joe saindo apressado.*";
			A.gameObject.SetActive (false);
			B.gameObject.SetActive (false);
			C.gameObject.SetActive (false);
			D.gameObject.SetActive (false);
			E.gameObject.SetActive (false);
			livrinho.gameObject.SetActive (true);
		}
	}



	public void  informacarol ()
	{
		momento = 1;
	}
	public void joeinvergonhado()
	{
		momento = 2;
	}
	public void olharjoe()
	{
		momento = 3;
	}
	public void fajudarjoe()
	{
		pontosjoe =  pontosjoe +1;
		ajudoujoe = 1;
		momento = 4;
	}
	public void fnaoajudarjoe()
	{
		pontosjoe =  pontosjoe - 1;
		momento = 5;
	}
	public void fcarolchamaatencaodaturma()
	{
		momento = 6;
	}
	public void fninguemresponde()
	{
		momento = 7;
	}
	public void funlivrinho()
	{
		livro = QuestoesScriptDia21.livros;
		Application.LoadLevel ("Dia2-cena2");
		livro = livro - 1;
	}

}
