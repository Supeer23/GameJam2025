using System.Collections;
using UnityEngine;

public class timeManager : MonoBehaviour
{
    [SerializeField] private float timeMult;
    [SerializeField] private float mult;

    IEnumerator updateDifMult(){
        while (true) {
            yield return new WaitForSeconds(timeMult);
            mult += 2f;
        }

    }
    
}
