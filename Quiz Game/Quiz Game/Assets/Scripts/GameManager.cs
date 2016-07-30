using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class GameManager : MonoBehaviour {

	public question[] questions;
	public static List<question> unansweredQuestions;

	private question currentQuestion;

	void Start()
	{
		if (unansweredQuestions == null || unansweredQuestions.Count == 0) {
			unansweredQuestions = questions.ToList<question> ();
		}

		GetRandomQuestion ();
		Debug.Log (currentQuestion.fact + "  " + currentQuestion.isTrue);
	}

	void GetRandomQuestion()
	{
		int randomQuestionsIndex = Random.Range (0,unansweredQuestions.Count);
		currentQuestion = questions [randomQuestionsIndex];

		unansweredQuestions.RemoveAt (randomQuestionsIndex);
	}
}
