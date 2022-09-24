using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SortItems
{
    public class ScriptableModel<TModel> : ScriptableObject where TModel : Model, new()
    {
        [SerializeField] protected TModel _model;

        public TModel Model
        {
            get => _model;
            set
            {
                _model = value;
            }
        }
    }
}
