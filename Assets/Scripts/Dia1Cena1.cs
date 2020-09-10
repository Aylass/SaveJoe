using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[Serializable]
public class Pergunta{
	
	public int codp;
	public string enunciado;
	public string altA;
	public string altB;
	public string altC;
	public string altD;
	public string altE;
	public string altCorreta;
}


public class Dia1Cena1: MonoBehaviour {
	
	public Text resp1;
	public Text resp2;
	public Text enunciado;
	public Button btresp1;
	public Button btresp2;
	public GameObject livrinho;
	public GameObject paulinho;
	public GameObject saio;
	public GameObject cxtexto;
	public Text falapaulinho;
	public Button A;
	public Button B;
	public Button C;
	public Button D;
	public Button E;
	public Text txA;
	public Text txB;
	public Text txC;
	public Text txD;
	public Text txE;
	Text txcorreta;
	public Button ComoAssim;
	public Text tcomoassim;
	public Button trespontos;
	public Button entrarnaescola;
	public Button falasim;
	public Button falanao;
	public static int livro;
	public Text txtlivro;

   public static int momento; //indica qual deve ser a fala do npc

	//Objeto do tipo Pergunta (a classe que criamos acima)
	Pergunta questao;
	
	//Caminho do script (servidor + nome do arquivo)
	public string url= "http://35.197.20.153/alessandra/CarregarPerguntas.php?area=1";

	
	// Use this for initialization
	void Start () 
	{
		livro = 10;
		txtlivro.text = "Numero de livros: " + livro.ToString();
		falasim.gameObject.SetActive (false);
		falanao.gameObject.SetActive (false);
		livrinho.gameObject.SetActive (false);
		momento = 1; //primeira fala do npc
		entrarnaescola.gameObject.SetActive (false);
		trespontos.gameObject.SetActive (false);
		ComoAssim.gameObject.SetActive (false);
		saio.gameObject.SetActive (false);
		A.gameObject.SetActive (false);
		B.gameObject.SetActive (false);
		C.gameObject.SetActive (false);
		D.gameObject.SetActive (false);
		E.gameObject.SetActive (false);
	}




	// Update is called once per frame
	void Update () 
	{
		Debug.Log (momento);
		if (momento == 1)
		{
			enunciado.text = "E ai? Tudo qualidoso? Bem-vindo ao CETEC! Eu sou Deus, e agora você é um(a) cetequiano(a).";
			resp1.text = "*Permanecer em silêncio*";
			resp2.text = "Oi...! Deus?";	
		}
		if (momento == 2) {
			enunciado.text = "Você é muito quieto! Mas verá que no final da semana você vai ficar mais feliz... Ou não...";
			ComoAssim.gameObject.SetActive (true);
			tcomoassim.text = "Como assim 'ou não'?";
			resp2.text = "";
			resp1.text = "";
			btresp2.gameObject.SetActive (false);
			btresp1.gameObject.SetActive (false);
		}
		if (momento == 3)
		{
			enunciado.text = "Exato! Eu sou o Deus. O todo poderoso. O Senhor da Terra, dos mares... e do CETEC. E agora? Você está pronto para 3 anos na escola...? ou 4...";
			falasim.gameObject.SetActive (true);
			falanao.gameObject.SetActive (true);
			btresp2.gameObject.SetActive (false);
			btresp1.gameObject.SetActive (false);
		}
		if (momento == 4)
		{
			enunciado.text = "Você verá.";
			resp1.text = "";
			resp2.text = "";
			//btresp2.gameObject.SetActive (false);
			//btresp1.gameObject.SetActive (false);
			//ComoAssim.gameObject.SetActive (false);
			trespontos.gameObject.SetActive (true);
			//desaparecevocevera();
		}
		if (momento == 5) 
		{
			cxtexto.gameObject.SetActive (false);
			paulinho.gameObject.SetActive (false);
			enunciado.text = " ";  
		}
		if (momento == 6) 
		{
			desaparece ();
		}

		if (momento == 7)
		{
			enunciado.text = "Por isso que eu odeio aluno.";
			resp1.text = "";
			resp2.text = "";
			btresp2.gameObject.SetActive (false);
			btresp1.gameObject.SetActive (false);
			falanao.gameObject.SetActive (false);
			falasim.gameObject.SetActive (false);
			trespontos.gameObject.SetActive (true);
			//desaparecevocevera();
		}
	
		if (momento == 8)
		{
			enunciado.text = "Entao vai estudar, pequeno meliante!";
			resp1.text = "";
			resp2.text = "";
			btresp2.gameObject.SetActive (false);
			btresp1.gameObject.SetActive (false);
			falanao.gameObject.SetActive (false);
			falasim.gameObject.SetActive (false);
			trespontos.gameObject.SetActive (true);
			//desaparecevocevera();
		}
	}
	
	public void Resposta1 ()
	{
		momento = 2;
	}
	
	public void Resposta2 ()
	{
		momento = 3;
	}

	public void RespostaNao ()
	{
		momento = 7;
	}

	public void Respostacomoassim ()
	{
		momento = 4;
	}

	public void RespostaSim ()
	{
		momento = 8;
	}


	public void trespontinhos()

