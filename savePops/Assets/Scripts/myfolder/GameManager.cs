﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

public static int currentScore;
public static int highScore;
public static int currentLevel = 0;
public static int unlockedLevel;

public static void CompleteLevel(){
	if(currentLevel < 1){
		Application.LoadLevel(currentLevel += 1);
	}else{
		print ("You Got Him Girl!");
	}
}
}
