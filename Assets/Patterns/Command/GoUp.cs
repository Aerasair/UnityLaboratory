﻿using UnityEngine;

namespace Assets.Patterns.Command
{
    class GoUp : MonoBehaviour, ICommand
    {
        private GameObject go;
        private Vector2 _posBefore;


        public GoUp(GameObject gameObject)
        {
            this.go = gameObject;
            _posBefore = go.transform.position;
        }


        public void Execute()
        {
            go.transform.position = new Vector2(0, go.transform.position.y + 5);
        }

        public void Undo()
        {
            go.transform.position = _posBefore;
        }

    }
}
