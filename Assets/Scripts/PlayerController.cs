using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public GameObject button;
    public TextMeshProUGUI score_count;
    public Rigidbody rb;
    public float jumpVelocity = 10;
    public float velocity;
    public int score = 0;

    public void SetScore(int new_score)
    {
        score_count.text = "Score: " + new_score.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        SetScore(score);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            rb.velocity = jumpVelocity * Vector3.up;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(velocity, 0, 0)*Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            gameObject.SetActive(false);
            button.SetActive(true);

        }
        if (other.gameObject.CompareTag("Trigger"))
        {
            score++;
            SetScore(score);
        }
    }
}
