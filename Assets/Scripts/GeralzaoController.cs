using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class GeralzaoController : MonoBehaviour {
	public static string slivro;
	public static int livro;
	public Text txtlivro;
	public static int pontosjoe;


	// Use this for initialization
	void Start () {

		livro = 10;
		//slivro = "Numero de livros: " + livro.ToString();
//		txtlivro.text = slivro;
		pontosjoe = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
