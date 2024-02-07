using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{ private Rigidbody rb;

    private bool touch;

    [SerializeField]
    private float maxSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TouchCheck();
        SpeedCheck();
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = new Vector3(0, 5, 0);
}
    private void OnCollisionStay(Collision collision)
    {
        if (!touch)
        {
            rb.velocity = new Vector3(0, 5, 0);
        }
        
    }

    /// <summary>
    /// マウスが押されているときにプレイヤーを下に動かす。
    /// </summary>
    void TouchCheck()
    {
        if(Input.GetMouseButton(0))
        {
            touch = true;
            rb.velocity = new Vector3(0, -100 * Time.fixedDeltaTime*7, 0);
        }
        if(Input.GetMouseButtonUp(0))
        {
            touch = false;
        }

    }

    /// <summary>
    /// 移動速度確認して調整
    /// </summary>
    void SpeedCheck()
    {
        if (rb.velocity.y > maxSpeed)
        {
            rb.velocity = new Vector3(rb.velocity.x, maxSpeed, rb.velocity.z);
        }

    }



}
