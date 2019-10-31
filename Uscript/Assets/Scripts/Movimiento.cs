using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 direccion;
    public float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direccion = ClampVector3(direccion);
        transform.Translate(direccion * (speed * Time.deltaTime));
    }
    public Vector3 ClampVector3(Vector3 target) {
        float clampedX = Mathf.Clamp(target.x, -1f, 1f);
        float clampedY = Mathf.Clamp(target.y, -1f, 1f);
        float clampedZ = Mathf.Clamp(target.z, -1f, 1f);
        Vector3 result = new Vector3(clampedX, clampedY, clampedZ);
        return result;
}
}
