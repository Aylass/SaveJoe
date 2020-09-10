using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dia3cena6 : MonoBehaviour {
	
	public Text falanpc;
	public static int pontosjoe;
	public static int livro;
	public static int momento;
	public Text stlivros;
	public GameObject livrinho;
	public GameObject bttrespontinhos;
	public GameObject peca;
	public GameObject btvoceficanervoso;
	public GameObject teatro;
	public GameObject btvaidarruim;
	public GameObject joe;
	public GameObject btoquefoi;
	public GameObject btnaosepreocupe;
	public GameObject bttriste;
	public GameObject bttodosolham;
	public GameObject btcaradepaisagem;
	public GameObject bttrespontinhos2;
	public GameObject juliana;
	public GameObject btjoevaiembora;

	// Use this for initialization
	void Start () {
		
		livro = Dia3cena5.livro;
		stlivros.text = "Numero de livros: " + livro.ToString();
		momento = 0;
		livrinho.gameObject.SetActive (false);
		peca.gameObject.SetActive (false);
		btvoceficanervoso.gameObject.SetActive(false);
		btvaidarruim.gameObject.SetActive(false);
		joe.gameObject.SetActive(false);
		btoquefoi.gameObject.SetActive(false);
		btnaosepreocupe.gameObject.SetActive(false);
		bttriste.gameObject.SetActive(false);
		bttodosolham.gameObject.SetActive(false);
		btcaradepaisagem.gameObject.SetActive (false);
		bttrespontinhos2.gameObject.SetActive (false);
		juliana.gameObject.SetActive(false);
		btjoevaiembora.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (momento == 0) 
		{
			falanpc.text = "*Depois de arrumar o cenário no palco, a peça está pronta para começar. Os alunos correm para seus lugares atrás das cortinas, enquanto o locutor anuncia a sinopse da peça.*";
			
		}
		if (momento == 1) 
		{
			bttrespontinhos.gameObject.SetActive(false);
			btvoceficanervoso.gameObject.SetActive(true);
			falanpc.text = "Locutor: A sociedade contemporânea, a qual muitos definem como pós-moderna, é uma sociedade caracterizada por um discurso polissêmico, dito de outra forma, não há sentido próprio ao ser, tampouco à vida. Desse modo, cabe ao indivíduo a busca por aquilo que o defina e, consequentemente, sirva-lhe de norte, dada à sua extrema liberdade. Com vocês, a turma A03!";

			
		}
		if (momento == 2) 
		{
			btvoceficanervoso.gameObject.SetActive(false);
			teatro.gameObject.SetActive(false);
			peca.gameObject.SetActive(true);
			falanpc.text = "*A peça começa e todos parecem estar adorando. Tudo está ocorrendo perfeitamente conforme o planejado: todos atuando bem e falando com conviccção. Até que de repente...*";
			btvaidarruim.gameObject.SetActive(true);
		}

		if (momento == 3) 
		{
			joe.gameObject.SetActive(true);
			btvaidarruim.gameObject.SetActive(false);
			falanpc.text = "*Joe fala com você das coxias* Ai meu Deus... Olha aquilo! *ele aponta para as setas penduradas na barra*";
			btoquefoi.gameObject.SetActive(true);
		}

		if (momento == 4) 
		{
			btoquefoi.gameObject.SetActive(false);
			falanpc.text = "A gente prendeu as setas muito mal... espero que elas resistam...";
			btnaosepreocupe.gameObject.SetActive(true);
		}

		if (momento == 5) 
		{
			falanpc.text = "*Apesar de ter tentado tranquilizar Joe, você não estava tranquilo. As setas estavam realmente muito mal colocadas, e aprecia que elas poderiam desabar a qualquer momento. E, para a sua infelicidade, esse momento chegou.*";
			btnaosepreocupe.gameObject.SetActive(false);
			bttriste.gameObject.SetActive(true);
		}

		if (momento == 6) 
		{
			falanpc.text = "*Joe cochicha desesperado:* O CENÁRIO TÁ CAINDO!";
			bttriste.gameObject.SetActive(false);
			bttodosolham.gameObject.SetActive(true);
		}

		if (momento == 7) 
		{
			falanpc.text = "*Duas das oito setas despencam no chão. Ouve-se uma exclamação de surpresa vinda da platéia, e algumas pessoas no palco gritam e correm para que o cenário não caia sobre suas cabeças.*";
			bttodosolham.gameObject.SetActive(false);
			btcaradepaisagem.gameObject.SetActive(true);
		}

		if (momento == 8) 
		{
			falanpc.text = "Seus colegas começam a correr na direção de vocês, e a maioria deles não parece nada feliz. *";
			btcaradepaisagem.gameObject.SetActive(false);
			bttrespontinhos2.gameObject.SetActive(true);
		}

		if (momento == 9) 
		{
			juliana.gameObject.SetActive(true);
			falanpc.text = "Juliana: O QUE HOUVE COM O CENÁRIO JOE? - Joe: Eu.. Eu não sei... - Juliana: E agora ficamos sem cenário e provavelmente sem nota por culpa sua! - Joe: Desculpa...";
			bttrespontinhos2.gameObject.SetActive(false);
			btjoevaiembora.gameObject.SetActive(true);
		}

		if (momento == 10) 
		{
			falanpc.text = "";
			btjoevaiembora.gameObject.SetActive(false);
			juliana.gameObject.SetActive(false);
			joe.gameObject.SetActive(false);
			livrinho.gameObject.SetActive(true);
		}
		
	}
	
	public void trespontinhos()
	{
		momento = 1;
	}
	
	public void voceficanervoso()
	{
		momento = 2;
	}

	public void vaidarruim()
	{
		momento = 3;
	}

	public void oquefoi()
	{
		momento = 4;
	}

	public void naosepreocupe()
	{
		momento = 5;
	}

	public void triste()
	{
		momento = 6;
	} 

	public void todosolham()
	{
		momento = 7;
	} 

	public void caradepaisagem()
	{
		momento = 8;
	} 

	public void trespontinhos2()
	{
		momento = 9;
	} 

	public void Joevaiembora()
	{
		momento = 10;
	} 


	public void livrinhos()
	{
		livro = livro - 1;
		Application.LoadLevel("Dia3-cena62");
	}
}
