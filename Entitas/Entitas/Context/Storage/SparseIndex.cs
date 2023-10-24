using System;
using System.Collections.Generic;

namespace Entitas
{
    public class SparseIndex
    {
        const int PageSize = 4096;
        const int IdsPerPage = PageSize / sizeof(int);

        static readonly int ShiftCount = (int)Math.Log(IdsPerPage, 2);

        readonly List<int[]> _chunks = new List<int[]>();
        readonly List<int> _chunkExistenceFlags = new List<int>();

        public int this[int sparseId]
        {
            get
            {
                var chunkIndex = sparseId >> ShiftCount;
                var flagIndex = chunkIndex >> 5;  // equivalent to chunkIndex / ChunksPerFlag
                var bitIndex = chunkIndex & 31;   // equivalent to chunkIndex % ChunksPerFlag
                var offset = sparseId & (IdsPerPage - 1);

                if (flagIndex >= _chunkExistenceFlags.Count || (_chunkExistenceFlags[flagIndex] & (1 << bitIndex)) == 0)
                {
                    return -1;
                }

                return _chunks[chunkIndex][offset];
            }
            set
            {
                var chunkIndex = sparseId >> ShiftCount;
                var flagIndex = chunkIndex >> 5;  // equivalent to chunkIndex / ChunksPerFlag
                var bitIndex = chunkIndex & 31;   // equivalent to chunkIndex % ChunksPerFlag
                var offset = sparseId & (IdsPerPage - 1);

                // Ensure the chunk exists
                if (flagIndex >= _chunkExistenceFlags.Count || (_chunkExistenceFlags[flagIndex] & (1 << bitIndex)) == 0)
                {
                    CreateChunk(chunkIndex, flagIndex, bitIndex);
                }

                _chunks[chunkIndex][offset] = value;
            }
        }

        void CreateChunk(int chunkIndex, int flagIndex, int bitIndex)
        {
            var data = new int[IdsPerPage];
            for (var i = 0; i < data.Length; i++)
            {
                data[i] = -1;
            }

            while (_chunks.Count <= chunkIndex)
            {
                _chunks.Add(null);
            }
            
            while (_chunkExistenceFlags.Count <= flagIndex)
            {
                _chunkExistenceFlags.Add(0);
            }
                    
            _chunkExistenceFlags[flagIndex] |= 1 << bitIndex;
            
            _chunks[chunkIndex] = data;
        }
    }
}
