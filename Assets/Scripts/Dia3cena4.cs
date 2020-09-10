using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dia3cena4 : MonoBehaviour {
	public Text falanpc;
	public static int pontosjoe;
	public static int livro;
	public static int momento;
	public static int ajudoujoe;
	public static int aux;
	public Text stlivros;
	public GameObject livrinho;
	public GameObject joe;
	public GameObject pais;
	public GameObject btprocurando;
	public GameObject bttres;
	public GameObject bterror;
	public GameObject bttrespontinhos;
	// Use this for initialization
	void Start () 
	{
		livro = Dia3cena3.livro;
		stlivros.text = "Numero de livros: " + livro.ToString();
		bttrespontinhos.gameObject.SetActive (false);
		bterror.gameObject.SetActive (false);
		bttres.gameObject.SetActive (false);
		btprocurando.gameObject.SetActive (false);
		pais.gameObject.SetActive (false);
		momento = 0;
		joe.gameObject.SetActive (false);
		livrinho.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (momento == 0) 
		{
			falanpc.text = "*Chegando com os seus pais no teatro, você avista Joe de longe e tenta chamar a atenção dele. Como não consegue que ele olhe na sua direção, você vai até ele com os seus pais logo atrás.*";
			btprocurando.gameObject.SetActive(true);
			joe.gameObject.SetActive(true);
		}
		if (momento == 1) 
		{
			btprocurando.gameObject.SetActive(false);
			pais.gameObject.SetActive(true);
			bttres.gameObject.SetActive(true);
			falanpc.text = "Sua mãe: Oi, Joe! Ouvimos muito falar de você! *Sua mãe olha em volta, procurando pela família de Joe.* Nós guardamos lugar no teatro, onde estão seus pais?";
		}
        if (momento == 2)
        {
            falanpc.text = "Joe: Ah… *Joe parece ficar sem jeito, a voz hesitante e um pouco trêmula.* Minha mãe não pôde vir… Ela está com o meu irmão e não vai aparecer hoje."; 
			bttres.gameObject.SetActive(false);
			btprocurando.gameObject.SetActive(false);
			bterror.gameObject.SetActive(true);
        }
		if (momento == 3) 
		{
			falanpc.text = "*A professora Lili grita chamando os alunos. Voce e Joe se despedem de seus pais e vão em direcao ao camarim.*";
			bterror.gameObject.SetActive(false);
			btprocurando.gameObject.SetActive(false);
			bttrespontinhos.gameObject.SetActive(true);
		
		}
	
		if (momento == 4) 
		{
			falanpc.text = "";
			joe.gameObject.SetActive(false);
			pais.gameObject.SetActive(false);
			livrinho.gameObject.SetActive(true);
			bttrespontinhos.gameObject.SetActive(false);
			
		}
	}
	public void mae()
	{
		momento = 1;
	}
    public void tres()
    { 
        momento = 2;  
    } 
	public void error()
	{
		momento = 3;
	}

	public void trespontinhos()
	{
		momento = 4;
	} 

	public void livrinhos()
	{
		livro = livro - 1;
		Application.LoadLevel("Dia3-cena5");
	}
}
