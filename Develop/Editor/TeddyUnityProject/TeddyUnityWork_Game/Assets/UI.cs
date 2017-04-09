using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour {
    public GameObject aa;
    private GameObject m_g;

    private void Awake() {
        if (m_g == null) {
            m_g = Instantiate(aa);
        }
    }
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}