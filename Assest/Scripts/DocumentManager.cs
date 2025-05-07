using UnityEngine;
using UnityEngine.UI;

public class DocumentManager : MonoBehaviour
{
    public Toggle[] requiredDocuments;
    public Text statusText;

    public void CheckDocuments()
    {
        bool allChecked = true;
        foreach (var doc in requiredDocuments)
        {
            if (!doc.isOn)
            {
                allChecked = false;
                break;
            }
        }

        if (allChecked)
        {
            statusText.text = "✅ Todos los documentos están completos.";
            ScoreManager.Instance.AddPoints(5);
        }
        else
        {
            statusText.text = "❌ Faltan documentos obligatorios.";
            ScoreManager.Instance.SubtractPoints(3);
        }
    }
}