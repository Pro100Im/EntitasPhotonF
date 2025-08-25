using Code.Infrastructure.AssetManagement;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure.View.Factory
{
    public class EntityViewFactory : IEntityViewFactory
    {
        private readonly IAssetProvider _assetProvider;
        private readonly IInstantiator _instantiator;

        public EntityViewFactory(IAssetProvider assetProvider, IInstantiator instantiator)
        {
            _assetProvider = assetProvider;
            _instantiator = instantiator;
        }

        public EntityBehaviour CreateViewForEntity(GameEntity entity)
        {
            EntityBehaviour viewPrefab = _assetProvider.LoadAsset<EntityBehaviour>(entity.viewPath.Value);
            EntityBehaviour view = _instantiator.InstantiatePrefabForComponent<EntityBehaviour>(
              viewPrefab,
              position: entity.worldPosition.Value,
              Quaternion.identity,
              parentTransform: null);

            view.SetEntity(entity);

            return view;
        }

        public EntityBehaviour CreateViewForEntityFromPrefab(GameEntity entity)
        {
            EntityBehaviour view = _instantiator.InstantiatePrefabForComponent<EntityBehaviour>(
              entity.viewPrefab.Value,
              position: entity.worldPosition.Value,
              Quaternion.identity,
              parentTransform: null);

            view.SetEntity(entity);

            return view;
        }
    }
}