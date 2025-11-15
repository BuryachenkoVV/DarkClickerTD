using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets._Scripts.Enemies
{
    public class EnemyStats
    {
        [SerializeField] public float physicalResistance = 0f;
        [SerializeField] public float fireResistance = 0f;
        [SerializeField] public float iceResistance = 0f;
        [SerializeField] public float electricResistance = 0f;
        [SerializeField] public float windResistance = 0f;

        [SerializeField]
        public float baseHealth = 40f;
        public float baseSpeed = 2f;

        public float currentHealth;
        public float currentSpeed;

        public int goldReward = 10;
        public float enemyDamage = 3f;
        public int enemyScore = 1;


        public EnemyStats()
        {

        }
        public EnemyStats(float physicalResistance,
            float fireResistance,
            float iceResistance,
            float baseHealth,
            float baseSpeed,
            float currentHealth,
            float currentSpeed,
            int goldReward,
            float enemyDamage,
            int enemyScore)
        {
            this.physicalResistance = physicalResistance;
            this.fireResistance = fireResistance;
            this.iceResistance = iceResistance;
            this.baseHealth = baseHealth;
            this.baseSpeed = baseSpeed;
            this.currentHealth = currentHealth;
            this.currentSpeed = currentSpeed;
            this.goldReward = goldReward;
            this.enemyDamage = enemyDamage;
            this.enemyScore = enemyScore;
        }

    }
}
