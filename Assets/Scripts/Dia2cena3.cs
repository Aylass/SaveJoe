using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dia2cena3 : MonoBehaviour {
	public Text falanpc;
	public static int pontosjoe;
	public static int livros;
	public static int momento;
	public static int ajudoujoe;
	public Button btreponderjoe;
	public Button livrinho;
	public Button btresponderjoe2;
	public Button btespreita;
	public Button btfalabaixo;
	public Text tfalabaixo;
	public Text textespreita;
	public Text bttext;
	public Text bttext2;
	public Button btsilenciocell;
	public Button btvctabem;
	public Text txvctabem;
	public Text stlivros;
	public Button btoqseraqaconteceu;
	public GameObject joe;
	public GameObject btportais;
	public Text txportais;

	// Use this for initialization
	void Start () {
		joe.gameObject.SetActive (true);
		livros = QuestoesScriptDia22.livros;
	    ajudoujoe = Dia2cena1.ajudoujoe;
		pontosjoe = Dia2cena2.pontosjoe;
		momento = 0;
		stlivros.text = "Numero de livros: " + livros.ToString();
		btresponderjoe2.gameObject.SetActive (false);
		btespreita.gameObject.SetActive (false);	
		btfalabaixo.gameObject.SetActive (false);
		btsilenciocell.gameObject.SetActive (false);
		livrinho.gameObject.SetActive (false);
		btvctabem.gameObject.SetActive (false);
		btoqseraqaconteceu.gameObject.SetActive (false);
		btportais.gameObject.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (momento);
		if (ajudoujoe == 1) 
		{
			falanpc.text = "*Joe o ve entrando na sala e libera um pequeno sorriso* Oi! Que bom que voce veio!";
			bttext.text = "Magina. Fico feliz em ajudar!";
		}
		if (ajudoujoe == 0) 
		{
			falanpc.text = "*Joe o olha de soslaio desconfiado* O que voce esta fazendo aqui? *Fala calmamente* Pode deixar, eu dou conta sozinho.";
			bttext.text = "A Slibele me mandou vir...";
		}
		if (momento == 1) 
		{
			falanpc.text = "Bom, preciso de ajuda para pintar este portal, pode cuidar isso?";
			btreponderjoe.gameObject.SetActive(false);
			btresponderjoe2.gameObject.SetActive(true);
			bttext2.text = "Claro!*Voce pega os pinceis e uma lata de tinta velha e começa a desfrutar do seu lado artistico*";
		}
		if (momento == 2) 
		{
			falanpc.text = "Claro, as professores nao confiam mais nos 'alunos' encarregados... *Fala irritado e com despreso na voz, mas voce percebe uma certa intençao quando ele fala 'alunos'* Voce pode começar pintando este portal.";
			btreponderjoe.gameObject.SetActive(false);
			btresponderjoe2.gameObject.SetActive(true);
			bttext2.text = "Ja que nao tenho outra escolha...*Leva um olhar penetrante a Joe*";
		}
		if (momento == 3) 
		{
			falanpc.text = "*Voce ouve um celular tocando e transita seu olher ate Joe, que esta andando em direçao ao celular.*";
			btespreita.gameObject.SetActive (true);
			btresponderjoe2.gameObject.SetActive(false);
			textespreita.text = "*Voce começa a prestar atençao na conversa de longe*";
		}
		if (momento == 4) 
		{
			falanpc.text = "*Voce vai ouvindo a conversa ate se deparar com a voz de Joe tremula e incredula* O que?! Nao! Nao vou ajudear ele, mae!.. Voce sabe que eu sou totalmente contra isso... Eu ja te falei que vou arrumar um trabalho e vamos sair dessa!... *Voce ouve a voz de Joe irritada e estranha, isso nao parece o perfil dele* Isso e contra meus principios..!";
			btfalabaixo.gameObject.SetActive(true);
			btespreita.gameObject.SetActive (false);
			tfalabaixo.text = "*Joe começa a falar cada vez mais baixo. Por sua sorte, ou azar consegue escuta-lo dizer...*"; 
		}
		if (momento == 5) 
		{
			btfalabaixo.gameObject.SetActive(false);
			falanpc.text = " ... e contra lei! Nao vou fazer parte disso!* Um gelo percorre sua espinha dorsal*";
			btsilenciocell.gameObject.SetActive(true);
		}
		if (momento == 6) 
		{
			falanpc.text = "*Voz no telefone:* Voce vai se arrepender disso, Joe.* O telefone e esligado e voce somente escuta o som da linha desligada*";
			btsilenciocell.gameObject.SetActive(false);
			btvctabem.gameObject.SetActive(true);
		}
		if (momento == 7) 
		{
			if (ajudoujoe == 1)
			{
				falanpc.text = "*Ve ele abalado* Nao! Tudo certo. *Nao existe animaçao em sua voz* Vamos logo terminar isso... * Joe se vira de costas e começa e mexer em uns papeis*";
				btportais.gameObject.SetActive(true);;
			}
			if (ajudoujoe == 0)
			{
				falanpc.text = " Nada... nada nao. *Sua voz sai delicada* Enfim, vamos continuar, temos muitas coisas para fazer";
				btportais.gameObject.SetActive(false);
				txvctabem.text = " Ta! Deixa quieto entao...";
			}	
		}
		if (momento == 8) 
		{
			Debug.Log("oi");
			//txportais.text = "
			btportais.gameObject.SetActive(false);
			falanpc.text = "*O dia continua normal, voce continua ajudando Joe na sala de artes. Porem por mais que voce anime Joe e comecem a resolver os problemas do CETEC festival juntos, ainda se pode sentir a tensao da situaçao anterior no ar.*";
			btvctabem.gameObject.SetActive(false);
			btoqseraqaconteceu.gameObject.SetActive(true);
		}
		if (momento == 9) 
		{
			btportais.gameObject.SetActive(false);
			falanpc.text = "*O dia continua normal, você ajudando Joe na sala de artes. Porem por mais que o tempo passe e voce Joe e comecem a resolver os problemas do CETEC festival juntos, ainda se pode sentir a tensao da situaçao anterior no ar.*";
			btvctabem.gameObject.SetActive(false);
			btoqseraqaconteceu.gameObject.SetActive(true);
		}
		if (momento == 10) 
		{
			falanpc.text = "*Voce se pergunta: O que sera que aconteceu?*";
			livrinho.gameObject.SetActive(true);
			btoqseraqaconteceu.gameObject.SetActive(false);
			joe.gameObject.SetActive(false);
		}


	}
	public void resposta1()
	{
		if (bttext.text=="Magina. Fico feliz em ajudar!")
		{
			momento = 1;
		}
		if (bttext.text=="A Slibele me mandou vir...")
		{
			momento = 2;
		}
	}
	public void bt2apertado()
	{
		momento = 3;
	}
	public void espreitar()
	{
		momento = 4;
	}
	public void falabaixo()
	{
		momento = 5;
	}
	public void fsilenciocell()
	{
		momento = 6;
	}
	public void vctabem()
	{
		if (txvctabem.text == " Ta! Deixa quieto entao...") 
		{
			momento = 8;
		}

		if (txvctabem.text == "Aconteceu alguma coisa? *Voce arrisca dizer*") 
		{
			momento = 7;
		}
	}
	public void oqseraqueaconteceu()
	{
		momento = 10;
	}


	public void fimpositivo()
	{
			pontosjoe = pontosjoe +1;
			momento = 8;
	}
	public void clicalivro()
	{
		livros = livros - 1;
		Application.LoadLevel ("TransicaoDia2para3");
		
	}
}


