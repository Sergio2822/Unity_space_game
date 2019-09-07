using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public Transform Bullet;
    public Transform CannonPosition;
    public Slider SliderValue;
    public int Score;

    public Text ScoreText;
    public float timeLeft;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        UpdateTimer();
        ScoreText.text = "Marcador:" + Score;
        SliderValue.value = 80;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        gameObject.transform.Translate(new Vector3(0.5f * h, 0.5f * v, 0));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(Bullet, CannonPosition.position, Quaternion.identity);
    }
    void FixedUpdate()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;
        }
        UpdateTimer();
    }
    void UpdateTimer()
    {
        timerText.text = "Time Left... " + Mathf.RoundToInt(timeLeft);
    }
    void OnTriggerEn2D(Collider2D other)
    {
        SliderValue.value = SliderValue.value -5;
    }
}
