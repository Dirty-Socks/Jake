﻿using UnityEngine;
using System.Collections;

public enum GameState
{
	menu,
	inGame,
	gameOver
}

public class GameManager : MonoBehaviour {

	public GameState currentGameState = GameState.menu;
	public static GameManager instance;

	void Awake () {
		instance = this;
	}

	void Start () {
		currentGameState = GameState.menu;
	}

	void Update () {
		if (Input.GetButtonDown("s")){
			StartGame ();
		}
	}

	// Use this for initialization
	public void StartGame () {
		SetGameState (GameState.inGame);
	}

	public void GameOver () {
		SetGameState (GameState.gameOver);
	}
	
	// Update is called once per frame
	public void BackToMenu () {
		SetGameState (GameState.menu);
	}

	void SetGameState (GameState newGameState) {
		if (newGameState == GameState.menu) {

		} else if (newGameState == GameState.inGame) {

		} else if (newGameState == GameState.gameOver) {

		}

		currentGameState = newGameState;
	}
}
