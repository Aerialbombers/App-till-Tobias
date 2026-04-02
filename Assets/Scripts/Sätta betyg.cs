using UnityEngine;

public class Betyg : MonoBehaviour
{
    [SerializeField] private GameObject betyg;
    [SerializeField] private GameObject hem;
    [SerializeField] private Animator animator;

    public void SättBetyg()
    {

        betyg.SetActive(true);
        hem.SetActive(false);
        animator.SetTrigger("PlayAnimation");
    }

    public void DöljBetyg()
    {
        betyg.SetActive(false);
        hem.SetActive(true);
    }
}
