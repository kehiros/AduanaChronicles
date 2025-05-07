using UnityEngine;
using UnityEngine.UI;

public class TaxCalculator : MonoBehaviour
{
    public InputField fobInput;
    public InputField freightInput;
    public InputField insuranceInput;
    public InputField tariffInput;
    public Text resultText;

    public void CalculateTotal()
    {
        float.TryParse(fobInput.text, out float fob);
        float.TryParse(freightInput.text, out float freight);
        float.TryParse(insuranceInput.text, out float insurance);
        float.TryParse(tariffInput.text, out float tariff);

        float cif = fob + freight + insurance;
        float tariffValue = cif * (tariff / 100f);
        float iva = (cif + tariffValue) * 0.19f;

        float total = cif + tariffValue + iva;

        resultText.text = $"Costo Total: ${total:F2}";
    }
}