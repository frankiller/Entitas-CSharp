//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public GameObjectComponent gameObject { get { return (GameObjectComponent)GetComponent(ComponentIds.GameObject); } }

        public bool hasGameObject { get { return HasComponent(ComponentIds.GameObject); } }

        public Entity AddGameObject(UnityEngine.GameObject newGameObject) {
            var component = CreateComponent<GameObjectComponent>(ComponentIds.GameObject);
            component.gameObject = newGameObject;
            return AddComponent(ComponentIds.GameObject, component);
        }

        public Entity ReplaceGameObject(UnityEngine.GameObject newGameObject) {
            var component = CreateComponent<GameObjectComponent>(ComponentIds.GameObject);
            component.gameObject = newGameObject;
            ReplaceComponent(ComponentIds.GameObject, component);
            return this;
        }

        public Entity RemoveGameObject() {
            return RemoveComponent(ComponentIds.GameObject);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherGameObject;

        public static IMatcher GameObject {
            get {
                if (_matcherGameObject == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.GameObject);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherGameObject = matcher;
                }

                return _matcherGameObject;
            }
        }
    }
}