	{   cxtexto.gameObject.SetActive (false);
		paulinho.gameObject.SetActive (false);
		//btresp2.gameObject.SetActive (false);
		//btresp1.gameObject.SetActive (false);
		//trespontos.gameObject.SetActive(false);
		Entrarnaescola();
		momento = 5;
	}

	public void Entrarnaescola()
	{
		trespontos.gameObject.SetActive (false);
		entrarnaescola.gameObject.SetActive (true);
		//desaparece ();
		momento = 6;

	}


	public void livrinhos ()
	{
		if (momento == 4) 
		{
			livrinho.gameObject.SetActive (true); 
			saio.gameObject.SetActive (false);
			cxtexto.gameObject.SetActive (false);
			//Application.LoadLevel ("Dia1-cena2");
		}
	}

	public void desaparece()
	{
		//StartCoroutine("DBQuerry");
		    trespontos.gameObject.SetActive (false);
		    ComoAssim.gameObject.SetActive (false);
		    cxtexto.gameObject.SetActive (true);
		    entrarnaescola.gameObject.SetActive (false);	
		    saio.gameObject.SetActive (true);
			falapaulinho.text = "Nao tao rapido! antes voce tera que responder a essa pergunta!A PERGUNTA VEM DO BD";
			A.gameObject.SetActive (true);
			B.gameObject.SetActive (true);
			C.gameObject.SetActive (true);
			D.gameObject.SetActive (true);
			E.gameObject.SetActive (true);
			//momento = 9;
	}

	//public IEnumerator DBQuerry()
	//{
		//Novo objeto www 
		//	WWW www = new WWW (url);
		//yield return www;
		
		//Objeto questao recebe a consulta do BD, codificada em JSON
	    //questao = JsonUtility.FromJson<Pergunta> (www.text);
		
		//Printa no console o valor da consulta
		//print (questao.stringQuestao); print (questao.altA); print (questao.altB); print (questao.altC); print (questao.altD); print (questao.altCerta);
		
		//Atribui os valores do objeto questão aos texts da UI
		//falapaulinho.text = questao.enunciado;
		//txA.text = questao.altA;
		//txB.text = questao.altB;
		//txC.text = questao.altC;
		//txD.text = questao.altD;
		//txE.text = questao.altE;
		//txcorreta.text = questao.altCorreta;


	// public void alternativaA
	//{
	//if (txA.text = txcorreta.text) 
	 //{
	//falapaulinho.text = "Parabens, voce acertou! Tome aqui dois livros";
	//livro = livro + 2;
	//txlivro.Text = "Numero de livros: " + livro.ToString();
	// momento = 80;
     //}
	//if (txA.text <> txcorreta.text) 
	//{
	//falapaulinho.text = "E isso que da nao ir nos estruturados :(";
	//livro = livro + 2;
	// momento = 80;
	//}
	//}

	// public void alternativaB
	//{
	//if (txB.text = txcorreta.text) 
	//{
	//falapaulinho.text = "Parabens, voce acertou! Tome aqui dois livros";
	//livro = livro + 2;
	//txlivro.Text = "Numero de livros: " + livro.ToString();
	// momento = 80;
	//}
	//if (txB.text <> txcorreta.text) 
	//{
	//falapaulinho.text = "E isso que da nao ir nos estruturados :(";
	//livro = livro + 2;
	// momento = 80;
	//}
	//}

	// public void alternativaC
	//{
	//if (txC.text = txcorreta.text) 
	//{
	//falapaulinho.text = "Parabens, voce acertou! Tome aqui dois livros";
	//livro = livro + 2;
	//txlivro.Text = "Numero de livros: " + livro.ToString();
	// momento = 80;
	//}
	//if (txC.text <> txcorreta.text) 
	//{
	//falapaulinho.text = "E isso que da nao ir nos estruturados :(";
	//livro = livro + 2;
	// momento = 80;
	//}
	//}

	// public void alternativaD
	//{
	//if (txD.text = txcorreta.text) 
	//{
	//falapaulinho.text = "Parabens, voce acertou! Tome aqui dois livros";
	//livro = livro + 2;
	//txlivro.Text = "Numero de livros: " + livro.ToString();
	// momento = 80;
	//}
	//if (txD.text <> txcorreta.text) 
	//{
	//falapaulinho.text = "E isso que da nao ir nos estruturados :(";
	//livro = livro + 2;
	// momento = 80;
	//}
	//}

	// public void alternativaE
	//{
	//if (txE.text = txcorreta.text) 
	//{
	//falapaulinho.text = "Parabens, voce acertou! Tome aqui dois livros";
	//livro = livro + 2;
	//txlivro.Text = "Numero de livros: " + livro.ToString();
	// momento = 80;
	//}
	//if (txE.text <> txcorreta.text) 
	//{
	//falapaulinho.text = "E isso que da nao ir nos estruturados :(";
	//livro = livro + 2;
	// momento = 80;
	//}
	//}

	public void SAIonara()
	{
		if (momento == 80) 
		{
			A.gameObject.SetActive (false);
			B.gameObject.SetActive (false);
			C.gameObject.SetActive (false);
			D.gameObject.SetActive (false);
			E.gameObject.SetActive (false);
			saio.gameObject.SetActive (false);
			livrinho.gameObject.SetActive(true);
		}
	}
}
