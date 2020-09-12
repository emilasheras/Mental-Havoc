using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    [Header("Starting time of each run")]
    [SerializeField]
    private float startTime = 30.00f;
    [Header("Text gameObject used")]
    [SerializeField]
    private Text timerText;
    private float time;
    private float unspentTime;

    void Start() {
        // float to text translation
        timerText.text = startTime.ToString("F2").Replace(",","."); 
        time = startTime;   // give the time to another private var  
    }
    void LateUpdate() {
        time -= Time.deltaTime;
        timerText.text = time.ToString("F2").Replace(",","."); // F2 is two values after the decimal part
    }

    public void addTime(){
        //  This function adds the remaining time that wasnt spent on a level in case we need it.
        unspentTime = time;
        time = startTime + unspentTime;     // ej: x = 30.00s + 8.34s = 38.34s
        
    }

}