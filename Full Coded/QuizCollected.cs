﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizCollected : MonoBehaviour {
	
	public static int QuizAmount;
	Text text;
	
	void Start () {
		text = GetComponent<Text>();
	}
	
	void Update () {
		text.text = QuizAmount.ToString();
	}
}
