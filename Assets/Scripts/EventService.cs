﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace TankGame.Event
{
    public class EventService : MonoSingletonGeneric<EventService>
    {
        public event Action PlayerSpawn;
        public event Action<int> EnemyDeath;
        public event Action<int> EnemyKillAchievment;
        public event Action<int> BulletAchievment;
        public event Action<int> PlayerDeath;


        public void OnPlayerSpawn()
        {
            PlayerSpawn?.Invoke();
        }

        public void OnPlayerDeath(int deathCount)
        {
            PlayerDeath?.Invoke(deathCount);
        }

        public void OnEnemyDeath(int deathCount)
        {
            EnemyDeath?.Invoke(deathCount);
        }
        public void OnBulletAchievment(int bulletCount)
        {
            BulletAchievment?.Invoke(bulletCount);
        }

        public void OnEnemyKillAchievment(int deathCount)
        {
            EnemyKillAchievment?.Invoke(deathCount);
        }
       

    }
}