using UnityEngine;
using System.Collections;
using System;

public class Player{

	private string firstname;
	private string secondname;
	private string gender;
	private DateTime birthDate;
	private int size;
	private string eyecolor;

	private float neuroticismn;
	private float extraversion;
	private float openness;
	private float conscientiousness;
	private float agreeableness;

	public Player(string firstname, string secondname, string gender,DateTime birthDate, int size, string eyecolor){

		this.firstname = firstname;
		this.secondname = secondname;
		this.gender = gender;
		this.birthDate = birthDate;
		this.size = size;
		this.eyecolor = eyecolor;

		PlayerPrefs.SetString ("firstname", firstname);
		PlayerPrefs.SetString ("surname", secondname);
		PlayerPrefs.SetString ("gender", gender);
		PlayerPrefs.SetString ("birchDate", birthDate.ToString ());
		PlayerPrefs.SetInt ("size", size);
		PlayerPrefs.SetString ("eyecolor", eyecolor);

		PlayerPrefs.SetFloat ("neuroticism", 0.5f);
		PlayerPrefs.SetFloat ("extraversion", 0.5f);
		PlayerPrefs.SetFloat ("openness", 0.5f);
		PlayerPrefs.SetFloat ("conscientiousness", 0.5f);
		PlayerPrefs.SetFloat ("agreeableness", 0.5f);
	
	}

	//Set Methods
	public void Neuroticism(float amount){

		float temp = PlayerPrefs.GetFloat ("neuroticism");
		temp += amount;
		PlayerPrefs.SetFloat ("neuroticism", temp);
	}

	public void Extraversion(float amount){
		
		float temp = PlayerPrefs.GetFloat ("extraversion");
		temp += amount;
		PlayerPrefs.SetFloat ("extraversion", temp);
	}

	public void Openness(float amount){
		
		float temp = PlayerPrefs.GetFloat ("openness");
		temp += amount;
		PlayerPrefs.SetFloat ("openness", temp);
	}

	public void Conscientiousness(float amount){
		
		float temp = PlayerPrefs.GetFloat ("conscientiousness");
		temp += amount;
		PlayerPrefs.SetFloat ("conscientiousness", temp);
	}

	public void Agreeableness(float amount){
		
		float temp = PlayerPrefs.GetFloat ("agreeableness");
		temp += amount;
		PlayerPrefs.SetFloat ("agreeableness", temp);
	}

	//GetMethods
	public float GetNeuroticism(){
		return PlayerPrefs.GetFloat ("neuroticism");
	}

	public float GetExtraversion(){
		return PlayerPrefs.GetFloat ("extraversion");
	}

	public float GetOpenness(){
		return PlayerPrefs.GetFloat ("openness");
	}

	public float GetConscientiousness(){
		return PlayerPrefs.GetFloat ("conscientiousness");
	}

	public float GetAgreeableness(){
		return PlayerPrefs.GetFloat ("agreeableness");
	}
}	
