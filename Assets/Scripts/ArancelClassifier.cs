using UnityEngine;
using UnityEngine.UI;

public class ArancelClassifier : MonoBehaviour
{
    public Text questionText;
    public Button[] answerButtons;
    public Text resultText;

    [System.Serializable]
    public class Question
    {
        public string description;
        public string[] options;
        public int correctIndex;
    }

    public Question[] questions;

    void Start()
    {
        LoadQuestion(0);
    }

    void LoadQuestion(int index)
    {
        Question q = questions[index];
        questionText.text = q.description;

        for (int i = 0; i < answerButtons.Length; i++)
        {
            int buttonIndex = i;
            answerButtons[i].GetComponentInChildren<Text>().text = q.options[i];
            answerButtons[i].onClick.RemoveAllListeners();
            answerButtons[i].onClick.AddListener(() => CheckAnswer(buttonIndex));
        }
    }

    void CheckAnswer(int selected)
    {
        if (selected == questions[0].correctIndex)
        {
            resultText.text = "¡Correcto!";
            ScoreManager.Instance.AddPoints(10);
        }
        else
        {
            resultText.text = "Incorrecto. Inténtalo de nuevo.";
            ScoreManager.Instance.SubtractPoints(5);
        }
    }
}