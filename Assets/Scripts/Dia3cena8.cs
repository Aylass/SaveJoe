using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dia3cena8 : MonoBehaviour {
	public Text falanpc;
	public static int pontosjoe;
	public static int livro;
	public static int momento;
	public Text stlivros;
	public GameObject livrinho;
	public GameObject joe;
	public GameObject tres;
	public GameObject um;
	public GameObject dois;
	public GameObject quatro;
	public GameObject cinco;
	public GameObject seis;
	public GameObject quatros;
	public GameObject cincos;
	public static int aux;

	// Use this for initialization
	void Start () {
		cincos.gameObject.SetActive (false);
		quatros.gameObject.SetActive (false);
		tres.gameObject.SetActive (false);
		joe.gameObject.SetActive (false);
		seis.gameObject.SetActive (false);
		cinco.gameObject.SetActive (false);
		quatro.gameObject.SetActive (false);
		dois.gameObject.SetActive (false);
		um.gameObject.SetActive (false);
		livro = Dia3cena62.livro;
		stlivros.text = "Numero de livros: " + livro.ToString();
		pontosjoe = Dia3cena7.pontosjoe;
		momento = 0;
		aux = 0;
		livrinho.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {

		if (momento == 0) 
		{
			tres.gameObject.SetActive (true);
			falanpc.text = "*Seus pais dirigem até a casa de Joe, que fica afastada do centro da cidade. Vocês dois andam até a porta.*";
		}
		if (momento == 1) 
		{
			falanpc.text = "Obrigada pela carona *Joe desce do carro e fecha a porta atrás dele.* Te vejo na próxima aula.";
			um.gameObject.SetActive(true);
			tres.gameObject.SetActive(false);
			joe.gameObject.SetActive(true);
		}
		if (momento == 2) 
		{
			falanpc.text = "Acredite em mim, e melhor voce nao entrar... ";
			um.gameObject.SetActive(false);
			dois.gameObject.SetActive(true);
			joe.gameObject.SetActive(true);
		}
		if (momento == 3) 
		{
			if (pontosjoe >= 3)
			{
				falanpc.text = "Sinceramente? *Joe parece apreensivo* Se vc descobrir vc vai querer é fugir.";
				dois.gameObject.SetActive(false);
				quatro.gameObject.SetActive(true);
				aux = 2;
			}
			if (pontosjoe < 3)
			{
				dois.gameObject.SetActive(false);
				cincos.gameObject.SetActive(true);
				quatros.gameObject.SetActive(true);
				aux = 1;
				falanpc.text = "*Joe fica agitado e rude. Ele começa a gritar* Voce nao sabe nada da minha vida! Quem voce pensa que e? Meu amigo? Eu aviso.. eu tento *Sua voz fica chorosa* Eu juro que tento! *Lagrimas caem...* Mas mesmo assim, ele teve que fazer aquilo, e agora esta.. *A voz de Joe fica agressiva* PRESO!";
			}

		}
		if (momento == 4) 
		{
			falanpc.text = "*Joe abaixa a cabeça aos poucos, e voce sente que ele esta com medo de seu julgamento* Meu... Meu irmão está preso. *Voce fica surpreso e sem reaçao* Está muito tarde, e melhor voce tem que ir embora. *Ele empurra a porta na sua frente*";
			quatro.gameObject.SetActive(false);
			cinco.gameObject.SetActive(true);
		}
		if (momento == 44) 
		{
			falanpc.text = "*Ele o ouve falar e com vergonha fecha a porta*";
			quatros.gameObject.SetActive(false);
			cincos.gameObject.SetActive(false);
			seis.gameObject.SetActive(true);
		}
		if (momento == 55) 
		{
			falanpc.text = "*Ele o ouve falar e com vergonha fecha a porta*";
			quatros.gameObject.SetActive(false);
			cincos.gameObject.SetActive(false);
			seis.gameObject.SetActive(true);
		}
		if (momento == 5) 
		{
			falanpc.text = "*A porta se fecha e voce fica para fora. Espera um tempo e depois volta para o carro de seus pais.*"; 
			cinco.gameObject.SetActive(false);
			joe.gameObject.SetActive(false);
			seis.gameObject.SetActive(true);
		}
		if (momento == 6) 
		{
			joe.gameObject.SetActive(false);
			seis.gameObject.SetActive(false);
			falanpc.text = "";
			livrinho.gameObject.SetActive(true);
		}
	
	}

	public void tudobem()
	{
		momento = 1;
	}

	public void fum()
	{
		momento = 2;
	}
	public void fdois()
	{
		momento = 3;
	}
	public void fquatro()
	{
		momento = 4;
	}
	public void fquatros()
	{
		pontosjoe = pontosjoe + 1;
		momento = 44;
	}
	public void fcincos()
	{
		pontosjoe = pontosjoe - 1;
		momento = 55;
	}
	public void fcinco()
	{
		momento = 5;
	}
	public void fseis()
	{
		momento = 6;
	}
	public void livrinhos()
	{
		livro = livro - 1;
		Application.LoadLevel("TransicaoDia3para4");
	}

}
