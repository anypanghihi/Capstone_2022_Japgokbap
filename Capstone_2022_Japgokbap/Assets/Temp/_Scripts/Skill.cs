using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : MonoBehaviour {
    protected float realtime = 0.0f;
    protected Animator playerAnimator;
    protected Transform playerTransform;
    public SkillSO skillSO;
    public int skillDamage;
    [SerializeField] protected GameObject skillPrefab;
    [SerializeField] protected GameObject skillParticle;

    private void Awake(){
        playerTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
        playerAnimator = GameObject.FindWithTag("Player").GetComponent<Animator>();
        skillDamage = skillSO.baseDamage;
    }
    

    public void CoolTimeCheck(float skillCooltime)
    {
        if (!skillSO.coolCheck) {
            if (realtime <= skillCooltime) {
                realtime += Time.deltaTime;
            } else {
                skillSO.coolCheck = true;
                realtime = 0.0f;
            }
        }
    }
    public abstract IEnumerator DoSkill();
//    protected abstract void OnTriggerEnter(Collider other);
    // protected void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log(other.tag);
    //     if(other.CompareTag("Monster")){
    //         // skillDamage = skillDamage + skillLevel;
    //         Debug.Log(skillDamage);
    //         other.SendMessage("GetDamaged", skillDamage);
    //     }
    //     else return;
    // }
}