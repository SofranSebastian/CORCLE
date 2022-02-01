using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPS : MonoBehaviour
{
    public ParticleSystem dust;
    
    public void createDust(){
        dust.Play();
    }
}
