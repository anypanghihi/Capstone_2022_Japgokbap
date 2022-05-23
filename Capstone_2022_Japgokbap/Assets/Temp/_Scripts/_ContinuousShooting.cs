using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ContinuousShooting : Skill
{
    [SerializeField] private float skillDuration;
    [SerializeField] private float DestoryTime;


    private void Start() {
        StopCoroutine(DoSkill());
        StartCoroutine(DoSkill());

    }
    
    public override IEnumerator DoSkill()
    {
        PlayerController.lockBehaviour = true;
        yield return new WaitForSeconds(skillDuration);
        //playerAnimator.SetTrigger("doSlash");

        GameObject test1 = Instantiate(skillPrefab, playerTransform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        GameObject test2 = Instantiate(skillPrefab, playerTransform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        GameObject test3 = Instantiate(skillPrefab, playerTransform.position, Quaternion.identity);
        
        //GameObject spawnParticle = Instantiate(skillParticle, playerTransform.position + playerTransform.forward, playerTransform.rotation);

        // instantePrefab.transform.parent = this.transform;
        //spawnParticle.transform.parent = this.transform;

        
        PlayerController.lockBehaviour = false;

        Destroy(this.gameObject, DestoryTime);
    }
}
