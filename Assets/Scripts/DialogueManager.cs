using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    public GameObject dialogueBox;
    private int currentLine = 0;
    private string[] lines;

    public void StartDialogue(string[] dialogueLines)
    {
        lines = dialogueLines;
        currentLine = 0;
        dialogueBox.SetActive(true);
        dialogueText.text = lines[currentLine];
    }

    public void NextLine()
    {
        currentLine++;
        if (currentLine < lines.Length)
        {
            dialogueText.text = lines[currentLine];
        }
        else
        {
            dialogueBox.SetActive(false);
        }
    }
}