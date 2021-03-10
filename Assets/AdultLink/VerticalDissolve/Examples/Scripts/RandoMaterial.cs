using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandoMaterial : MonoBehaviour 
{
	[SerializeField] Material vDissolveMaterial;
	public float matMin;
	public float matMax;

	// Use this for initialization

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
		{
			AssignRandomValues();
		}
	}

	public void AssignRandomValues()
	{
		Color randomFillColor = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
		vDissolveMaterial.SetColor("_Fillcolor", randomFillColor);

		Color randomRimColor = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
		vDissolveMaterial.SetColor("_Rimlightcolor", randomRimColor);

		vDissolveMaterial.SetFloat("_Rimlightpower", Random.Range(-1f, 1f));

		vDissolveMaterial.SetFloat("_Rimlightscale", Random.Range(0f, 10f));
		
		vDissolveMaterial.SetFloat("_Rimlightbias", Random.Range(-20f, 20f));

		Color randomBaseColor = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
		vDissolveMaterial.SetColor("_Basecolor", randomBaseColor);
		
		vDissolveMaterial.SetFloat("_Fill", Random.Range(matMin, matMax));

		vDissolveMaterial.SetFloat("_Cutoff", Random.Range(0f, 1f));

		Vector4 randVec = new Vector4(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-2f, 2f));
		vDissolveMaterial.SetVector("_Noisetexspeed", randVec);
		
		Vector4 randNoiseVec = new Vector4(Random.Range(-5f, 5f), Random.Range(-.5f, .5f), Random.Range(-.5f, .5f), Random.Range(-2f, 2f));
		vDissolveMaterial.SetVector("_Noisespeed", randNoiseVec);

		vDissolveMaterial.SetFloat("_Enablerimlight", Random.Range(0f, 1f));

		vDissolveMaterial.SetFloat("_Borderwidth", Random.Range(0f, 4f));

		Color randomBorderColor = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
		vDissolveMaterial.SetColor("_Bordercolor", randomBorderColor);

		vDissolveMaterial.SetFloat("_Noisescale", Random.Range(0f, .5f));
		vDissolveMaterial.SetFloat("_Layernoise", Random.Range(0f, 20f));

		vDissolveMaterial.SetFloat("_Tintinsidecolor", Random.Range(0f, 1f));
		vDissolveMaterial.SetFloat("_Activateemission", Random.Range(0f, 1f));

		//set wave settings
		vDissolveMaterial.SetFloat("_Wave1amplitude", Random.Range(0f, 1f));
		vDissolveMaterial.SetFloat("_Wave1frequency", Random.Range(0f, 50f));
		vDissolveMaterial.SetFloat("_Wave1offset", Random.Range(0f, 10f));

		vDissolveMaterial.SetFloat("_Wave2amplitude", Random.Range(0f, 1f));
		vDissolveMaterial.SetFloat("_Wave2Frequency", Random.Range(0f, 50f));
		vDissolveMaterial.SetFloat("_Wave2offset", Random.Range(0f, 10f));

	}
}
