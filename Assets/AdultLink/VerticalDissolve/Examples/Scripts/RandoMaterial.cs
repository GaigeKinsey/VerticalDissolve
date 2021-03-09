using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandoMaterial : MonoBehaviour 
{
	[SerializeField] Material vDissolveMaterial;

	// Use this for initialization
	public void Start () 
	{
		
	}
	
	// Update is called once per frame
	public void Update () 
	{
		
	}

	private void AssignRandomValues()
	{
		Color randomFillColor = new Color(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1));
		vDissolveMaterial.SetColor("_Fillcolor", randomFillColor);

		Color randomRimColor = new Color(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1));
		vDissolveMaterial.SetColor("_Rimlightcolor", randomRimColor);

		vDissolveMaterial.SetFloat("_Rimlightpower", Random.Range(0f, 1f));

		vDissolveMaterial.SetFloat("_Rimlightscale", Random.Range(0f, 1f));
		
		vDissolveMaterial.SetFloat("_Rimlightbias", Random.Range(0f, 1f));

		Color randomBaseColor = new Color(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1));
		vDissolveMaterial.SetColor("_Basecolor", randomBaseColor);
		
		vDissolveMaterial.SetFloat("_Fill", Random.Range(0f, 1f));

		vDissolveMaterial.SetFloat("_Cutoff", Random.Range(0f, 1f));
	}
}
