using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    private Controls player;


    void Start()
    {
        player = FindObjectOfType<Controls>();
    }

    public void LeftArrow()
    {
        player.moveright = false;
        player.moveleft = true;
    }
    public void Space()
    {
        player.Space = true;
        
    }
    public void RightArrow()
    {
        player.moveright = true;
        player.moveleft = false;
    }
    public void ReleaseLeftArrow()
    {
        player.moveleft = false;
    }
    public void ReleaseRightArrow()
    {
        player.moveright = false;

    }
    public void Shoot()
    {
        player.Shoot = true;

    }
    public void RealseShoot()
    {
        player.Shoot = false;

    }
}