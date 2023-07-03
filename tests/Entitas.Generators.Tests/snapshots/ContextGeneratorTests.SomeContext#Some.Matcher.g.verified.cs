﻿//HintName: Some.Matcher.g.cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by
//     Entitas.Generators.ContextGenerator.Matcher
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Some
{
public static class Matcher
{
    public static global::Entitas.IAllOfMatcher<Entity> AllOf(params ComponentIndex[] indices)
    {
#if UNITY_2021_3_OR_NEWER
        var indexes = global::Unity.Collections.LowLevel.Unsafe.UnsafeUtility.As<ComponentIndex[], int[]>(ref indices);
#else
        var indexes = global::System.Runtime.CompilerServices.Unsafe.As<ComponentIndex[], int[]>(ref indices);
#endif
        return global::Entitas.Matcher<Entity>.AllOf(indexes);
    }

    public static global::Entitas.IAnyOfMatcher<Entity> AnyOf(params ComponentIndex[] indices)
    {
#if UNITY_2021_3_OR_NEWER
        var indexes = global::Unity.Collections.LowLevel.Unsafe.UnsafeUtility.As<ComponentIndex[], int[]>(ref indices);
#else
        var indexes = global::System.Runtime.CompilerServices.Unsafe.As<ComponentIndex[], int[]>(ref indices);
#endif
        return global::Entitas.Matcher<Entity>.AnyOf(indexes);
    }

    public static global::Entitas.IAnyOfMatcher<Entity> AnyOf(this global::Entitas.IAllOfMatcher<Entity> matcher, params ComponentIndex[] indices)
    {
#if UNITY_2021_3_OR_NEWER
        var indexes = global::Unity.Collections.LowLevel.Unsafe.UnsafeUtility.As<ComponentIndex[], int[]>(ref indices);
#else
        var indexes = global::System.Runtime.CompilerServices.Unsafe.As<ComponentIndex[], int[]>(ref indices);
#endif
        return matcher.AnyOf(indexes);
    }

    public static global::Entitas.INoneOfMatcher<Entity> NoneOf(this global::Entitas.IAnyOfMatcher<Entity> matcher, params ComponentIndex[] indices)
    {
#if UNITY_2021_3_OR_NEWER
        var indexes = global::Unity.Collections.LowLevel.Unsafe.UnsafeUtility.As<ComponentIndex[], int[]>(ref indices);
#else
        var indexes = global::System.Runtime.CompilerServices.Unsafe.As<ComponentIndex[], int[]>(ref indices);
#endif
        return matcher.NoneOf(indexes);
    }
}
}
