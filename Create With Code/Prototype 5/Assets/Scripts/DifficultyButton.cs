using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

private Button button

public class DifficultyButton : MonoBehaviour
{
	private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
		DifficultyButton = GetComponent<Button>();
		DifficultyButton.onClick.AddListener(SetDifficulty);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty()
	{
		Debug.Log(gameObject.name + " was clicked");
		gameManager.startGame();
	}
}
