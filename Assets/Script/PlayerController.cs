using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerController : MonoBehaviour {

    public GameObject panel;
   
    //VARIABEL TINGGI LOMPATAN
    public Vector2 m_JumpForce = new Vector2(0, 150);

    //FILE AUDIO
    public AudioClip m_AudioHit;
    public AudioClip m_AudioCoin;
    public AudioClip m_AudioSwing;

    //PRIVATE MEMBER
    private Rigidbody2D m_RigidBody;
    private AudioSource m_AudioSource;
    private bool isFirstJump = true;
    private bool isSoundOn = true;
    void Start()
    {
        
        panel.SetActive(false);
        //INISIAL RIGIDBODY
        m_RigidBody = GetComponent<Rigidbody2D>();
        //INISIAL AUDIOSOURCE
        m_AudioSource = GetComponent<AudioSource>();

        //MATIKAN EFEK GRAVITASI
        m_RigidBody.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {

        //JIKA MOUSE KIRI DI KLIK 0
        if (Input.GetMouseButtonDown(0))
        {
            m_RigidBody.isKinematic = false;
            m_RigidBody.velocity = Vector2.zero;
            m_RigidBody.AddForce(m_JumpForce);
        }
        //JIKA VELOCITY LEBIH BESAR DARI 0
        if (m_RigidBody.velocity.y > 0)
        {
            float angle = Mathf.Lerp(transform.rotation.z, 90, (-m_RigidBody.velocity.y / 3f) * Time.deltaTime * 25);
            //PUTAR 90 DERAJAT
            transform.rotation = Quaternion.Euler(0, 0, 0);
        } //JIKA TIDAK
        else
        {
            float angle = Mathf.Lerp(0, -90, (-m_RigidBody.velocity.y / 3f) * Time.deltaTime * 25);
            //PUTAR -90 DERAJAT
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("menabrak " + other.gameObject.name);
        Die();
    }
    void Die()
     {
        Time.timeScale = 0;
        panel.SetActive(true);
    }
    void OnTriggerEnter2D()
    {
        Score.score += 1;
    }
}
