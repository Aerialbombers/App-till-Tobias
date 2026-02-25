using UnityEngine;

public class Betyg : MonoBehaviour
{
    [SerializeField] private GameObject betyg;

    public void SattBetyg()
    {
        if (betyg == null)
        {
            Debug.LogError("Betyg-objektet är inte tilldelat i Inspector!", this);
            return;
        }
        betyg.SetActive(true);
    }

    public void DoljeBetyg()
    {
        if (betyg == null)
        {
            Debug.LogError("Betyg-objektet är inte tilldelat i Inspector!", this);
            return;
        }
        betyg.SetActive(false);
    }
}
