using System;
using System.Collections.Generic;
using System.Reflection;
using _Game.Scripts.Architecture.MVC.Model;
using _Game.Scripts.Architecture.MVC.Model.Factory;
using UnityEngine;
using Zenject;

namespace _Game.Scripts.Architecture.MVC
{
    public abstract class MVCHandlerBase : MonoBehaviour
    {
        protected List<AggregatorBase> AggregateBases { get; } = new();

        [Inject]
        protected virtual void InjectMe(DiContainer container)
        {
            var fieldInfos = GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var fieldInfo in fieldInfos)
            {
                if (fieldInfo.FieldType.IsSubclassOf(typeof(AggregatorBase)))
                {
                    var aggreator = fieldInfo.GetValue(this) as AggregatorBase;
                    AggregateBases.Add(aggreator);
                }
            }
            
            foreach (var aggregateBase in AggregateBases)
            {
                container.Inject(aggregateBase);
            }
        }

        protected void ActivateMVCs()
        {
            foreach (var aggregator in AggregateBases)
            {
                aggregator.Initialize();
            }
        }

        protected void DeactivateMVCs()
        {
            foreach (var aggregator in AggregateBases)
            {
                aggregator.Deactivate();
            }
        }
    }
}