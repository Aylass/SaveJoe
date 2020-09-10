using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dia3cena3 : MonoBehaviour {
	public Text falanpc;
	public static int pontosjoe;
	public static int livro;
	public static int momento;
	public static int ajudoujoe;
	public static int aux;
	public Text stlivros;
	public GameObject livrinho;
	public GameObject joe;
	public GameObject btnaoexatamente;
	public GameObject bttrespontinhos;
	public GameObject btoqvcquerdiser;
	public GameObject bttambemgosto;
	public GameObject btqualquercoisa;
	public GameObject btcont;
	public GameObject bttres;
	public GameObject btpqcomplicado;
	public GameObject btsemplroblemas;
	public GameObject btdurmo;


	// Use this for initialization
	void Start () {
		livro = Dia3cena2.livro;
		stlivros.text = "Numero de livros: " + livro.ToString();
		btdurmo.gameObject.SetActive (false);
		btsemplroblemas.gameObject.SetActive (false);
		btpqcomplicado.gameObject.SetActive (false);
		bttres.gameObject.SetActive (false);
		btcont.gameObject.SetActive (false);
		btqualquercoisa.gameObject.SetActive (false);
		bttambemgosto.gameObject.SetActive (false);
		btoqvcquerdiser.gameObject.SetActive (false);
		bttrespontinhos.gameObject.SetActive (false);
		momento = 0;
		btnaoexatamente.gameObject.SetActive (false);
		livro = Dia3cena2.livro;
		aux = Dia3cena1.aux;
		joe.gameObject.SetActive (false);
		livrinho.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (aux == 0) 
		{
			btnaoexatamente.gameObject.SetActive(true);
			falanpc.text = "Alguém te mandou me seguir agora?";
			joe.gameObject.SetActive (true);
			aux = 3;
		}
	
		if (aux == 1) 
		{
			falanpc.text = "Adoro aqui, é o único lugar onde eu me sinto em paz ultimamente. *Joe começa a colocar os materiais em cima de uma mesa sobre alguns jornais velhos. Realmente, parece que vocês têm muito o que fazer.*";
			joe.gameObject.SetActive (true);
			bttambemgosto.gameObject.SetActive(true);
			aux = 3;
		}
		if (momento == 1) 
		{
			falanpc.text = "Só podia ser mesmo… *Joe diz baixinho, mais para ele mesmo do que para você.*";
			bttrespontinhos.gameObject.SetActive(true);
			btnaoexatamente.gameObject.SetActive (false);
			btoqvcquerdiser.gameObject.SetActive(false);
		}
		if (momento == 2) 
		{
			falanpc.text = "Aqui é o único lugar que eu fico em paz, então, se não for pedir muito, vamos trabalhar duro e acabar logo com isso, ok?” *Joe começa a colocar os materiais em cima de uma mesa. Realmente, parece que vocês têm muito o que fazer.*";
			bttrespontinhos.gameObject.SetActive(false);
			btnaoexatamente.gameObject.SetActive (false);
			btoqvcquerdiser.gameObject.SetActive(true);
		}
		if (momento == 3) 
		{
			falanpc.text = "Hã… Muitas coisas acontecendo, mas nada demais.";
			btqualquercoisa.gameObject.SetActive (true);
			bttambemgosto.gameObject.SetActive(false);
			btoqvcquerdiser.gameObject.SetActive(false);
		}
		if (momento == 4) 
		{
			falanpc.text = "*Joe o observa com cautela*";
			btqualquercoisa.gameObject.SetActive(false);
			btcont.gameObject.SetActive(true);
		}
		if (momento == 5) 
		{
			falanpc.text = "*Joe fica em silêncio, e você faz o mesmo. Por um momento, você pensa que ele não o escutou, mas a forma como Joe remexe nervosamente nos potes de tinta o faz desconsiderar essa hipótese.*";
			bttres.gameObject.SetActive(true);
			btcont.gameObject.SetActive(false);
		}
		if (momento == 6) 
		{
			bttres.gameObject.SetActive(false);
			btpqcomplicado.gameObject.SetActive(true);
			btcont.gameObject.SetActive(false);
			falanpc.text = "*Joe derruba um dos potes de tinta aberto, lambuzando os jornais de amarelo.* Ah! Não precisa! Eu me viro sozinho. Sem falar que em casa fica meio complicado…";
		}
		if (momento == 7) 
		{
			btpqcomplicado.gameObject.SetActive(false);
			btcont.gameObject.SetActive(false);
			falanpc.text = "*Joe hesita um pouco antes de falar. É como se ele estivesse decidindo o quanto podia contar a você.* É que o meu irmão está com alguns problemas e eu vou ficar o resto da semana meio que em função disso.";
			btsemplroblemas.gameObject.SetActive(true);
		} if (momento == 8) 
		{
			falanpc.text = "Mas… vai ficar muito tarde para você voltar para casa depois…";
			btsemplroblemas.gameObject.SetActive(false);
			btdurmo.gameObject.SetActive(true);
		}
		if (momento == 9) 
		{
			falanpc.text = "*Apesar de não ter dito nada enquanto você acenava em despedida, Joe pareceu desconfortável com toda a situação. Enquanto caminha pelos corredores vazios, você tenta se convencer de que está tudo bem agora que você fez a sua parte para ajudar.*";
			btdurmo.gameObject.SetActive(false);
			joe.gameObject.SetActive(false);
			livrinho.gameObject.SetActive(true);
		}
	}
	public void naoexdatamente()
	{
		momento = 1;
	}
	public void trespontinhos()
	{
		momento = 2;
	}
	public void qualquercoisa()
	{
		momento = 4;
	}
	public void preto()
	{
		momento = 3;
	}
	public void silencio ()
	{
		momento = 5;
	}
	public void dpssilencio()
	{
		momento = 6;
	}
	public void pqcomplicado()
	{
		momento = 7;
	}
	public void semploblema()
	{
		momento = 8;
	}
	public void durmo ()
	{
		momento = 9;
	}
	public void livrinhos()
	{
		livro = livro - 1;
		Application.LoadLevel("Dia3-cena4");
	}
}
