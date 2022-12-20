using System.Collections.Generic;
using UnityEngine;

namespace SubclassSandbox
{
    public class StartUp : MonoBehaviour
    {
        private List<HeroClass> _heros = new();

        private void Start(){
            _heros.Add(new Archer());
            _heros.Add(new LanceMan());
            _heros.Add(new SwordsMan());
        }

        private void Update(){
            if (Input.GetKeyDown(KeyCode.Q)){
                //Activate each Hero
                foreach (var hero in _heros){
                    hero.Activate();
                }
            }
        }
    }
}