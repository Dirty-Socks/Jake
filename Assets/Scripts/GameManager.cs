using UnityEngine;
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

	public void StartGame () {
		SetGameState (GameState.inGame);
		PlayerController.instance.StartGame ();
	}

	public void GameOver () {
		SetGameState (GameState.gameOver);
	}

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

	void Update () {
		if (Input.GetButtonDown("s")){
			StartGame ();
		}
	}
}
