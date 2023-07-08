using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilitieshealer : MonoBehaviour
{
    public int healcount;
    public int healamount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ///if ally is within 2 squares then....
        Healthbar b = gameObject.GetComponent<Healthbar>(); //for the ally...
        int maxhp = b.getmaxhp();
        if (b.gethp() >= maxhp / 2)
        {
            if (healcount > 0)
            {
                healcount--;
                b.updatehp(healamount);
            }
        }
        else
        {
            Enemycard e = gameObject.GetComponent<Enemycard>();
            //the rest of the def up has to be handled in the turn handler


        }
        //else if there are no allies nearby, find the closest ally and move towards them.

    }
}
