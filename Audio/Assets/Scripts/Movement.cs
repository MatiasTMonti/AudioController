using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;

    private string position = "position";

    private Rigidbody rb;

    private float mH;
    private float mV;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        Vector3 pos = rb.position;

        if (PlayerPrefs.HasKey(position))
            pos.z = PlayerPrefs.GetFloat(position);

        rb.position = pos;
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        mH = Input.GetAxis("Horizontal");
        mV = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(mH * speed, rb.velocity.y, mV * speed) * Time.deltaTime;
    }

    public string GetPos()
    {
        return position;
    }
}
