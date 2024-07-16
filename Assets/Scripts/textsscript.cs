using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class textsscript : MonoBehaviour
{
    public Text textComponent; // Renk geçişi yapacağımız Text bileşeni
    public float duration = 5.0f; // Geçişin süresi

    void Start()
    {
        // Coroutine başlat
        StartCoroutine(ChangeColorOverTime());
    }

    IEnumerator ChangeColorOverTime()
    {
        Color startColor = Color.Lerp(Color.black, Color.red, 0.5f); // Turuncu rengi belirle
        Color endColor = Color.black; // Siyah rengi belirle

        float elapsedTime = 0.0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;
            textComponent.color = Color.Lerp(startColor, endColor, t);
            yield return null;
        }

        textComponent.color = endColor; // Geçiş tamamlandığında siyah rengi ayarla
    }
}
