using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorTrigger : MonoBehaviour
{
    
    public tileManager tileManager;
    public Timer tm;
    int oldTunnel = 0;

    int tunnel_count = 3;

    private void OnTriggerEnter(Collider other) {

        if(other.gameObject.tag == "Road"){

            //inital desert road tiles
                if(tm.tunnel_cnt==0)
                tileManager.spawnTile(Random.Range(1, 7));



            // desert road to forest tunnel genration
            else if(tm.tunnel_cnt==1 && tm.tunnel_cnt!=oldTunnel){

                if(tunnel_count>1)
                    {tileManager.spawnTile(7);tunnel_count--;}
                else if(tunnel_count==1)
                    {tileManager.spawnTile(13);tunnel_count--;}
                if(tunnel_count==0){
                    oldTunnel=tm.tunnel_cnt;
                    tunnel_count=3;
                }
            }


            //forest road tiles
            else if(tm.tunnel_cnt==1)tileManager.spawnTile(Random.Range(8, 13));


            // forest road to snow tunnel generation
            else if(tm.tunnel_cnt==2 && tm.tunnel_cnt!=oldTunnel){
                
                if(tunnel_count>1)
                    {tileManager.spawnTile(13);tunnel_count--;}
                else if(tunnel_count==1)
                    {tileManager.spawnTile(17);tunnel_count--;}
                if(tunnel_count==0){
                    oldTunnel=tm.tunnel_cnt;
                    tunnel_count=3;
                }
            }


            // snow tile 
            else if(tm.tunnel_cnt==2)tileManager.spawnTile(Random.Range(14, 17));


            // edge case
            else tileManager.spawnTile(Random.Range(14, 17));


            tileManager.deleteTile();  
            }
    }
}
