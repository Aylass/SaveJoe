using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tutorialscript : MonoBehaviour {
	
	
	public Button nextist;
	public Button backist;
	public Text instrucao;
	public int momento; 
	
	// Use this for initialization
	void Start () 
	{
		momento = 1;
		backist.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
    void Update () 
	{
		if (momento == 1) 
		{
			instrucao.text = "Utilize o seu  mouse para jogar.Você pode se locomover pela escola clicando em cima dos livrinhos que aparecem no canto da tela em cada cenário.Os livros representam seu movimento. Após o uso, o livro é gasto. ";
			backist.gameObject.SetActive (false);
		}
		if (momento == 2)
		{
			backist.gameObject.SetActive (true);
			instrucao.text = "Você ganha livros respondendo corretamente as perguntas feitas pelos professores durante o jogo. Se você ficar sem livros, você pode conseguir mais respondendo a perguntas extras que podem ser acessadas através do botão SOS que aparece nas tela durante o jogo.";
			
		}
		if (momento == 3)
		{
			instrucao.text = "Durante o jogo, você deve se preocupar também em marcar 'Pontos do Joe'. Essa pontuação é indica a sua afinidade com o personagem, a qual determina diferentes finais para o jogo. Lembre-se que a sua pontuação respondendo as perguntas também pode levar a finais diferentes: passar ou não no vestibular.";	
		}
		if (momento == 4)
		{
			instrucao.text = "Está Pronto? Aperte o botão 'Next' para iniciar o jogo!";
		}
	}

	public void Next()
	{ 
		Debug.Log ("entrou");
		momento = momento+1;
		if (momento == 5)
		{
			Application.LoadLevel ("Dia1-cena1");
		}

	}

	public void Back()
	{ 
		Debug.Log ("entrou");
		momento = momento-1;
		if (momento <= 1)
		{
			momento = 1;
		}
		
	}

}