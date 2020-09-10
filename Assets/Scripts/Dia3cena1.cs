using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Dia3cena1 : MonoBehaviour {
	public Text falanpc;
	public static int pontosjoe;
	public static int livro;
	public static int momento;
	public static int ajudoujoe;
	public static int aux;
	public GameObject joe;
	public Button btvibram;
	public Button A;
	public Button B;
	public Button C;
	public Button D;
	public Button E;
	public Button bttrespontinhos;
	public Button btcontinuar;
	public Text txcontinuar;
	public GameObject alex;
	public Text stlivros;
	public Button bteijoe;
	public Button btvamosnessa;
	public GameObject caixinha;
	public GameObject livrinho2;
	public GameObject btcontinuaxingamento;
	public GameObject btfimdoxingamento;
	public GameObject btc1;
	public GameObject btc2;
	public GameObject btsit;
	public GameObject btask;
	public GameObject btsairartes;

	// Use this for initialization

	void Start () {
		btsairartes.gameObject.SetActive (false);
		btc1.gameObject.SetActive (false);
		btc2.gameObject.SetActive (false);
		btsit.gameObject.SetActive (false);
		btask.gameObject.SetActive (false);
		btcontinuaxingamento.SetActive (false);
		btfimdoxingamento.gameObject.SetActive (false);
		livrinho2.gameObject.SetActive (false);
		caixinha.gameObject.SetActive (true);
		btvamosnessa.gameObject.SetActive (false);
		bteijoe.gameObject.SetActive (false);
		joe.gameObject.SetActive (false);
		livro = Dia2cena3.livros;
		stlivros.text = "Numero de livros: " + livro.ToString();
		ajudoujoe = Dia2cena1.ajudoujoe;
		pontosjoe = Dia2cena2.pontosjoe;
		momento = 0;
		btvibram.gameObject.SetActive (false);
		A.gameObject.SetActive(false);
		B.gameObject.SetActive(false);
		C.gameObject.SetActive(false);
		D.gameObject.SetActive(false);
		E.gameObject.SetActive(false);
		bttrespontinhos.gameObject.SetActive (false);
		btcontinuar.gameObject.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (momento == 0) 
		{
			falanpc.text = "Bom dia turma! *O professor chegou na sala de aula com um sorriso enorme no rosto dirigido a cada um dos seus alunos.* Hoje, eu daria mais um conteúdo para a prova, mas decidi liberar a aula para ensaio do CETEC Festival.";
			btvibram.gameObject.SetActive(true);
		}
		if (momento == 1)
		{
			falanpc.text = "Com uma condição! *Diz ele erguendo o indicador. Quando prosseguiu, pudemos, enfim, compreender a razão daquele bom humor todo.* Vocês só vão poder usar a aula para ensaiar se alguém responder uma questão:";
			btvibram.gameObject.SetActive(false);
			bttrespontinhos.gameObject.SetActive(true);
		}

		if (momento == 2)
		{
			bttrespontinhos.gameObject.SetActive(false);
			falanpc.text = "(pergunta do bd)";
			A.gameObject.SetActive(true);
			B.gameObject.SetActive(true);
			C.gameObject.SetActive(true);
			D.gameObject.SetActive(true);
			E.gameObject.SetActive(true);
		}

		if (momento == 3)
		{
			if (txcontinuar.text == "AEEEE *A turma fica contente* ") 
			{
				btcontinuar.gameObject.SetActive(false);
				alex.gameObject.SetActive(false);
				falanpc.text = "*Todos começam a empurrar as mesas para os cantos da sala. Voce ve Joe indo ate a porta.*";
				joe.gameObject.SetActive(true);
				bteijoe.gameObject.SetActive(true);
			}
		}

		if (momento == 80) 
		{
			falanpc.text = "Correto! Organizem-se então, pessoal!";
			A.gameObject.SetActive(false);
			B.gameObject.SetActive(false);
			C.gameObject.SetActive(false);
			D.gameObject.SetActive(false);
			E.gameObject.SetActive(false);
			btcontinuar.gameObject.SetActive (true);
			txcontinuar.text = "AEEEE *A turma fica contente* ";

		}
		if (momento == 79) 
		{
			falanpc.text = "Errado. *Todos os seus colegas começam a falar ao mesmo tempo; alguns xingam você, enquanto outros tentam argumentar com o professor que não é justo perderem o ensaio por sua causa.*";
			A.gameObject.SetActive(false);
			B.gameObject.SetActive(false);
			C.gameObject.SetActive(false);
			D.gameObject.SetActive(false);
			E.gameObject.SetActive(false);
			btcontinuaxingamento.gameObject.SetActive(true);

			
		}
		if (momento == 4) 
		{
			bteijoe.gameObject.SetActive(false);
			btvamosnessa.gameObject.SetActive(true);
			aux = 1;
			falanpc.text = "*Ele se vira para você e parece até mesmo um pouco aliviado em ouvir que se ofereceu para ajudar.* Na verdade, preciso sim! Vamos indo para a sala de artes, temos realmente MUITA coisa a ser feita ainda.";
		}
		if (momento == 5) 
		{
			btvamosnessa.gameObject.SetActive(false);
			falanpc.text = "";
			joe.gameObject.SetActive(false);
			caixinha.gameObject.SetActive(false);
			livrinho2.gameObject.SetActive(true);

		}
		if (momento == 6) 
		{
			falanpc.text = "*Você afunda na cadeira, com o rosto baixo e vermelho de vergonha e arrependimento por ter tentado responder. O único em silêncio era Joe, que vez ou outra olhava você de canto com certa pena.*";
			btcontinuaxingamento.gameObject.SetActive(false);
			btfimdoxingamento.gameObject.SetActive(true);
		}

		if (momento == 7) 
		{
			falanpc.text = "Silêncio, silêncio, pessoal! Apesar de o colega de vocês não ter acertado a pergunta, eu apenas pedi para alguém RESPONDER, e ele respondeu! Por isso, chega de falação: organizem-se para o CETEC Festival!";
			btfimdoxingamento.gameObject.SetActive(false);
			alex.gameObject.SetActive(true);
			btc1.gameObject.SetActive(true);
		}
		if (momento == 8) 
		{
			btc1.gameObject.SetActive(false);
			btc2.gameObject.SetActive(true);
			alex.gameObject.SetActive(false);
			falanpc.text ="*Dito isso, todos começam a se aprontar para o ensaio. Alguns grupinhos se formam em certos cantos da sala de aula. Você ouve trechos de conversa que se alteram entre assuntos cotidianos irrelevantes e planejamentos de danças ou teatros.*";
		}
		if (momento == 9) 
		{
			btc2.gameObject.SetActive(false);
			btsit.gameObject.SetActive(true);
			btask.gameObject.SetActive(true);
			joe.gameObject.SetActive(true);
			falanpc.text = "*De sua cadeira, é possível enxergar Joe mexendo na mochila e colocando tintas, pincéis, papéis coloridos e outros materiais do gênero em cima da mochila. A movimentação constante ao seu redor o faz sentir-se agitado e você se pergunta o que deveria fazer em seguida.*";
		}
		if (momento == 10) 
		{
			btsit.gameObject.SetActive(false);
			btask.gameObject.SetActive(false);
			joe.gameObject.SetActive(false);
			alex.gameObject.SetActive(true);
			falanpc.text = "Mas, nenê, levanta daí e vai fazer alguma coisa!";
			btsairartes.gameObject.SetActive(true);
		}
		if (momento == 11) 
		{
			joe.gameObject.SetActive(false);
			falanpc.text = "*Voce se levanta e começa a andar em direçao a porta e ve Joe indo para a sala de artes tambem.*";
			btsairartes.gameObject.SetActive(false);
			alex.gameObject.SetActive(false);
			livrinho2.gameObject.SetActive(true);
		}
		if (momento == 12) 
		{
			btsit.gameObject.SetActive(false);
			btask.gameObject.SetActive(false);
			falanpc.text = "*Ele se vira para você e parece até mesmo um pouco aliviado em ouvir que se ofereceu para ajudar.* Na verdade, preciso sim! Vamos indo para a sala de artes, temos realmente MUITA coisa a ser feita ainda.";
			btsairartes.gameObject.SetActive(true);
		}
	}
	public void vibram()
	{
		momento = 1;
	}
	public void trespontinhos()
	{
		momento = 2;
	}

	public void continuar()
	{
		momento = 3;
	}

	public void eijoe()
	{
		momento = 4;
	}
	public void vamonessa()
	{
		momento = 5;
	}

	public void continuaxingamento()
	{
		momento = 6;
	}

	public void fimxingamento()
	{
		momento = 7;
	}
	public void c1()
	{
		momento = 8;
	}
	public void c2()
	{
		momento = 9;
	}
	public void sit()
	{
		momento = 10;
		aux = 0;
		pontosjoe = pontosjoe - 1;
	}
	public void ask()
	{
		momento = 12;
		aux = 1;
		pontosjoe = pontosjoe +1;
	}
	public void sairartes()
	{
		momento = 11;
	}

	public void livrinho()
	{
		livro = livro - 1;
		Application.LoadLevel("Dia3-cena2");
	}
}
