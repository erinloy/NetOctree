using System;
using System.Collections.Generic;
using System.Text;

namespace Octree
{
    public interface INode<TCoordinate>
    {
        TCoordinate Center { get; }
    }


    public interface IOctreeNode<TCoordinate> : INode<TCoordinate>
    {
        TCoordinate Center { get; }
    }


    public interface IOctreeNodeWithPayload<TCoordinate, TObject> : IOctreeNode<TCoordinate>
    {
        TObject Obj { get; }
    }
}
