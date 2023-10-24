using System;

namespace Entitas
{
    public sealed class VirtualSparseSet<T>
    {
        const int InitialDataSize = 10;

        readonly SparseIndex _dataIndexLookup = new SparseIndex(); // array[entityId] = denseIndex in _componentData | 50.000 entities
        T[] _componentData = new T[InitialDataSize]; // actual component data                    | 10 entries
        int[] _entityIdLookup = new int[InitialDataSize]; // array[denseIndex] = entityId

        int _denseCount;

        public bool TryGetValue(int entityId, out T value)
        {
            var denseIndex = _dataIndexLookup[entityId];
            if (denseIndex >= 0)
            {
                value = _componentData[denseIndex];
                return true;
            }

            value = default(T);
            return false;
        }
        
        public bool Contains(int entityId)
        {
            return _dataIndexLookup[entityId] >= 0;
        }

        public void SetValue(int entityId, T value)
        {
            var denseIndex = _dataIndexLookup[entityId];
            if (denseIndex < 0)
            {
                denseIndex = _denseCount;
                if (denseIndex >= _componentData.Length)
                {
                    GrowDenseArrays();
                }

                _denseCount++;
                _dataIndexLookup[entityId] = denseIndex;
                _entityIdLookup[denseIndex] = entityId;
            }

            _componentData[denseIndex] = value;
        }

        void GrowDenseArrays()
        {
            var oldSize = _componentData.Length;
            var newSize = oldSize + (oldSize >> 1) + InitialDataSize;

            var newData = new T[newSize];
            var newIds = new int[newSize];

            _componentData.CopyTo(newData, 0);
            _entityIdLookup.CopyTo(newIds, 0);

            _componentData = newData;
            _entityIdLookup = newIds;
        }

        public void Remove(int entityId)
        {
            // Find inner and last
            var denseIdToRemove = _dataIndexLookup[entityId];
            if (denseIdToRemove < 0) return;

            var lastDense = _denseCount - 1;

            // Write values from last into inner and decrement, dropping the last element
            _componentData[denseIdToRemove] = _componentData[lastDense];
            var entityOfLast = _entityIdLookup[lastDense];
            _entityIdLookup[denseIdToRemove] = entityOfLast;
            _dataIndexLookup[entityOfLast] = denseIdToRemove;

            _denseCount--;

            // Set outer to deleted
            _dataIndexLookup[entityId] = -1;
        }
    }
}